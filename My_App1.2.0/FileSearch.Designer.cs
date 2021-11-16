
namespace My_App1._2._0
{
    partial class FileSearch
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
            this.Search_txtbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Browse_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FilesImported = new System.Windows.Forms.Label();
            this.export_button = new System.Windows.Forms.Button();
            this.FileCount = new System.Windows.Forms.Label();
            this.TotalFiles_textBox = new System.Windows.Forms.TextBox();
            this.FileName_label = new System.Windows.Forms.Label();
            this.FileName_textBox = new System.Windows.Forms.TextBox();
            this.File_Type_comboBox = new System.Windows.Forms.ComboBox();
            this.File_Type_label = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisAppProvidesFilesPresentInAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version120ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_txtbox
            // 
            this.Search_txtbox.Location = new System.Drawing.Point(136, 60);
            this.Search_txtbox.Name = "Search_txtbox";
            this.Search_txtbox.Size = new System.Drawing.Size(594, 26);
            this.Search_txtbox.TabIndex = 1;
            this.Search_txtbox.TextChanged += new System.EventHandler(this.Search_txtbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(759, 56);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(86, 35);
            this.Browse_button.TabIndex = 2;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.FilesImported);
            this.groupBox1.Controls.Add(this.export_button);
            this.groupBox1.Controls.Add(this.FileCount);
            this.groupBox1.Controls.Add(this.TotalFiles_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 435);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files Found in Folder";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(581, 26);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // FilesImported
            // 
            this.FilesImported.AutoSize = true;
            this.FilesImported.Location = new System.Drawing.Point(622, 287);
            this.FilesImported.Name = "FilesImported";
            this.FilesImported.Size = new System.Drawing.Size(0, 23);
            this.FilesImported.TabIndex = 13;
            this.FilesImported.Click += new System.EventHandler(this.FilesImported_Click);
            // 
            // export_button
            // 
            this.export_button.ForeColor = System.Drawing.Color.OrangeRed;
            this.export_button.Location = new System.Drawing.Point(626, 245);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(258, 42);
            this.export_button.TabIndex = 6;
            this.export_button.Text = "Export to log file";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // FileCount
            // 
            this.FileCount.AutoSize = true;
            this.FileCount.Location = new System.Drawing.Point(622, 56);
            this.FileCount.Name = "FileCount";
            this.FileCount.Size = new System.Drawing.Size(0, 23);
            this.FileCount.TabIndex = 11;
            this.FileCount.Click += new System.EventHandler(this.FileCount_Click);
            // 
            // TotalFiles_textBox
            // 
            this.TotalFiles_textBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFiles_textBox.Location = new System.Drawing.Point(10, 72);
            this.TotalFiles_textBox.Multiline = true;
            this.TotalFiles_textBox.Name = "TotalFiles_textBox";
            this.TotalFiles_textBox.ReadOnly = true;
            this.TotalFiles_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TotalFiles_textBox.Size = new System.Drawing.Size(581, 349);
            this.TotalFiles_textBox.TabIndex = 0;
            this.TotalFiles_textBox.TextChanged += new System.EventHandler(this.TotalFiles_textBox_TextChanged);
            // 
            // FileName_label
            // 
            this.FileName_label.AutoSize = true;
            this.FileName_label.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_label.Location = new System.Drawing.Point(12, 114);
            this.FileName_label.Name = "FileName_label";
            this.FileName_label.Size = new System.Drawing.Size(132, 21);
            this.FileName_label.TabIndex = 5;
            this.FileName_label.Text = "Enter File Name";
            this.FileName_label.Click += new System.EventHandler(this.FileName_label_Click);
            // 
            // FileName_textBox
            // 
            this.FileName_textBox.Location = new System.Drawing.Point(154, 112);
            this.FileName_textBox.Name = "FileName_textBox";
            this.FileName_textBox.Size = new System.Drawing.Size(391, 26);
            this.FileName_textBox.TabIndex = 3;
            this.FileName_textBox.TextChanged += new System.EventHandler(this.FileName_textBox_TextChanged);
            // 
            // File_Type_comboBox
            // 
            this.File_Type_comboBox.FormattingEnabled = true;
            this.File_Type_comboBox.Items.AddRange(new object[] {
            "pdf",
            "docx",
            "xlsx"});
            this.File_Type_comboBox.Location = new System.Drawing.Point(628, 110);
            this.File_Type_comboBox.Name = "File_Type_comboBox";
            this.File_Type_comboBox.Size = new System.Drawing.Size(93, 28);
            this.File_Type_comboBox.TabIndex = 4;
            this.File_Type_comboBox.SelectedIndexChanged += new System.EventHandler(this.File_Type_comboBox_SelectedIndexChanged);
            // 
            // File_Type_label
            // 
            this.File_Type_label.AutoSize = true;
            this.File_Type_label.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Type_label.Location = new System.Drawing.Point(576, 114);
            this.File_Type_label.Name = "File_Type_label";
            this.File_Type_label.Size = new System.Drawing.Size(46, 21);
            this.File_Type_label.TabIndex = 8;
            this.File_Type_label.Text = "Type";
            this.File_Type_label.Click += new System.EventHandler(this.File_Type_label_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(759, 107);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(86, 36);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.AutoToolTip = true;
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisAppProvidesFilesPresentInAToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // thisAppProvidesFilesPresentInAToolStripMenuItem
            // 
            this.thisAppProvidesFilesPresentInAToolStripMenuItem.Name = "thisAppProvidesFilesPresentInAToolStripMenuItem";
            this.thisAppProvidesFilesPresentInAToolStripMenuItem.Size = new System.Drawing.Size(498, 34);
            this.thisAppProvidesFilesPresentInAToolStripMenuItem.Text = "This App provides files present in selected folder";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version120ToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.versionToolStripMenuItem.Text = "&Version";
            // 
            // version120ToolStripMenuItem
            // 
            this.version120ToolStripMenuItem.Name = "version120ToolStripMenuItem";
            this.version120ToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.version120ToolStripMenuItem.Text = "Version 1.2.0";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // FileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 603);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.File_Type_label);
            this.Controls.Add(this.File_Type_comboBox);
            this.Controls.Add(this.FileName_textBox);
            this.Controls.Add(this.FileName_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Search_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileSearch";
            this.Text = "FileSearch";
            this.Load += new System.EventHandler(this.FileSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_txtbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotalFiles_textBox;
        private System.Windows.Forms.Label FileName_label;
        private System.Windows.Forms.TextBox FileName_textBox;
        private System.Windows.Forms.ComboBox File_Type_comboBox;
        private System.Windows.Forms.Label File_Type_label;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisAppProvidesFilesPresentInAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version120ToolStripMenuItem;
        private System.Windows.Forms.Label FileCount;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Label FilesImported;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}