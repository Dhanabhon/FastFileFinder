
namespace FastFileFinder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripSalesStock = new System.Windows.Forms.ToolStrip();
            this.toolStripLbAppName = new System.Windows.Forms.ToolStripLabel();
            this.lblImportFffFile = new System.Windows.Forms.Label();
            this.tbxPathFffFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFffFile = new System.Windows.Forms.Button();
            this.dgvFff = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBrowseTargetDirectory = new System.Windows.Forms.Button();
            this.tbxTargetDirectory = new System.Windows.Forms.TextBox();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.lblTotalNumberOfRows = new System.Windows.Forms.Label();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lnklblAbout = new System.Windows.Forms.LinkLabel();
            this.gbStep3 = new System.Windows.Forms.GroupBox();
            this.tbxOutputPath = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnBrowseOutputPath = new System.Windows.Forms.Button();
            this.gbStep4 = new System.Windows.Forms.GroupBox();
            this.toolStripSalesStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFff)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.gbStep1.SuspendLayout();
            this.gbStep2.SuspendLayout();
            this.gbStep3.SuspendLayout();
            this.gbStep4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSalesStock
            // 
            this.toolStripSalesStock.AutoSize = false;
            this.toolStripSalesStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.toolStripSalesStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripSalesStock.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSalesStock.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSalesStock.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripSalesStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLbAppName});
            this.toolStripSalesStock.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripSalesStock.Location = new System.Drawing.Point(0, 0);
            this.toolStripSalesStock.Name = "toolStripSalesStock";
            this.toolStripSalesStock.Size = new System.Drawing.Size(739, 48);
            this.toolStripSalesStock.TabIndex = 4;
            this.toolStripSalesStock.Text = "toolStrip";
            // 
            // toolStripLbAppName
            // 
            this.toolStripLbAppName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLbAppName.ForeColor = System.Drawing.Color.White;
            this.toolStripLbAppName.Image = global::FastFileFinder.Properties.Resources.binoculars;
            this.toolStripLbAppName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLbAppName.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLbAppName.Name = "toolStripLbAppName";
            this.toolStripLbAppName.Size = new System.Drawing.Size(224, 45);
            this.toolStripLbAppName.Text = "Fast File Finder v1.0";
            // 
            // lblImportFffFile
            // 
            this.lblImportFffFile.AutoSize = true;
            this.lblImportFffFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblImportFffFile.Location = new System.Drawing.Point(12, 25);
            this.lblImportFffFile.Name = "lblImportFffFile";
            this.lblImportFffFile.Size = new System.Drawing.Size(150, 16);
            this.lblImportFffFile.TabIndex = 5;
            this.lblImportFffFile.Text = "Import FFF template file:";
            // 
            // tbxPathFffFile
            // 
            this.tbxPathFffFile.BackColor = System.Drawing.Color.White;
            this.tbxPathFffFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxPathFffFile.Location = new System.Drawing.Point(15, 44);
            this.tbxPathFffFile.Name = "tbxPathFffFile";
            this.tbxPathFffFile.ReadOnly = true;
            this.tbxPathFffFile.Size = new System.Drawing.Size(344, 22);
            this.tbxPathFffFile.TabIndex = 6;
            this.tbxPathFffFile.TabStop = false;
            // 
            // btnBrowseFffFile
            // 
            this.btnBrowseFffFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.btnBrowseFffFile.FlatAppearance.BorderSize = 0;
            this.btnBrowseFffFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseFffFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseFffFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFffFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBrowseFffFile.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFffFile.Location = new System.Drawing.Point(274, 72);
            this.btnBrowseFffFile.Name = "btnBrowseFffFile";
            this.btnBrowseFffFile.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseFffFile.TabIndex = 7;
            this.btnBrowseFffFile.Text = "Browse...";
            this.btnBrowseFffFile.UseVisualStyleBackColor = false;
            this.btnBrowseFffFile.Click += new System.EventHandler(this.btnBrowseFffFile_Click);
            // 
            // dgvFff
            // 
            this.dgvFff.AllowUserToAddRows = false;
            this.dgvFff.AllowUserToDeleteRows = false;
            this.dgvFff.AllowUserToResizeColumns = false;
            this.dgvFff.AllowUserToResizeRows = false;
            this.dgvFff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFff.BackgroundColor = System.Drawing.Color.White;
            this.dgvFff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFff.ColumnHeadersVisible = false;
            this.dgvFff.Location = new System.Drawing.Point(15, 103);
            this.dgvFff.MultiSelect = false;
            this.dgvFff.Name = "dgvFff";
            this.dgvFff.ReadOnly = true;
            this.dgvFff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFff.Size = new System.Drawing.Size(344, 295);
            this.dgvFff.TabIndex = 8;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 506);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(739, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel.Text = "Waiting for search";
            // 
            // btnBrowseTargetDirectory
            // 
            this.btnBrowseTargetDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.btnBrowseTargetDirectory.FlatAppearance.BorderSize = 0;
            this.btnBrowseTargetDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseTargetDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseTargetDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBrowseTargetDirectory.ForeColor = System.Drawing.Color.White;
            this.btnBrowseTargetDirectory.Location = new System.Drawing.Point(233, 72);
            this.btnBrowseTargetDirectory.Name = "btnBrowseTargetDirectory";
            this.btnBrowseTargetDirectory.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseTargetDirectory.TabIndex = 12;
            this.btnBrowseTargetDirectory.Text = "Browse...";
            this.btnBrowseTargetDirectory.UseVisualStyleBackColor = false;
            this.btnBrowseTargetDirectory.Click += new System.EventHandler(this.btnBrowseTargetDirectory_Click);
            // 
            // tbxTargetDirectory
            // 
            this.tbxTargetDirectory.BackColor = System.Drawing.Color.White;
            this.tbxTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxTargetDirectory.Location = new System.Drawing.Point(16, 44);
            this.tbxTargetDirectory.Name = "tbxTargetDirectory";
            this.tbxTargetDirectory.ReadOnly = true;
            this.tbxTargetDirectory.Size = new System.Drawing.Size(302, 22);
            this.tbxTargetDirectory.TabIndex = 11;
            this.tbxTargetDirectory.TabStop = false;
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(13, 25);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(106, 16);
            this.lblTargetDirectory.TabIndex = 10;
            this.lblTargetDirectory.Text = "Target directory:";
            // 
            // gbStep1
            // 
            this.gbStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbStep1.Controls.Add(this.lblTotalNumberOfRows);
            this.gbStep1.Controls.Add(this.tbxPathFffFile);
            this.gbStep1.Controls.Add(this.lblImportFffFile);
            this.gbStep1.Controls.Add(this.btnBrowseFffFile);
            this.gbStep1.Controls.Add(this.dgvFff);
            this.gbStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep1.Location = new System.Drawing.Point(12, 62);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Size = new System.Drawing.Size(375, 428);
            this.gbStep1.TabIndex = 13;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 1";
            // 
            // lblTotalNumberOfRows
            // 
            this.lblTotalNumberOfRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalNumberOfRows.AutoSize = true;
            this.lblTotalNumberOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalNumberOfRows.Location = new System.Drawing.Point(12, 403);
            this.lblTotalNumberOfRows.Name = "lblTotalNumberOfRows";
            this.lblTotalNumberOfRows.Size = new System.Drawing.Size(56, 15);
            this.lblTotalNumberOfRows.TabIndex = 9;
            this.lblTotalNumberOfRows.Text = "[Total : 0]";
            // 
            // gbStep2
            // 
            this.gbStep2.Controls.Add(this.tbxTargetDirectory);
            this.gbStep2.Controls.Add(this.lblTargetDirectory);
            this.gbStep2.Controls.Add(this.btnBrowseTargetDirectory);
            this.gbStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep2.Location = new System.Drawing.Point(393, 62);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Size = new System.Drawing.Size(334, 108);
            this.gbStep2.TabIndex = 14;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 2";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(16, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(302, 48);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lnklblAbout
            // 
            this.lnklblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblAbout.AutoSize = true;
            this.lnklblAbout.Location = new System.Drawing.Point(692, 477);
            this.lnklblAbout.Name = "lnklblAbout";
            this.lnklblAbout.Size = new System.Drawing.Size(35, 13);
            this.lnklblAbout.TabIndex = 16;
            this.lnklblAbout.TabStop = true;
            this.lnklblAbout.Text = "About";
            this.lnklblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAbout_LinkClicked);
            // 
            // gbStep3
            // 
            this.gbStep3.Controls.Add(this.tbxOutputPath);
            this.gbStep3.Controls.Add(this.lblOutputPath);
            this.gbStep3.Controls.Add(this.btnBrowseOutputPath);
            this.gbStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep3.Location = new System.Drawing.Point(393, 176);
            this.gbStep3.Name = "gbStep3";
            this.gbStep3.Size = new System.Drawing.Size(334, 108);
            this.gbStep3.TabIndex = 17;
            this.gbStep3.TabStop = false;
            this.gbStep3.Text = "Step 3";
            // 
            // tbxOutputPath
            // 
            this.tbxOutputPath.BackColor = System.Drawing.Color.White;
            this.tbxOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxOutputPath.Location = new System.Drawing.Point(16, 44);
            this.tbxOutputPath.Name = "tbxOutputPath";
            this.tbxOutputPath.ReadOnly = true;
            this.tbxOutputPath.Size = new System.Drawing.Size(302, 22);
            this.tbxOutputPath.TabIndex = 11;
            this.tbxOutputPath.TabStop = false;
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblOutputPath.Location = new System.Drawing.Point(13, 25);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(78, 16);
            this.lblOutputPath.TabIndex = 10;
            this.lblOutputPath.Text = "Output path:";
            // 
            // btnBrowseOutputPath
            // 
            this.btnBrowseOutputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.btnBrowseOutputPath.FlatAppearance.BorderSize = 0;
            this.btnBrowseOutputPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseOutputPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnBrowseOutputPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBrowseOutputPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOutputPath.Location = new System.Drawing.Point(233, 72);
            this.btnBrowseOutputPath.Name = "btnBrowseOutputPath";
            this.btnBrowseOutputPath.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseOutputPath.TabIndex = 12;
            this.btnBrowseOutputPath.Text = "Browse...";
            this.btnBrowseOutputPath.UseVisualStyleBackColor = false;
            this.btnBrowseOutputPath.Click += new System.EventHandler(this.btnBrowseOutputPath_Click);
            // 
            // gbStep4
            // 
            this.gbStep4.Controls.Add(this.btnSearch);
            this.gbStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbStep4.Location = new System.Drawing.Point(393, 290);
            this.gbStep4.Name = "gbStep4";
            this.gbStep4.Size = new System.Drawing.Size(334, 84);
            this.gbStep4.TabIndex = 18;
            this.gbStep4.TabStop = false;
            this.gbStep4.Text = "Step 4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 528);
            this.Controls.Add(this.gbStep4);
            this.Controls.Add(this.gbStep3);
            this.Controls.Add(this.lnklblAbout);
            this.Controls.Add(this.gbStep2);
            this.Controls.Add(this.gbStep1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripSalesStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast File Finder  - Developed by Dhanabhon S. [Open Source]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripSalesStock.ResumeLayout(false);
            this.toolStripSalesStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFff)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbStep1.ResumeLayout(false);
            this.gbStep1.PerformLayout();
            this.gbStep2.ResumeLayout(false);
            this.gbStep2.PerformLayout();
            this.gbStep3.ResumeLayout(false);
            this.gbStep3.PerformLayout();
            this.gbStep4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSalesStock;
        private System.Windows.Forms.ToolStripLabel toolStripLbAppName;
        private System.Windows.Forms.Label lblImportFffFile;
        private System.Windows.Forms.TextBox tbxPathFffFile;
        private System.Windows.Forms.Button btnBrowseFffFile;
        private System.Windows.Forms.DataGridView dgvFff;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnBrowseTargetDirectory;
        private System.Windows.Forms.TextBox tbxTargetDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.LinkLabel lnklblAbout;
        private System.Windows.Forms.GroupBox gbStep3;
        private System.Windows.Forms.TextBox tbxOutputPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnBrowseOutputPath;
        private System.Windows.Forms.GroupBox gbStep4;
        private System.Windows.Forms.Label lblTotalNumberOfRows;
    }
}

