namespace IDCardDesigner
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textBoxTitle2 = new System.Windows.Forms.TextBox();
            this.textBoxTitle1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.panelStaffInfo = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelImportantInfo = new System.Windows.Forms.Panel();
            this.labelImportantInfoDetail = new System.Windows.Forms.Label();
            this.labelImportantInfoTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEmblem2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmblem1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmblem3 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.panelStaffInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelImportantInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.textBoxTitle2);
            this.panelTitle.Controls.Add(this.textBoxTitle1);
            this.panelTitle.Controls.Add(this.label3);
            this.panelTitle.Controls.Add(this.pictureBoxEmblem2);
            this.panelTitle.Controls.Add(this.pictureBoxEmblem1);
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTitle.Location = new System.Drawing.Point(7, 7);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(82, 76, 82, 76);
            this.panelTitle.Size = new System.Drawing.Size(677, 129);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // textBoxTitle2
            // 
            this.textBoxTitle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.textBoxTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitle2.Location = new System.Drawing.Point(135, 58);
            this.textBoxTitle2.Name = "textBoxTitle2";
            this.textBoxTitle2.Size = new System.Drawing.Size(422, 19);
            this.textBoxTitle2.TabIndex = 6;
            this.textBoxTitle2.Text = "................................................................................." +
    ".";
            this.textBoxTitle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTitle2.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle2.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // textBoxTitle1
            // 
            this.textBoxTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.textBoxTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitle1.Location = new System.Drawing.Point(154, 20);
            this.textBoxTitle1.Name = "textBoxTitle1";
            this.textBoxTitle1.Size = new System.Drawing.Size(384, 19);
            this.textBoxTitle1.TabIndex = 5;
            this.textBoxTitle1.Text = "...........................................................................";
            this.textBoxTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTitle1.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle1.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(246, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PERSONEL GİRİŞ KARTI";
            // 
            // panelStaff
            // 
            this.panelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.panelStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaff.Controls.Add(this.pictureBoxPhoto);
            this.panelStaff.Controls.Add(this.panelStaffInfo);
            this.panelStaff.Location = new System.Drawing.Point(7, 159);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(677, 241);
            this.panelStaff.TabIndex = 1;
            // 
            // panelStaffInfo
            // 
            this.panelStaffInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaffInfo.Controls.Add(this.pictureBoxEmblem3);
            this.panelStaffInfo.Controls.Add(this.textBox4);
            this.panelStaffInfo.Controls.Add(this.textBox3);
            this.panelStaffInfo.Controls.Add(this.textBox2);
            this.panelStaffInfo.Controls.Add(this.textBox1);
            this.panelStaffInfo.Location = new System.Drawing.Point(11, 14);
            this.panelStaffInfo.Name = "panelStaffInfo";
            this.panelStaffInfo.Size = new System.Drawing.Size(461, 210);
            this.panelStaffInfo.TabIndex = 0;
            this.panelStaffInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStaffInfo_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(301, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(23, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 21);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(23, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(23, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 21);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 437);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelTitle);
            this.tabPage1.Controls.Add(this.panelStaff);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ön Sayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelImportantInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arka Sayfa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelImportantInfo
            // 
            this.panelImportantInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImportantInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelImportantInfo.Controls.Add(this.labelImportantInfoDetail);
            this.panelImportantInfo.Controls.Add(this.labelImportantInfoTitle);
            this.panelImportantInfo.Location = new System.Drawing.Point(6, 6);
            this.panelImportantInfo.Name = "panelImportantInfo";
            this.panelImportantInfo.Size = new System.Drawing.Size(680, 394);
            this.panelImportantInfo.TabIndex = 0;
            this.panelImportantInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImportantInfo_Paint);
            this.panelImportantInfo.DoubleClick += new System.EventHandler(this.panelImportantInfo_DoubleClick);
            // 
            // labelImportantInfoDetail
            // 
            this.labelImportantInfoDetail.AutoSize = true;
            this.labelImportantInfoDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelImportantInfoDetail.Location = new System.Drawing.Point(22, 82);
            this.labelImportantInfoDetail.Name = "labelImportantInfoDetail";
            this.labelImportantInfoDetail.Size = new System.Drawing.Size(52, 18);
            this.labelImportantInfoDetail.TabIndex = 1;
            this.labelImportantInfoDetail.Text = "label5";
            // 
            // labelImportantInfoTitle
            // 
            this.labelImportantInfoTitle.AutoSize = true;
            this.labelImportantInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelImportantInfoTitle.Location = new System.Drawing.Point(20, 19);
            this.labelImportantInfoTitle.Name = "labelImportantInfoTitle";
            this.labelImportantInfoTitle.Size = new System.Drawing.Size(216, 31);
            this.labelImportantInfoTitle.TabIndex = 0;
            this.labelImportantInfoTitle.Text = "ÖNEMLİ BİLGİ:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.printToolStripMenuItem.Text = "Çıktı Al";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxEmblem2
            // 
            this.pictureBoxEmblem2.Location = new System.Drawing.Point(563, 16);
            this.pictureBoxEmblem2.Name = "pictureBoxEmblem2";
            this.pictureBoxEmblem2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEmblem2.TabIndex = 3;
            this.pictureBoxEmblem2.TabStop = false;
            this.pictureBoxEmblem2.DoubleClick += new System.EventHandler(this.pictureBoxEmblem2_DoubleClick);
            // 
            // pictureBoxEmblem1
            // 
            this.pictureBoxEmblem1.Location = new System.Drawing.Point(11, 16);
            this.pictureBoxEmblem1.Name = "pictureBoxEmblem1";
            this.pictureBoxEmblem1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxEmblem1.TabIndex = 2;
            this.pictureBoxEmblem1.TabStop = false;
            this.pictureBoxEmblem1.DoubleClick += new System.EventHandler(this.pictureBoxEmblem1_DoubleClick);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(478, 14);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(185, 210);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPhoto_Paint);
            this.pictureBoxPhoto.DoubleClick += new System.EventHandler(this.pictureBoxPhoto_DoubleClick);
            // 
            // pictureBoxEmblem3
            // 
            this.pictureBoxEmblem3.Location = new System.Drawing.Point(301, 12);
            this.pictureBoxEmblem3.Name = "pictureBoxEmblem3";
            this.pictureBoxEmblem3.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxEmblem3.TabIndex = 4;
            this.pictureBoxEmblem3.TabStop = false;
            this.pictureBoxEmblem3.DoubleClick += new System.EventHandler(this.pictureBoxEmblem3_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ID Card Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaffInfo.ResumeLayout(false);
            this.panelStaffInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelImportantInfo.ResumeLayout(false);
            this.panelImportantInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmblem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxEmblem2;
        private System.Windows.Forms.PictureBox pictureBoxEmblem1;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Panel panelStaffInfo;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBoxEmblem3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelImportantInfo;
        private System.Windows.Forms.Label labelImportantInfoDetail;
        private System.Windows.Forms.Label labelImportantInfoTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxTitle1;
        private System.Windows.Forms.TextBox textBoxTitle2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

