namespace FolderAnalizator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TreeFolder = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnScan = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusScan = new System.Windows.Forms.ToolStripStatusLabel();
            this.LstSize = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstType = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeFolder
            // 
            this.TreeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeFolder.ImageIndex = 0;
            this.TreeFolder.ImageList = this.imageList1;
            this.TreeFolder.Location = new System.Drawing.Point(16, 41);
            this.TreeFolder.Name = "TreeFolder";
            this.TreeFolder.SelectedImageIndex = 0;
            this.TreeFolder.Size = new System.Drawing.Size(428, 412);
            this.TreeFolder.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "photosfolderblank_99366.png");
            this.imageList1.Images.SetKeyName(1, "empty_file_icon-icons.com_72420.png");
            // 
            // BtnScan
            // 
            this.BtnScan.BackColor = System.Drawing.Color.Green;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.ForeColor = System.Drawing.Color.White;
            this.BtnScan.Location = new System.Drawing.Point(484, 393);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(172, 60);
            this.BtnScan.TabIndex = 1;
            this.BtnScan.Text = "Сканировать";
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Green;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(731, 393);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(172, 60);
            this.BtnReport.TabIndex = 2;
            this.BtnReport.Text = "Отчет";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusScan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusScan
            // 
            this.StatusScan.Name = "StatusScan";
            this.StatusScan.Size = new System.Drawing.Size(0, 17);
            // 
            // LstSize
            // 
            this.LstSize.FormattingEnabled = true;
            this.LstSize.ItemHeight = 17;
            this.LstSize.Location = new System.Drawing.Point(460, 226);
            this.LstSize.Name = "LstSize";
            this.LstSize.Size = new System.Drawing.Size(466, 157);
            this.LstSize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Средний размер:";
            // 
            // LstType
            // 
            this.LstType.FormattingEnabled = true;
            this.LstType.ItemHeight = 17;
            this.LstType.Location = new System.Drawing.Point(460, 41);
            this.LstType.Name = "LstType";
            this.LstType.Size = new System.Drawing.Size(466, 157);
            this.LstType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список форматов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дерево файлов";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LstType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSize);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnScan);
            this.Controls.Add(this.TreeFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Analizator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeFolder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusScan;
        private System.Windows.Forms.ListBox LstSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

