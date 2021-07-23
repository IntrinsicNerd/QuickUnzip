using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassUnzip
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofile = new OpenFileDialog();
        SaveFileDialog sfile = new SaveFileDialog();
        public enum postUnzip {Move, Rename, Delete};
        postUnzip punzip;
        public static string mPath;
        

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            zipLocale.Text = Properties.Settings.Default.ZipDestination;
            outputPath.Text = Properties.Settings.Default.Output;
            movepath.Text = Properties.Settings.Default.Filemovelocation;
            }
            catch
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                zipLocale.Text = browse.SelectedPath;
            }
        }

        private void browseOutput_Click(object sender, EventArgs e)
        {
            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputPath.Text = browse.SelectedPath;
            }
        }

        private void moveRB_CheckedChanged(object sender, EventArgs e)
        {
            //moveRB.Checked = true;
           // renameRB.Checked = false;
            //deletRB.Checked = false;
            movepath.Visible = true;
            movebrowse.Visible = true;
            punzip = postUnzip.Move;
            
        }

        private void renameRB_CheckedChanged(object sender, EventArgs e)
        {
            //moveRB.Checked = false;
            //renameRB.Checked = true;
            //deletRB.Checked = false;
            movepath.Visible = false;
            movebrowse.Visible = false;
            punzip = postUnzip.Rename;
        }

        private void deletRB_CheckedChanged(object sender, EventArgs e)
        {
            //moveRB.Checked = false;
            //renameRB.Checked = false;
            //deletRB.Checked = true;
            movepath.Visible = false;
            movebrowse.Visible = false;
            punzip = postUnzip.Delete;
        }

        private void movebrowse_Click(object sender, EventArgs e)
        {
            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                movepath.Text = browse.SelectedPath;
                toolTip1.SetToolTip(moveRB, "After the files are unzipped, they are moved to " + browse.SelectedPath);
            }
           
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(punzip == postUnzip.Move && (movebrowse.Text == ""))
            {
                MessageBox.Show("Please select a path");
            }
            else if (punzip == postUnzip.Move && !(movebrowse.Text == ""))
            {
                mPath = movepath.Text;
            }

            startBtn.Visible = false;
            stopBtn.Visible = true;
                UnzipFunctions.initialscan(zipLocale.Text, outputPath.Text, punzip);
                fileSystemWatcher1.Path = zipLocale.Text;
                fileSystemWatcher1.Filter = "*.zip";
            fileSystemWatcher1.EnableRaisingEvents = true;

            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Properties.Settings.Default.ZipDestination = zipLocale.Text;
                Properties.Settings.Default.Output = outputPath.Text;
                Properties.Settings.Default.Filemovelocation = movepath.Text;
                Properties.Settings.Default.Save();

            }
            catch
            {

            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
           
                UnzipFunctions.unzipFile(e.FullPath, outputPath.Text, System.IO.Path.GetFileNameWithoutExtension(e.FullPath), punzip);
            
        }

        private void zipLocale_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Visible = false;

            startBtn.Visible = true;
            fileSystemWatcher1.EnableRaisingEvents = false;
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            
                UnzipFunctions.unzipFile(e.FullPath, outputPath.Text, System.IO.Path.GetFileNameWithoutExtension(e.FullPath), punzip);
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
    }
}
