namespace FileFinder
{
    partial class FileFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSourcePaths = new System.Windows.Forms.GroupBox();
            this.txtSourcePaths = new System.Windows.Forms.TextBox();
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.spltTop = new System.Windows.Forms.SplitContainer();
            this.pnlSourcePathsBottom = new System.Windows.Forms.Panel();
            this.chkUniqueValuePerFile = new System.Windows.Forms.CheckBox();
            this.chkIncludeOnlyFileNames = new System.Windows.Forms.CheckBox();
            this.txtFileNamePattern = new System.Windows.Forms.TextBox();
            this.lblFileNamePattern = new System.Windows.Forms.Label();
            this.chkDateMin = new System.Windows.Forms.CheckBox();
            this.dtpFileDateMin = new System.Windows.Forms.DateTimePicker();
            this.chkIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.grpSearchValues = new System.Windows.Forms.GroupBox();
            this.rdbFileName = new System.Windows.Forms.RadioButton();
            this.rdbFileContent = new System.Windows.Forms.RadioButton();
            this.txtSearchValues = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlPrgBottom = new System.Windows.Forms.Panel();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.prgBottom = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.chkDateMax = new System.Windows.Forms.CheckBox();
            this.dtpFileDateMax = new System.Windows.Forms.DateTimePicker();
            this.grpSourcePaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTop)).BeginInit();
            this.spltTop.Panel1.SuspendLayout();
            this.spltTop.Panel2.SuspendLayout();
            this.spltTop.SuspendLayout();
            this.pnlSourcePathsBottom.SuspendLayout();
            this.grpSearchValues.SuspendLayout();
            this.pnlPrgBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSourcePaths
            // 
            this.grpSourcePaths.Controls.Add(this.txtSourcePaths);
            this.grpSourcePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSourcePaths.Location = new System.Drawing.Point(0, 0);
            this.grpSourcePaths.Name = "grpSourcePaths";
            this.grpSourcePaths.Padding = new System.Windows.Forms.Padding(8);
            this.grpSourcePaths.Size = new System.Drawing.Size(550, 176);
            this.grpSourcePaths.TabIndex = 0;
            this.grpSourcePaths.TabStop = false;
            this.grpSourcePaths.Text = "Source Paths";
            // 
            // txtSourcePaths
            // 
            this.txtSourcePaths.BackColor = System.Drawing.Color.White;
            this.txtSourcePaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourcePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourcePaths.Location = new System.Drawing.Point(8, 21);
            this.txtSourcePaths.Multiline = true;
            this.txtSourcePaths.Name = "txtSourcePaths";
            this.txtSourcePaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSourcePaths.Size = new System.Drawing.Size(534, 147);
            this.txtSourcePaths.TabIndex = 0;
            // 
            // spltMain
            // 
            this.spltMain.BackColor = System.Drawing.SystemColors.Control;
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(8, 8);
            this.spltMain.Name = "spltMain";
            this.spltMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.spltTop);
            this.spltMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.txtOutput);
            this.spltMain.Panel2.Controls.Add(this.pnlPrgBottom);
            this.spltMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spltMain.Size = new System.Drawing.Size(1205, 529);
            this.spltMain.SplitterDistance = 250;
            this.spltMain.TabIndex = 1;
            // 
            // spltTop
            // 
            this.spltTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltTop.Location = new System.Drawing.Point(0, 0);
            this.spltTop.Name = "spltTop";
            // 
            // spltTop.Panel1
            // 
            this.spltTop.Panel1.Controls.Add(this.grpSourcePaths);
            this.spltTop.Panel1.Controls.Add(this.pnlSourcePathsBottom);
            // 
            // spltTop.Panel2
            // 
            this.spltTop.Panel2.Controls.Add(this.grpSearchValues);
            this.spltTop.Size = new System.Drawing.Size(1205, 250);
            this.spltTop.SplitterDistance = 550;
            this.spltTop.TabIndex = 0;
            // 
            // pnlSourcePathsBottom
            // 
            this.pnlSourcePathsBottom.Controls.Add(this.dtpFileDateMax);
            this.pnlSourcePathsBottom.Controls.Add(this.chkDateMax);
            this.pnlSourcePathsBottom.Controls.Add(this.chkUniqueValuePerFile);
            this.pnlSourcePathsBottom.Controls.Add(this.chkIncludeOnlyFileNames);
            this.pnlSourcePathsBottom.Controls.Add(this.txtFileNamePattern);
            this.pnlSourcePathsBottom.Controls.Add(this.lblFileNamePattern);
            this.pnlSourcePathsBottom.Controls.Add(this.chkDateMin);
            this.pnlSourcePathsBottom.Controls.Add(this.dtpFileDateMin);
            this.pnlSourcePathsBottom.Controls.Add(this.chkIncludeSubFolders);
            this.pnlSourcePathsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSourcePathsBottom.Location = new System.Drawing.Point(0, 176);
            this.pnlSourcePathsBottom.Name = "pnlSourcePathsBottom";
            this.pnlSourcePathsBottom.Size = new System.Drawing.Size(550, 74);
            this.pnlSourcePathsBottom.TabIndex = 0;
            // 
            // chkUniqueValuePerFile
            // 
            this.chkUniqueValuePerFile.AutoSize = true;
            this.chkUniqueValuePerFile.Location = new System.Drawing.Point(243, 29);
            this.chkUniqueValuePerFile.Name = "chkUniqueValuePerFile";
            this.chkUniqueValuePerFile.Size = new System.Drawing.Size(133, 17);
            this.chkUniqueValuePerFile.TabIndex = 7;
            this.chkUniqueValuePerFile.Text = "Unique Values Per File";
            this.chkUniqueValuePerFile.UseVisualStyleBackColor = true;
            // 
            // chkIncludeOnlyFileNames
            // 
            this.chkIncludeOnlyFileNames.AutoSize = true;
            this.chkIncludeOnlyFileNames.Location = new System.Drawing.Point(123, 29);
            this.chkIncludeOnlyFileNames.Name = "chkIncludeOnlyFileNames";
            this.chkIncludeOnlyFileNames.Size = new System.Drawing.Size(102, 17);
            this.chkIncludeOnlyFileNames.TabIndex = 6;
            this.chkIncludeOnlyFileNames.Text = "File Names Only";
            this.chkIncludeOnlyFileNames.UseVisualStyleBackColor = true;
            // 
            // txtFileNamePattern
            // 
            this.txtFileNamePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNamePattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNamePattern.Location = new System.Drawing.Point(97, 3);
            this.txtFileNamePattern.Name = "txtFileNamePattern";
            this.txtFileNamePattern.Size = new System.Drawing.Size(453, 20);
            this.txtFileNamePattern.TabIndex = 5;
            // 
            // lblFileNamePattern
            // 
            this.lblFileNamePattern.AutoSize = true;
            this.lblFileNamePattern.Location = new System.Drawing.Point(-3, 6);
            this.lblFileNamePattern.Name = "lblFileNamePattern";
            this.lblFileNamePattern.Size = new System.Drawing.Size(91, 13);
            this.lblFileNamePattern.TabIndex = 4;
            this.lblFileNamePattern.Text = "File Name Pattern";
            // 
            // chkDateMin
            // 
            this.chkDateMin.AutoSize = true;
            this.chkDateMin.Checked = true;
            this.chkDateMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateMin.Location = new System.Drawing.Point(3, 52);
            this.chkDateMin.Name = "chkDateMin";
            this.chkDateMin.Size = new System.Drawing.Size(72, 17);
            this.chkDateMin.TabIndex = 3;
            this.chkDateMin.Text = "Files After";
            this.chkDateMin.UseVisualStyleBackColor = true;
            // 
            // dtpFileDateMin
            // 
            this.dtpFileDateMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFileDateMin.Location = new System.Drawing.Point(81, 47);
            this.dtpFileDateMin.Name = "dtpFileDateMin";
            this.dtpFileDateMin.Size = new System.Drawing.Size(101, 20);
            this.dtpFileDateMin.TabIndex = 2;
            // 
            // chkIncludeSubFolders
            // 
            this.chkIncludeSubFolders.AutoSize = true;
            this.chkIncludeSubFolders.Checked = true;
            this.chkIncludeSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubFolders.Location = new System.Drawing.Point(3, 29);
            this.chkIncludeSubFolders.Name = "chkIncludeSubFolders";
            this.chkIncludeSubFolders.Size = new System.Drawing.Size(114, 17);
            this.chkIncludeSubFolders.TabIndex = 0;
            this.chkIncludeSubFolders.Text = "Include Subfolders";
            this.chkIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // grpSearchValues
            // 
            this.grpSearchValues.Controls.Add(this.rdbFileName);
            this.grpSearchValues.Controls.Add(this.rdbFileContent);
            this.grpSearchValues.Controls.Add(this.txtSearchValues);
            this.grpSearchValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchValues.Location = new System.Drawing.Point(0, 0);
            this.grpSearchValues.Name = "grpSearchValues";
            this.grpSearchValues.Size = new System.Drawing.Size(651, 250);
            this.grpSearchValues.TabIndex = 0;
            this.grpSearchValues.TabStop = false;
            this.grpSearchValues.Text = "Search Values";
            // 
            // rdbFileName
            // 
            this.rdbFileName.AutoSize = true;
            this.rdbFileName.Location = new System.Drawing.Point(93, 21);
            this.rdbFileName.Name = "rdbFileName";
            this.rdbFileName.Size = new System.Drawing.Size(72, 17);
            this.rdbFileName.TabIndex = 2;
            this.rdbFileName.TabStop = true;
            this.rdbFileName.Text = "File Name";
            this.rdbFileName.UseVisualStyleBackColor = true;
            // 
            // rdbFileContent
            // 
            this.rdbFileContent.AutoSize = true;
            this.rdbFileContent.Checked = true;
            this.rdbFileContent.Location = new System.Drawing.Point(6, 19);
            this.rdbFileContent.Name = "rdbFileContent";
            this.rdbFileContent.Size = new System.Drawing.Size(81, 17);
            this.rdbFileContent.TabIndex = 1;
            this.rdbFileContent.TabStop = true;
            this.rdbFileContent.Text = "File Content";
            this.rdbFileContent.UseVisualStyleBackColor = true;
            // 
            // txtSearchValues
            // 
            this.txtSearchValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchValues.BackColor = System.Drawing.Color.White;
            this.txtSearchValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchValues.Location = new System.Drawing.Point(3, 44);
            this.txtSearchValues.MaxLength = 327670;
            this.txtSearchValues.Multiline = true;
            this.txtSearchValues.Name = "txtSearchValues";
            this.txtSearchValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchValues.Size = new System.Drawing.Size(645, 203);
            this.txtSearchValues.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.MaxLength = 327679;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1205, 215);
            this.txtOutput.TabIndex = 1;
            // 
            // pnlPrgBottom
            // 
            this.pnlPrgBottom.Controls.Add(this.btnClearOutput);
            this.pnlPrgBottom.Controls.Add(this.lblProgress);
            this.pnlPrgBottom.Controls.Add(this.btnCancel);
            this.pnlPrgBottom.Controls.Add(this.btnSearch);
            this.pnlPrgBottom.Controls.Add(this.prgBottom);
            this.pnlPrgBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrgBottom.Location = new System.Drawing.Point(0, 215);
            this.pnlPrgBottom.Name = "pnlPrgBottom";
            this.pnlPrgBottom.Size = new System.Drawing.Size(1205, 60);
            this.pnlPrgBottom.TabIndex = 0;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutput.Location = new System.Drawing.Point(933, 32);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(110, 23);
            this.btnClearOutput.TabIndex = 4;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(-3, 37);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(58, 13);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "lblProgress";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1130, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1049, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // prgBottom
            // 
            this.prgBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBottom.Location = new System.Drawing.Point(0, 3);
            this.prgBottom.Name = "prgBottom";
            this.prgBottom.Size = new System.Drawing.Size(1205, 23);
            this.prgBottom.TabIndex = 0;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // chkDateMax
            // 
            this.chkDateMax.AutoSize = true;
            this.chkDateMax.Checked = true;
            this.chkDateMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateMax.Location = new System.Drawing.Point(188, 50);
            this.chkDateMax.Name = "chkDateMax";
            this.chkDateMax.Size = new System.Drawing.Size(81, 17);
            this.chkDateMax.TabIndex = 8;
            this.chkDateMax.Text = "Files Before";
            this.chkDateMax.UseVisualStyleBackColor = true;
            // 
            // dtpFileDateMax
            // 
            this.dtpFileDateMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFileDateMax.Location = new System.Drawing.Point(275, 47);
            this.dtpFileDateMax.Name = "dtpFileDateMax";
            this.dtpFileDateMax.Size = new System.Drawing.Size(101, 20);
            this.dtpFileDateMax.TabIndex = 9;
            // 
            // FileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 545);
            this.Controls.Add(this.spltMain);
            this.MinimumSize = new System.Drawing.Size(1237, 583);
            this.Name = "FileFinder";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "File Finder";
            this.Load += new System.EventHandler(this.FileFinder_Load);
            this.grpSourcePaths.ResumeLayout(false);
            this.grpSourcePaths.PerformLayout();
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            this.spltMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.spltTop.Panel1.ResumeLayout(false);
            this.spltTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltTop)).EndInit();
            this.spltTop.ResumeLayout(false);
            this.pnlSourcePathsBottom.ResumeLayout(false);
            this.pnlSourcePathsBottom.PerformLayout();
            this.grpSearchValues.ResumeLayout(false);
            this.grpSearchValues.PerformLayout();
            this.pnlPrgBottom.ResumeLayout(false);
            this.pnlPrgBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSourcePaths;
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.SplitContainer spltTop;
        private System.Windows.Forms.Panel pnlSourcePathsBottom;
        private System.Windows.Forms.CheckBox chkIncludeSubFolders;
        private System.Windows.Forms.TextBox txtSourcePaths;
        private System.Windows.Forms.Panel pnlPrgBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ProgressBar prgBottom;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpSearchValues;
        private System.Windows.Forms.TextBox txtSearchValues;
        private System.Windows.Forms.DateTimePicker dtpFileDateMin;
        private System.Windows.Forms.CheckBox chkDateMin;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.TextBox txtFileNamePattern;
        private System.Windows.Forms.Label lblFileNamePattern;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.RadioButton rdbFileName;
        private System.Windows.Forms.RadioButton rdbFileContent;
        private System.Windows.Forms.CheckBox chkIncludeOnlyFileNames;
        private System.Windows.Forms.CheckBox chkUniqueValuePerFile;
        private System.Windows.Forms.CheckBox chkDateMax;
        private System.Windows.Forms.DateTimePicker dtpFileDateMax;
    }
}

