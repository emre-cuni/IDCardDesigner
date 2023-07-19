namespace IDCardDesigner
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.linkLabelLinkedin = new System.Windows.Forms.LinkLabel();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.AutoSize = true;
            this.labelSoftwareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoftwareName.Location = new System.Drawing.Point(30, 234);
            this.labelSoftwareName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(52, 18);
            this.labelSoftwareName.TabIndex = 0;
            this.labelSoftwareName.Text = "label1";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDeveloper.Location = new System.Drawing.Point(30, 279);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(52, 18);
            this.labelDeveloper.TabIndex = 2;
            this.labelDeveloper.Text = "label1";
            // 
            // linkLabelLinkedin
            // 
            this.linkLabelLinkedin.AutoSize = true;
            this.linkLabelLinkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelLinkedin.Location = new System.Drawing.Point(30, 321);
            this.linkLabelLinkedin.Name = "linkLabelLinkedin";
            this.linkLabelLinkedin.Size = new System.Drawing.Size(83, 18);
            this.linkLabelLinkedin.TabIndex = 3;
            this.linkLabelLinkedin.TabStop = true;
            this.linkLabelLinkedin.Text = "linkLabel1";
            this.linkLabelLinkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLinkedin_LinkClicked);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelGithub.Location = new System.Drawing.Point(30, 359);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(83, 18);
            this.linkLabelGithub.TabIndex = 4;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "linkLabel1";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.Location = new System.Drawing.Point(30, 400);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 18);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IDCardDesigner.Properties.Resources.IDCardDesigner;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(374, 485);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.linkLabelLinkedin);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSoftwareName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.LinkLabel linkLabelLinkedin;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Label labelDate;
    }
}