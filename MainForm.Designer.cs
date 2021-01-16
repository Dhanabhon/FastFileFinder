
namespace FastFileFinder
{
    partial class Form
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
            this.toolStripSalesStock = new System.Windows.Forms.ToolStrip();
            this.toolStripLbAppName = new System.Windows.Forms.ToolStripLabel();
            this.lblImportFffFile = new System.Windows.Forms.Label();
            this.tbxPathFffFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFffFile = new System.Windows.Forms.Button();
            this.dgvFff = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.gbStep3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lnklblAbout = new System.Windows.Forms.LinkLabel();
            this.toolStripSalesStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFff)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gbStep1.SuspendLayout();
            this.gbStep2.SuspendLayout();
            this.gbStep3.SuspendLayout();
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
            this.toolStripSalesStock.Size = new System.Drawing.Size(572, 48);
            this.toolStripSalesStock.TabIndex = 4;
            this.toolStripSalesStock.Text = "toolStrip";
            // 
            // toolStripLbAppName
            // 
            this.toolStripLbAppName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLbAppName.ForeColor = System.Drawing.Color.White;
            this.toolStripLbAppName.Name = "toolStripLbAppName";
            this.toolStripLbAppName.Size = new System.Drawing.Size(155, 45);
            this.toolStripLbAppName.Text = "Fast File Finder";
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
            this.tbxPathFffFile.Size = new System.Drawing.Size(240, 22);
            this.tbxPathFffFile.TabIndex = 6;
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
            this.btnBrowseFffFile.Location = new System.Drawing.Point(170, 72);
            this.btnBrowseFffFile.Name = "btnBrowseFffFile";
            this.btnBrowseFffFile.Size = new System.Drawing.Size(85, 25);
            this.btnBrowseFffFile.TabIndex = 7;
            this.btnBrowseFffFile.Text = "Browse...";
            this.btnBrowseFffFile.UseVisualStyleBackColor = false;
            // 
            // dgvFff
            // 
            this.dgvFff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFff.Location = new System.Drawing.Point(15, 103);
            this.dgvFff.Name = "dgvFff";
            this.dgvFff.Size = new System.Drawing.Size(240, 301);
            this.dgvFff.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel.Text = "Waiting for search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(171, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(16, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblOutput.Location = new System.Drawing.Point(13, 25);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(92, 16);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Copy file path:";
            // 
            // gbStep1
            // 
            this.gbStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbStep1.Controls.Add(this.tbxPathFffFile);
            this.gbStep1.Controls.Add(this.lblImportFffFile);
            this.gbStep1.Controls.Add(this.btnBrowseFffFile);
            this.gbStep1.Controls.Add(this.dgvFff);
            this.gbStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep1.Location = new System.Drawing.Point(12, 62);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Size = new System.Drawing.Size(270, 422);
            this.gbStep1.TabIndex = 13;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 1";
            // 
            // gbStep2
            // 
            this.gbStep2.Controls.Add(this.textBox1);
            this.gbStep2.Controls.Add(this.lblOutput);
            this.gbStep2.Controls.Add(this.button1);
            this.gbStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep2.Location = new System.Drawing.Point(288, 62);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Size = new System.Drawing.Size(272, 108);
            this.gbStep2.TabIndex = 14;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 2";
            // 
            // gbStep3
            // 
            this.gbStep3.Controls.Add(this.btnSearch);
            this.gbStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbStep3.Location = new System.Drawing.Point(288, 176);
            this.gbStep3.Name = "gbStep3";
            this.gbStep3.Size = new System.Drawing.Size(274, 84);
            this.gbStep3.TabIndex = 15;
            this.gbStep3.TabStop = false;
            this.gbStep3.Text = "Step 3";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(92)))), ((int)(((byte)(142)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(59)))), ((int)(((byte)(107)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(16, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(240, 48);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lnklblAbout
            // 
            this.lnklblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblAbout.AutoSize = true;
            this.lnklblAbout.Location = new System.Drawing.Point(525, 471);
            this.lnklblAbout.Name = "lnklblAbout";
            this.lnklblAbout.Size = new System.Drawing.Size(35, 13);
            this.lnklblAbout.TabIndex = 16;
            this.lnklblAbout.TabStop = true;
            this.lnklblAbout.Text = "About";
            this.lnklblAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAbout_LinkClicked);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 522);
            this.Controls.Add(this.lnklblAbout);
            this.Controls.Add(this.gbStep3);
            this.Controls.Add(this.gbStep2);
            this.Controls.Add(this.gbStep1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripSalesStock);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast File Finder  - Developed by Dhanabhon S. [Open Source]";
            this.toolStripSalesStock.ResumeLayout(false);
            this.toolStripSalesStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFff)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbStep1.ResumeLayout(false);
            this.gbStep1.PerformLayout();
            this.gbStep2.ResumeLayout(false);
            this.gbStep2.PerformLayout();
            this.gbStep3.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.GroupBox gbStep3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.LinkLabel lnklblAbout;
    }
}

