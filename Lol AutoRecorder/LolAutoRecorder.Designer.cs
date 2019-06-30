namespace Lol_AutoRecorder
{
    partial class LolAutoRecorder
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
            this._labelLeagueClientPath = new System.Windows.Forms.Label();
            this._textBoxLeagueClientDirectoryPath = new System.Windows.Forms.TextBox();
            this._textBoxRoflFilePath = new System.Windows.Forms.TextBox();
            this._labelRoflFilePath = new System.Windows.Forms.Label();
            this._textBoxRecordingMetadataPath = new System.Windows.Forms.TextBox();
            this._labelRecordingMetadataPath = new System.Windows.Forms.Label();
            this._buttonRecord = new System.Windows.Forms.Button();
            this._textBoxClientExecutableName = new System.Windows.Forms.TextBox();
            this._labelClientExecutableName = new System.Windows.Forms.Label();
            this._circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this._labelRecordingStatusInfo = new System.Windows.Forms.Label();
            this._labelAdditionalInfo = new System.Windows.Forms.Label();
            this._textBoxRecordingSavePath = new System.Windows.Forms.TextBox();
            this._labelRecordingSavePath = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._comboBoxScreenMode = new System.Windows.Forms.ComboBox();
            this._labelScreenMode = new System.Windows.Forms.Label();
            this._DialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this._buttonChoseClientPath = new System.Windows.Forms.Button();
            this._buttonChooseRoflFilePath = new System.Windows.Forms.Button();
            this._buttonChooseRecordingMetadataPath = new System.Windows.Forms.Button();
            this._buttonChooseClientExecutablePath = new System.Windows.Forms.Button();
            this._buttonChooseRecordingSavePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelLeagueClientPath
            // 
            this._labelLeagueClientPath.AutoSize = true;
            this._labelLeagueClientPath.Location = new System.Drawing.Point(44, 26);
            this._labelLeagueClientPath.Name = "_labelLeagueClientPath";
            this._labelLeagueClientPath.Size = new System.Drawing.Size(142, 13);
            this._labelLeagueClientPath.TabIndex = 0;
            this._labelLeagueClientPath.Text = "League Client Directory Path";
            // 
            // _textBoxLeagueClientDirectoryPath
            // 
            this._textBoxLeagueClientDirectoryPath.Location = new System.Drawing.Point(196, 23);
            this._textBoxLeagueClientDirectoryPath.Name = "_textBoxLeagueClientDirectoryPath";
            this._textBoxLeagueClientDirectoryPath.Size = new System.Drawing.Size(424, 20);
            this._textBoxLeagueClientDirectoryPath.TabIndex = 1;
            // 
            // _textBoxRoflFilePath
            // 
            this._textBoxRoflFilePath.Location = new System.Drawing.Point(196, 75);
            this._textBoxRoflFilePath.Name = "_textBoxRoflFilePath";
            this._textBoxRoflFilePath.Size = new System.Drawing.Size(424, 20);
            this._textBoxRoflFilePath.TabIndex = 3;
            // 
            // _labelRoflFilePath
            // 
            this._labelRoflFilePath.AutoSize = true;
            this._labelRoflFilePath.Location = new System.Drawing.Point(44, 79);
            this._labelRoflFilePath.Name = "_labelRoflFilePath";
            this._labelRoflFilePath.Size = new System.Drawing.Size(79, 13);
            this._labelRoflFilePath.TabIndex = 2;
            this._labelRoflFilePath.Text = "ROFL File Path";
            // 
            // _textBoxRecordingMetadataPath
            // 
            this._textBoxRecordingMetadataPath.Location = new System.Drawing.Point(196, 101);
            this._textBoxRecordingMetadataPath.Name = "_textBoxRecordingMetadataPath";
            this._textBoxRecordingMetadataPath.Size = new System.Drawing.Size(424, 20);
            this._textBoxRecordingMetadataPath.TabIndex = 5;
            // 
            // _labelRecordingMetadataPath
            // 
            this._labelRecordingMetadataPath.AutoSize = true;
            this._labelRecordingMetadataPath.Location = new System.Drawing.Point(44, 105);
            this._labelRecordingMetadataPath.Name = "_labelRecordingMetadataPath";
            this._labelRecordingMetadataPath.Size = new System.Drawing.Size(129, 13);
            this._labelRecordingMetadataPath.TabIndex = 4;
            this._labelRecordingMetadataPath.Text = "Recording Metadata Path";
            // 
            // _buttonRecord
            // 
            this._buttonRecord.Location = new System.Drawing.Point(471, 156);
            this._buttonRecord.Name = "_buttonRecord";
            this._buttonRecord.Size = new System.Drawing.Size(75, 23);
            this._buttonRecord.TabIndex = 6;
            this._buttonRecord.Text = "Record!";
            this._buttonRecord.UseVisualStyleBackColor = true;
            this._buttonRecord.Click += new System.EventHandler(this._buttonRecord_Click);
            // 
            // _textBoxClientExecutableName
            // 
            this._textBoxClientExecutableName.Location = new System.Drawing.Point(196, 49);
            this._textBoxClientExecutableName.Name = "_textBoxClientExecutableName";
            this._textBoxClientExecutableName.Size = new System.Drawing.Size(424, 20);
            this._textBoxClientExecutableName.TabIndex = 8;
            // 
            // _labelClientExecutableName
            // 
            this._labelClientExecutableName.AutoSize = true;
            this._labelClientExecutableName.Location = new System.Drawing.Point(44, 52);
            this._labelClientExecutableName.Name = "_labelClientExecutableName";
            this._labelClientExecutableName.Size = new System.Drawing.Size(120, 13);
            this._labelClientExecutableName.TabIndex = 7;
            this._labelClientExecutableName.Text = "Client Executable Name";
            // 
            // _circularProgressBar1
            // 
            this._circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this._circularProgressBar1.AnimationSpeed = 500;
            this._circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this._circularProgressBar1.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._circularProgressBar1.ForeColor = System.Drawing.Color.SaddleBrown;
            this._circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._circularProgressBar1.InnerMargin = -10;
            this._circularProgressBar1.InnerWidth = 0;
            this._circularProgressBar1.Location = new System.Drawing.Point(440, 253);
            this._circularProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this._circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this._circularProgressBar1.Name = "_circularProgressBar1";
            this._circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this._circularProgressBar1.OuterMargin = -12;
            this._circularProgressBar1.OuterWidth = 8;
            this._circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._circularProgressBar1.ProgressWidth = 16;
            this._circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._circularProgressBar1.Size = new System.Drawing.Size(180, 180);
            this._circularProgressBar1.StartAngle = 270;
            this._circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this._circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this._circularProgressBar1.SubscriptText = "";
            this._circularProgressBar1.SuperscriptColor = System.Drawing.Color.Maroon;
            this._circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(5, 28, 0, 0);
            this._circularProgressBar1.SuperscriptText = "%";
            this._circularProgressBar1.TabIndex = 9;
            this._circularProgressBar1.Text = "0";
            this._circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8);
            this._circularProgressBar1.Value = 68;
            this._circularProgressBar1.Visible = false;
            // 
            // _labelRecordingStatusInfo
            // 
            this._labelRecordingStatusInfo.AutoSize = true;
            this._labelRecordingStatusInfo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelRecordingStatusInfo.Location = new System.Drawing.Point(57, 195);
            this._labelRecordingStatusInfo.Name = "_labelRecordingStatusInfo";
            this._labelRecordingStatusInfo.Size = new System.Drawing.Size(428, 39);
            this._labelRecordingStatusInfo.TabIndex = 10;
            this._labelRecordingStatusInfo.Text = "Waiting for user to start recording...";
            // 
            // _labelAdditionalInfo
            // 
            this._labelAdditionalInfo.AutoSize = true;
            this._labelAdditionalInfo.Location = new System.Drawing.Point(21, 411);
            this._labelAdditionalInfo.Name = "_labelAdditionalInfo";
            this._labelAdditionalInfo.Size = new System.Drawing.Size(0, 13);
            this._labelAdditionalInfo.TabIndex = 11;
            // 
            // _textBoxRecordingSavePath
            // 
            this._textBoxRecordingSavePath.Location = new System.Drawing.Point(196, 127);
            this._textBoxRecordingSavePath.Name = "_textBoxRecordingSavePath";
            this._textBoxRecordingSavePath.Size = new System.Drawing.Size(424, 20);
            this._textBoxRecordingSavePath.TabIndex = 13;
            // 
            // _labelRecordingSavePath
            // 
            this._labelRecordingSavePath.AutoSize = true;
            this._labelRecordingSavePath.Location = new System.Drawing.Point(44, 130);
            this._labelRecordingSavePath.Name = "_labelRecordingSavePath";
            this._labelRecordingSavePath.Size = new System.Drawing.Size(109, 13);
            this._labelRecordingSavePath.TabIndex = 12;
            this._labelRecordingSavePath.Text = "Recording Save Path";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(545, 156);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 15;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this._buttonCancel_Click);
            // 
            // _comboBoxScreenMode
            // 
            this._comboBoxScreenMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxScreenMode.FormattingEnabled = true;
            this._comboBoxScreenMode.Items.AddRange(new object[] {
            "Window Mode",
            "Full Screen"});
            this._comboBoxScreenMode.Location = new System.Drawing.Point(196, 153);
            this._comboBoxScreenMode.Name = "_comboBoxScreenMode";
            this._comboBoxScreenMode.Size = new System.Drawing.Size(121, 21);
            this._comboBoxScreenMode.TabIndex = 16;
            // 
            // _labelScreenMode
            // 
            this._labelScreenMode.AutoSize = true;
            this._labelScreenMode.Location = new System.Drawing.Point(44, 157);
            this._labelScreenMode.Name = "_labelScreenMode";
            this._labelScreenMode.Size = new System.Drawing.Size(71, 13);
            this._labelScreenMode.TabIndex = 17;
            this._labelScreenMode.Text = "Screen Mode";
            // 
            // _DialogOpenFile
            // 
            this._DialogOpenFile.FileName = "openFileDialog1";
            // 
            // _buttonChoseClientPath
            // 
            this._buttonChoseClientPath.Location = new System.Drawing.Point(626, 23);
            this._buttonChoseClientPath.Name = "_buttonChoseClientPath";
            this._buttonChoseClientPath.Size = new System.Drawing.Size(29, 20);
            this._buttonChoseClientPath.TabIndex = 18;
            this._buttonChoseClientPath.Text = "...";
            this._buttonChoseClientPath.UseVisualStyleBackColor = true;
            this._buttonChoseClientPath.Click += new System.EventHandler(this._buttonChoseClientPath_Click);
            // 
            // _buttonChooseRoflFilePath
            // 
            this._buttonChooseRoflFilePath.Location = new System.Drawing.Point(626, 75);
            this._buttonChooseRoflFilePath.Name = "_buttonChooseRoflFilePath";
            this._buttonChooseRoflFilePath.Size = new System.Drawing.Size(29, 20);
            this._buttonChooseRoflFilePath.TabIndex = 19;
            this._buttonChooseRoflFilePath.Text = "...";
            this._buttonChooseRoflFilePath.UseVisualStyleBackColor = true;
            this._buttonChooseRoflFilePath.Click += new System.EventHandler(this._buttonChooseRoflFilePath_Click);
            // 
            // _buttonChooseRecordingMetadataPath
            // 
            this._buttonChooseRecordingMetadataPath.Location = new System.Drawing.Point(626, 101);
            this._buttonChooseRecordingMetadataPath.Name = "_buttonChooseRecordingMetadataPath";
            this._buttonChooseRecordingMetadataPath.Size = new System.Drawing.Size(29, 20);
            this._buttonChooseRecordingMetadataPath.TabIndex = 20;
            this._buttonChooseRecordingMetadataPath.Text = "...";
            this._buttonChooseRecordingMetadataPath.UseVisualStyleBackColor = true;
            this._buttonChooseRecordingMetadataPath.Click += new System.EventHandler(this._buttonChooseRecordingMetadataPath_Click);
            // 
            // _buttonChooseClientExecutablePath
            // 
            this._buttonChooseClientExecutablePath.Location = new System.Drawing.Point(626, 49);
            this._buttonChooseClientExecutablePath.Name = "_buttonChooseClientExecutablePath";
            this._buttonChooseClientExecutablePath.Size = new System.Drawing.Size(29, 20);
            this._buttonChooseClientExecutablePath.TabIndex = 21;
            this._buttonChooseClientExecutablePath.Text = "...";
            this._buttonChooseClientExecutablePath.UseVisualStyleBackColor = true;
            this._buttonChooseClientExecutablePath.Click += new System.EventHandler(this._buttonChooseClientExecutablePath_Click);
            // 
            // _buttonChooseRecordingSavePath
            // 
            this._buttonChooseRecordingSavePath.Location = new System.Drawing.Point(626, 127);
            this._buttonChooseRecordingSavePath.Name = "_buttonChooseRecordingSavePath";
            this._buttonChooseRecordingSavePath.Size = new System.Drawing.Size(29, 20);
            this._buttonChooseRecordingSavePath.TabIndex = 22;
            this._buttonChooseRecordingSavePath.Text = "...";
            this._buttonChooseRecordingSavePath.UseVisualStyleBackColor = true;
            this._buttonChooseRecordingSavePath.Click += new System.EventHandler(this._buttonChooseRecordingSavePath_Click);
            // 
            // LolAutoRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 451);
            this.Controls.Add(this._buttonChooseRecordingSavePath);
            this.Controls.Add(this._buttonChooseClientExecutablePath);
            this.Controls.Add(this._buttonChooseRecordingMetadataPath);
            this.Controls.Add(this._buttonChooseRoflFilePath);
            this.Controls.Add(this._buttonChoseClientPath);
            this.Controls.Add(this._labelScreenMode);
            this.Controls.Add(this._comboBoxScreenMode);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._textBoxRecordingSavePath);
            this.Controls.Add(this._labelRecordingSavePath);
            this.Controls.Add(this._labelAdditionalInfo);
            this.Controls.Add(this._labelRecordingStatusInfo);
            this.Controls.Add(this._circularProgressBar1);
            this.Controls.Add(this._textBoxClientExecutableName);
            this.Controls.Add(this._labelClientExecutableName);
            this.Controls.Add(this._buttonRecord);
            this.Controls.Add(this._textBoxRecordingMetadataPath);
            this.Controls.Add(this._labelRecordingMetadataPath);
            this.Controls.Add(this._textBoxRoflFilePath);
            this.Controls.Add(this._labelRoflFilePath);
            this.Controls.Add(this._textBoxLeagueClientDirectoryPath);
            this.Controls.Add(this._labelLeagueClientPath);
            this.Name = "LolAutoRecorder";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LolAutoRecorder_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelLeagueClientPath;
        private System.Windows.Forms.TextBox _textBoxLeagueClientDirectoryPath;
        private System.Windows.Forms.TextBox _textBoxRoflFilePath;
        private System.Windows.Forms.Label _labelRoflFilePath;
        private System.Windows.Forms.TextBox _textBoxRecordingMetadataPath;
        private System.Windows.Forms.Label _labelRecordingMetadataPath;
        private System.Windows.Forms.Button _buttonRecord;
        private System.Windows.Forms.TextBox _textBoxClientExecutableName;
        private System.Windows.Forms.Label _labelClientExecutableName;
        private CircularProgressBar.CircularProgressBar _circularProgressBar1;
        private System.Windows.Forms.Label _labelRecordingStatusInfo;
        private System.Windows.Forms.Label _labelAdditionalInfo;
        private System.Windows.Forms.TextBox _textBoxRecordingSavePath;
        private System.Windows.Forms.Label _labelRecordingSavePath;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.ComboBox _comboBoxScreenMode;
        private System.Windows.Forms.Label _labelScreenMode;
        private System.Windows.Forms.OpenFileDialog _DialogOpenFile;
        private System.Windows.Forms.Button _buttonChoseClientPath;
        private System.Windows.Forms.Button _buttonChooseRoflFilePath;
        private System.Windows.Forms.Button _buttonChooseRecordingMetadataPath;
        private System.Windows.Forms.Button _buttonChooseClientExecutablePath;
        private System.Windows.Forms.Button _buttonChooseRecordingSavePath;
    }
}

