using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.IO;


namespace FileFinder
{
	public partial class FileFinder : Form
	{
		public FileFinder()
		{
			InitializeComponent();
		}

        private bool _continueWork = true;
        private bool _searchingInFiles = false;

		#region Update UI Controls
		private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);
		public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
			}
			else
			{
				control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
			}
		}

		private delegate object GetControlPropertyThreadSafeDelegate(Control control, string propertyName);
		public static object GetControlPropertyThreadSafe(Control control, string propertyName)
		{
			if (control.InvokeRequired)
			{
				return control.Invoke(new GetControlPropertyThreadSafeDelegate(GetControlPropertyThreadSafe), new object[] { control, propertyName });
			}
			else
			{
				return control.GetType().InvokeMember(propertyName, BindingFlags.GetProperty, null, control, new object[] { });
			}
		}



		private delegate void CallMethodThreadSafeDelegate(Control control, string method, object[] parameters);
		public static void CallMethodThreadSafe(Control control, string method, object[] parameters)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new CallMethodThreadSafeDelegate(CallMethodThreadSafe), new object[] { control, method, parameters });
			}
			else
			{
				control.GetType().InvokeMember(method, BindingFlags.InvokeMethod, null, control, parameters);
			}
		}

		#endregion Update UI Controls

		#region Update Log

		private delegate void OutputScrollToCaretDelegate(Control control);
		public static void OutputScrollToCaret(Control control)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new OutputScrollToCaretDelegate(OutputScrollToCaret), new object[] { control });
			}
			else
			{
				control.GetType().InvokeMember("ScrollToCaret", BindingFlags.InvokeMethod, null, control, new object[] { });
				control.GetType().InvokeMember("Refresh", BindingFlags.InvokeMethod, null, control, new object[] { });
			}
		}
		private void AddLineToOutput(string message)
		{
			this.AddLineToOutput(message, true);
		}
		private void AddLineToOutput(string message, bool includeTimeStamp)
		{
			AddToOutput(message, Environment.NewLine, includeTimeStamp);
		}
		private void AddToOutput(string message)
		{
			AddToOutput(message, string.Empty, false);
		}
		private void AddToOutput(string message, string spacer, bool includeTimeStamp)
		{
			string timestampPrefix = string.Empty;
			if (includeTimeStamp)
			{
				timestampPrefix = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss - ");
			}
			SetControlPropertyThreadSafe(txtOutput, "Text", string.Format("{0}{1}{2}{3}", txtOutput.Text, timestampPrefix, message, spacer));

			int textLength = (int)GetControlPropertyThreadSafe(txtOutput, "TextLength");
			SetControlPropertyThreadSafe(txtOutput, "SelectionStart", textLength - 1);
			OutputScrollToCaret(txtOutput);
		}

		#endregion Update Log

        /// <summary>
        /// Method called when the form is initialized
        /// </summary>
        private void FileFinder_Load(object sender, EventArgs e)
        {
            UpdateControlStatus(false);
            dtpFileDate.Value = DateTime.Now;
            lblProgress.Text = "";
        }

        #region UpdateControlStatus

        /// <summary>
        /// Updates the controls to enabled / disabled depending on app status
        /// </summary>
        /// <param name="isRunning"></param>
        private void UpdateControlStatus(bool isRunning)
        {
            SetControlPropertyThreadSafe(btnSearch, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(btnCancel, "Enabled", isRunning);
            SetControlPropertyThreadSafe(txtOutput, "ReadOnly", isRunning);
            SetControlPropertyThreadSafe(txtSearchValues, "ReadOnly", isRunning);
            SetControlPropertyThreadSafe(txtSourcePaths, "ReadOnly", isRunning);
            SetControlPropertyThreadSafe(chkDate, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(chkIncludeSubFolders, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(dtpFileDate, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(btnClearOutput, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(txtOutput, "ReadOnly", isRunning);
            SetControlPropertyThreadSafe(rdbFileName, "Enabled", !isRunning);
            SetControlPropertyThreadSafe(rdbFileContent, "Enabled", !isRunning);
        }
        #endregion UpdateControlStatus

        /// <summary>
        /// Method called to trigger the backgrouund worker
        /// </summary>
		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
            AddLineToOutput("Start");
            _continueWork = true;
            UpdateControlStatus(true);
            DateTime dateValue = DateTime.MinValue;
            if ((bool)GetControlPropertyThreadSafe(chkDate, "Checked"))
            {
                dateValue = dtpFileDate.Value.Date;
            }
            SearchFiles((string)GetControlPropertyThreadSafe(txtSourcePaths, "Text"), (string)GetControlPropertyThreadSafe(txtSearchValues, "Text"), (string)GetControlPropertyThreadSafe(txtFileNamePattern, "Text"), (bool)GetControlPropertyThreadSafe(chkIncludeSubFolders, "Checked"), dateValue);
		}

        /// <summary>
        /// Method called when background worker has finished its work
        /// </summary>
		private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
            AddLineToOutput("End");
            UpdateControlStatus(false);
		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _continueWork = false;
        }

        /// <summary>
        /// Search for files
        /// </summary>
        private void SearchFiles(string sourcePaths, string searchValues, string fileNamePattern, bool includeSubFolders, DateTime dateAfter)
        {
            try
            {
                _searchingInFiles = false;

                // collect all files from folders (after dateAfter)
                // loop all the files searching for the value

                // collect all folders (include subfolders)
                List<DirectoryInfo> mainPaths = new List<DirectoryInfo>();
                List<DirectoryInfo> paths = new List<DirectoryInfo>();
                string[] sourcePathsArray = sourcePaths.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string currentPath in sourcePathsArray)
                {
                    DirectoryInfo newDir = new DirectoryInfo(currentPath);
                    paths.Add(newDir);
                    mainPaths.Add(newDir);
                }
                if (includeSubFolders)
                {
                    SetControlPropertyThreadSafe(prgBottom, "Minimum", 0);
                    SetControlPropertyThreadSafe(prgBottom, "Value", 0);
                    SetControlPropertyThreadSafe(prgBottom, "Maximum", sourcePathsArray.Length);
                    AddLineToOutput("Calculating SubFolders...");
                    foreach (DirectoryInfo currentPath in mainPaths)
                    {
                        if (!_continueWork)
                        {
                            break;
                        }
                        GetSubFolders(ref paths, currentPath, dateAfter);
                        AddToProgressBar();
                    }
                }
                AddLineToOutput(string.Format("Folders found: {0}", paths.Count));

                // identify all the files to search
                SetControlPropertyThreadSafe(prgBottom, "Minimum", 0);
                SetControlPropertyThreadSafe(prgBottom, "Value", 0);
                SetControlPropertyThreadSafe(prgBottom, "Maximum", paths.Count);
                AddLineToOutput("Calculating Files...");
                List<FileInfo> files = new List<FileInfo>();
                foreach (DirectoryInfo currentDirectory in paths)
                {
                    if (fileNamePattern.Length == 0)
                    {
                        fileNamePattern = "*";
                    }
                    FileInfo[] dirFiles = currentDirectory.GetFiles(fileNamePattern);
                    foreach (FileInfo currentFile in dirFiles)
                    {
                        if (!_continueWork)
                        {
                            break;
                        }
                        if ((dateAfter == DateTime.MinValue) || (currentFile.LastWriteTime >= dateAfter))
                        {
                            files.Add(currentFile);
                        }
                    }
                    AddToProgressBar();
                }

                AddLineToOutput(string.Format("Files found: {0}", files.Count));

                SetControlPropertyThreadSafe(prgBottom, "Minimum", 0);
                SetControlPropertyThreadSafe(prgBottom, "Value", 0);
                SetControlPropertyThreadSafe(prgBottom, "Maximum", files.Count);
                AddLineToOutput("Searching in Files...");

                string[] searchValuesArray = searchValues.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<string> searchValuesList = new List<string>();
                searchValuesList.AddRange(searchValuesArray);
                _searchingInFiles = true;
                foreach (FileInfo currentFile in files)
                {
                    if (!_continueWork)
                    {
                        break;
                    }
                    // search in the file content
                    if ((bool)GetControlPropertyThreadSafe(rdbFileContent, "Checked"))
                    {
                        SearchInFile(currentFile, searchValuesList);
                    }
                    // search  in the file name
                    else if ((bool)GetControlPropertyThreadSafe(rdbFileName, "Checked"))
                    {
                        if (searchValuesList.Contains(currentFile.Name))
                        {
                            AddLineToOutput(string.Format("File '{0}' found' ({1}/{2}/{3})", currentFile.FullName, currentFile.LastWriteTime.Year, currentFile.LastWriteTime.Month, currentFile.LastWriteTime.Day));
                        }
                    }

                    AddToProgressBar();
                }
            }
            catch (Exception ex)
            {
                AddLineToOutput("Error found while searching for files");
                AddLineToOutput(ex.Message);
                AddLineToOutput(ex.ToString());
            }
        }

        private void AddToProgressBar()
        {
            int maxValue = (int)GetControlPropertyThreadSafe(prgBottom, "Maximum");
            int value = (int)GetControlPropertyThreadSafe(prgBottom, "Value");
            if (value < maxValue)
            {
                SetControlPropertyThreadSafe(prgBottom, "Value", ((int)GetControlPropertyThreadSafe(prgBottom, "Value")) + 1);
            }
            value = (int)GetControlPropertyThreadSafe(prgBottom, "Value");

            // update the file count label
            if (_searchingInFiles)
            {
                SetControlPropertyThreadSafe(lblProgress, "Text", string.Format("File {0} of {1}", value, maxValue));
            }
        }

        private void GetSubFolders(ref List<DirectoryInfo> paths, DirectoryInfo path, DateTime lastWriteTime)
        {
            if (path.Exists)
            {
                DirectoryInfo[] subDirectories = path.GetDirectories();

                SetControlPropertyThreadSafe(prgBottom, "Maximum", ((int)GetControlPropertyThreadSafe(prgBottom, "Maximum")) + subDirectories.Length);
                AddToProgressBar();

                foreach (DirectoryInfo currentSubDirectory in subDirectories)
                {
                    if (!_continueWork)
                    {
                        break;
                    }

                    if ((lastWriteTime == DateTime.MinValue) || (currentSubDirectory.LastWriteTime >= lastWriteTime))
                    {
                        paths.Add(currentSubDirectory);
                        GetSubFolders(ref paths, currentSubDirectory, lastWriteTime);
                    }
                    else
                    {
                        AddToProgressBar();
                    }
                }
            }
        }

        /// <summary>
        /// Search a list of values in a file
        /// </summary>
        private void SearchInFile(FileInfo file, List<string> values)
        {
            // control to make the file reading stop once all values from the list have been found in a file
            Hashtable valueTracker = BuildHashtableForValueList(values);

            if (file.Exists)
            {
                StreamReader reader = file.OpenText();
                while (reader.Peek() >= 0 && valueTracker.ContainsValue(null))
                {
                    string line = reader.ReadLine();
                    foreach (string currentSearchValue in values)
                    {
                        if (!_continueWork)
                        {
                            break;
                        }
                        if (line.Contains(currentSearchValue))
                        {
                            AddLineToOutput(string.Format("Value '{0}' found in file '{1}' ({2}/{3}/{4})", currentSearchValue, file.FullName, file.LastWriteTime.Year, file.LastWriteTime.Month, file.LastWriteTime.Day));
                            valueTracker[currentSearchValue] = true;
                        }
                    }
                }
                reader.Close();
            }
        }

        private Hashtable BuildHashtableForValueList(List<string> values)
        {
            Hashtable result = new Hashtable();
            foreach (string currentValue in values)
            {
                result[currentValue] = null;
            }
            return result;
        }

        /// <summary>
        /// Method called when clicked on the clear output
        /// </summary>
        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            SetControlPropertyThreadSafe(txtOutput, "Text", string.Empty);
        }

	}
}
