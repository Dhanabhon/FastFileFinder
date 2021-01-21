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
#endregion Import

namespace FastFileFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            this.tbxPathFffFile.Text = projectDirectory + @"\Template\FFF_Template.csv";

            this.dgvFff.DataSource = this.ReadCsv(this.tbxPathFffFile.Text);

            this.tbxTargetDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.tbxOutputPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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
                        this.dgvFff.DataSource = ReadCsv(ofd.FileName);
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
                    this.SearchFile(this.dgvFff.Rows[this.dgvFff.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                    Console.WriteLine("TEST: " + this.dgvFff.Rows[this.dgvFff.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    this.SetStatus("Waiting for search");
                    this.btnSearch.Text = "SEARCH";
                    this.btnSearch.BackColor = Color.FromArgb(222, 92, 142);
                    this.EnabledControls(true);
                }
            }

            //this.dgvFff.CurrentCell = this.dgvFff.Rows[i++].Cells[0];
        }
        #endregion Events

        #region Methods
        private DataTable ReadCsv(string filePath)
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
            return dt;
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

        private void SearchFile(string fileName)
        {
            string partialName = fileName;
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(this.tbxTargetDirectory.Text);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

            foreach (FileInfo foundFile in filesInDir)
            {
                //Console.WriteLine(foundFile.Name);
                //Console.WriteLine(foundFile.FullName);

                this.CopyFile(foundFile.FullName, this.tbxOutputPath.Text + @"\" + foundFile.Name);
            }
            MessageBox.Show("Completed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btnSearch.PerformClick();
        }

        private void CopyFile(string sourceFileName, string destFileName)
        {
            try
            {
                File.Copy(sourceFileName, destFileName, true);
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
        #endregion Methods
    } // class
} // namespace
