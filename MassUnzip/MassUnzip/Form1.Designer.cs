namespace MassUnzip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zipLocale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.browseOutput = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.TextBox();
            this.moveRB = new System.Windows.Forms.RadioButton();
            this.renameRB = new System.Windows.Forms.RadioButton();
            this.deletRB = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.movebrowse = new System.Windows.Forms.Button();
            this.movepath = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // zipLocale
            // 
            this.zipLocale.Location = new System.Drawing.Point(103, 30);
            this.zipLocale.Name = "zipLocale";
            this.zipLocale.ReadOnly = true;
            this.zipLocale.Size = new System.Drawing.Size(217, 20);
            this.zipLocale.TabIndex = 2;
            this.zipLocale.TextChanged += new System.EventHandler(this.zipLocale_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zip File Location:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Folder: ";
            // 
            // browseOutput
            // 
            this.browseOutput.Location = new System.Drawing.Point(326, 66);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(75, 23);
            this.browseOutput.TabIndex = 5;
            this.browseOutput.Text = "Browse...";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.browseOutput_Click);
            // 
            // outputPath
            // 
            this.outputPath.Location = new System.Drawing.Point(103, 68);
            this.outputPath.Name = "outputPath";
            this.outputPath.ReadOnly = true;
            this.outputPath.Size = new System.Drawing.Size(217, 20);
            this.outputPath.TabIndex = 4;
            // 
            // moveRB
            // 
            this.moveRB.AutoSize = true;
            this.moveRB.Checked = true;
            this.moveRB.Location = new System.Drawing.Point(15, 137);
            this.moveRB.Name = "moveRB";
            this.moveRB.Size = new System.Drawing.Size(155, 17);
            this.moveRB.TabIndex = 6;
            this.moveRB.TabStop = true;
            this.moveRB.Text = "Move Files When Complete";
            this.toolTip1.SetToolTip(this.moveRB, "After the files are unzipped, they are moved to the selected destination");
            this.moveRB.UseVisualStyleBackColor = true;
            this.moveRB.CheckedChanged += new System.EventHandler(this.moveRB_CheckedChanged);
            // 
            // renameRB
            // 
            this.renameRB.AutoSize = true;
            this.renameRB.Location = new System.Drawing.Point(15, 160);
            this.renameRB.Name = "renameRB";
            this.renameRB.Size = new System.Drawing.Size(168, 17);
            this.renameRB.TabIndex = 7;
            this.renameRB.Text = "Rename Files When Complete";
            this.toolTip1.SetToolTip(this.renameRB, "When the files are unzipped, they are kept in the same location, but the file ext" +
        "ention will be changed to .unzip");
            this.renameRB.UseVisualStyleBackColor = true;
            this.renameRB.CheckedChanged += new System.EventHandler(this.renameRB_CheckedChanged);
            // 
            // deletRB
            // 
            this.deletRB.AutoSize = true;
            this.deletRB.Location = new System.Drawing.Point(15, 183);
            this.deletRB.Name = "deletRB";
            this.deletRB.Size = new System.Drawing.Size(159, 17);
            this.deletRB.TabIndex = 8;
            this.deletRB.Text = "Delete Files When Complete";
            this.toolTip1.SetToolTip(this.deletRB, "The files will be deleted after unzipping");
            this.deletRB.UseVisualStyleBackColor = true;
            this.deletRB.CheckedChanged += new System.EventHandler(this.deletRB_CheckedChanged);
            // 
            // movebrowse
            // 
            this.movebrowse.Location = new System.Drawing.Point(327, 132);
            this.movebrowse.Name = "movebrowse";
            this.movebrowse.Size = new System.Drawing.Size(75, 23);
            this.movebrowse.TabIndex = 10;
            this.movebrowse.Text = "Browse...";
            this.movebrowse.UseVisualStyleBackColor = true;
            this.movebrowse.Click += new System.EventHandler(this.movebrowse_Click);
            // 
            // movepath
            // 
            this.movepath.Location = new System.Drawing.Point(176, 134);
            this.movepath.Name = "movepath";
            this.movepath.ReadOnly = true;
            this.movepath.Size = new System.Drawing.Size(145, 20);
            this.movepath.TabIndex = 9;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(327, 215);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(244, 215);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 12;
            this.stopBtn.Text = "Stop!";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Visible = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click to reopen";
            this.notifyIcon1.BalloonTipTitle = "Quick Unzip";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(413, 250);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.movebrowse);
            this.Controls.Add(this.movepath);
            this.Controls.Add(this.deletRB);
            this.Controls.Add(this.renameRB);
            this.Controls.Add(this.moveRB);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipLocale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Unzip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zipLocale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.TextBox outputPath;
        private System.Windows.Forms.RadioButton moveRB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton renameRB;
        private System.Windows.Forms.RadioButton deletRB;
        private System.Windows.Forms.Button movebrowse;
        private System.Windows.Forms.TextBox movepath;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

