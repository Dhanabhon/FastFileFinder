using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Import
using System.IO;
using System.Threading;
using FastFileFinder.Properties;
#endregion Import

namespace FastFileFinder
{
    public partial class MainForm : Form
    {
        #region Variables
        private Thread threadSearch = null;

        private int nextRowCounter = 0;
        private int numberOfRows = 0;
        private bool isRunning = false;

        private delegate void SetHighlightRowCallback(int index);

        private readonly Settings settings = new Settings();
        #endregion Variables

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.settings.Reload();

            if (this.settings.FFFPath == string.Empty)
                this.tbxPathFffFile.Text = Application.StartupPath + @"\Template\FFF_Template.csv";
            else
                this.tbxPathFffFile.Text = this.settings.FFFPath;

            if (this.settings.OutputPath == string.Empty)
                this.tbxOutputPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                this.tbxOutputPath.Text = this.settings.OutputPath;

            if (this.settings.TargetDirectory == string.Empty)
                this.tbxTargetDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                this.tbxTargetDirectory.Text = this.settings.TargetDirectory;

            this.dgvFff.DataSource = this.ReadCsv(this.tbxPathFffFile.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveSettings();
        }

        private void lnklblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }

        private void btnBrowseFffFile_Click(object sender, EventArgs e)
        {
            try
            {
                //Open file dialog, allows you to select a csv file
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.dgvFff.DataSource = this.ReadCsv(ofd.FileName);
                        this.SaveSettings();
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseTargetDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    this.tbxTargetDirectory.Text = fbd.SelectedPath;
                    this.SaveSettings();
                }
            }
        }

        private void btnBrowseOutputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    this.tbxOutputPath.Text = fbd.SelectedPath;
                    this.SaveSettings();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.tbxPathFffFile.Text == string.Empty)
                MessageBox.Show("Please import Fast File Finder template file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.tbxTargetDirectory.Text == string.Empty)
                MessageBox.Show("Target directory path is not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.tbxOutputPath.Text == string.Empty)
                MessageBox.Show("Output path is not specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (this.btnSearch.Text == "SEARCH")
                {
                    this.SetStatus("Searching...");
                    this.btnSearch.Text = "STOP SEARCHING";
                    this.btnSearch.BackColor = Color.Red;
                    this.EnabledControls(false);

                    this.threadSearch = new Thread(this.Process)
                    {
                        IsBackground = true
                    };
                    this.isRunning = true;

                    if (!this.threadSearch.IsAlive)
                        this.threadSearch.Start();
                }
                else
                {
                    this.SetStatus("Waiting for search");
                    this.btnSearch.Text = "SEARCH";
                    this.btnSearch.BackColor = Color.FromArgb(222, 92, 142);
                    this.EnabledControls(true);

                    this.isRunning = false;
                }
            }
        }
        #endregion Events

        #region Methods

        private void SaveSettings()
        {
            this.settings.FFFPath = this.tbxPathFffFile.Text;
            this.settings.TargetDirectory = this.tbxTargetDirectory.Text;
            this.settings.OutputPath = this.tbxOutputPath.Text;
            this.settings.Save();
        }

        private DataTable ReadCsv(string filePath)
        {
            try
            {
                var dt = new DataTable();
                // Creating the columns
                File.ReadLines(filePath).Take(1)
                    .SelectMany(x => x.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
                    .ToList()
                    .ForEach(x => dt.Columns.Add(x.Trim()));

                // Adding the rows
                File.ReadLines(filePath).Skip(1)
                    .Select(x => x.Split('\n'))
                    .ToList()
                    .ForEach(line => dt.Rows.Add(line));

                this.lblTotalNumberOfRows.Text = "[Total: " + dt.Rows.Count.ToString() + " ]";
                this.numberOfRows = dt.Rows.Count;
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FFF Template file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void SetStatus(string message)
        {
            this.toolStripStatusLabel.Text = message;
        }

        private void EnabledControls(bool state)
        {
            this.btnBrowseFffFile.Enabled = state;
            this.btnBrowseOutputPath.Enabled = state;
            this.btnBrowseTargetDirectory.Enabled = state;
        }

        private bool CopyFile(string sourceFileName, string destFileName)
        {
            bool error;
            try
            {
                File.Copy(sourceFileName, destFileName, true);
                error = false;
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                MessageBox.Show(dirNotFound.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            return error;
        }

        private void SetHighlighRow(int index)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.dgvFff.InvokeRequired)
            {
                SetHighlightRowCallback d = new SetHighlightRowCallback(SetHighlighRow);
                this.Invoke(d, new object[] { index });
            }
            else
            {
                this.dgvFff.CurrentCell = this.dgvFff.Rows[index].Cells[0];
            }
        }

        // Searching Ref: https://stackoverflow.com/questions/29693603/how-to-find-folders-and-files-by-its-partial-name-c-sharp
        private void Process()
        {
            while(this.isRunning)
            {
                if (this.nextRowCounter == this.numberOfRows)
                {
                    this.nextRowCounter = 0;
                    

                    MessageBox.Show("Completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.PressSearchButton();
                }

                string partialName = this.dgvFff.Rows[this.nextRowCounter].Cells[0].Value.ToString();

                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(this.tbxTargetDirectory.Text);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*");

                foreach (FileInfo foundFile in filesInDir)
                {
                    if (this.CopyFile(foundFile.FullName, this.tbxOutputPath.Text + @"\" + foundFile.Name))
                    {
                        this.PressSearchButton();
                        return;
                    }
                }

                this.SetHighlighRow(nextRowCounter);
                this.nextRowCounter++;
            }
        }

        private void PressSearchButton()
        {
            if (this.InvokeRequired)
            {

                Action action = this.PressSearchButton;
                this.Invoke(action);
            }
            else
            {

                this.btnSearch.PerformClick();
            }

        }
        #endregion Methods

    } // class
} // namespace
