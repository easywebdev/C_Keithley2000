namespace Keithley_2000
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_about = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_license = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_web_page = new System.Windows.Forms.LinkLabel();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.groupBox_author = new System.Windows.Forms.GroupBox();
            this.groupBox_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_license.SuspendLayout();
            this.groupBox_author.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(197, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is software is a Keithley 2000 data logger.\r\nThis software communicate with " +
    "device via RS232 interface.";
            // 
            // groupBox_about
            // 
            this.groupBox_about.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_about.Controls.Add(this.linkLabel_web_page);
            this.groupBox_about.Controls.Add(this.pictureBox1);
            this.groupBox_about.Controls.Add(this.label1);
            this.groupBox_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_about.Location = new System.Drawing.Point(4, 4);
            this.groupBox_about.Name = "groupBox_about";
            this.groupBox_about.Size = new System.Drawing.Size(634, 128);
            this.groupBox_about.TabIndex = 1;
            this.groupBox_about.TabStop = false;
            this.groupBox_about.Text = "About:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_license
            // 
            this.groupBox_license.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_license.Controls.Add(this.label2);
            this.groupBox_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_license.Location = new System.Drawing.Point(4, 142);
            this.groupBox_license.Name = "groupBox_license";
            this.groupBox_license.Size = new System.Drawing.Size(634, 65);
            this.groupBox_license.TabIndex = 2;
            this.groupBox_license.TabStop = false;
            this.groupBox_license.Text = "License:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "This is software is a Freeware. You can use it and share it.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shurygin Fedor.\r\nIf You have some propositions or \r\nYou\'d like to support author " +
    "You can do it by link below:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_web_page
            // 
            this.linkLabel_web_page.AutoSize = true;
            this.linkLabel_web_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_web_page.Location = new System.Drawing.Point(200, 80);
            this.linkLabel_web_page.Name = "linkLabel_web_page";
            this.linkLabel_web_page.Size = new System.Drawing.Size(69, 17);
            this.linkLabel_web_page.TabIndex = 2;
            this.linkLabel_web_page.TabStop = true;
            this.linkLabel_web_page.Text = "web page";
            this.linkLabel_web_page.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_web_page_LinkClicked);
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.AutoSize = true;
            this.linkLabel_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_author.Location = new System.Drawing.Point(6, 98);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(145, 17);
            this.linkLabel_author.TabIndex = 1;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Connect to the author";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // groupBox_author
            // 
            this.groupBox_author.Controls.Add(this.label3);
            this.groupBox_author.Controls.Add(this.linkLabel_author);
            this.groupBox_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_author.Location = new System.Drawing.Point(4, 215);
            this.groupBox_author.Name = "groupBox_author";
            this.groupBox_author.Size = new System.Drawing.Size(634, 127);
            this.groupBox_author.TabIndex = 3;
            this.groupBox_author.TabStop = false;
            this.groupBox_author.Text = "Author: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.groupBox_author);
            this.Controls.Add(this.groupBox_license);
            this.Controls.Add(this.groupBox_about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(666, 39);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.groupBox_about.ResumeLayout(false);
            this.groupBox_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_license.ResumeLayout(false);
            this.groupBox_author.ResumeLayout(false);
            this.groupBox_author.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_about;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_license;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_web_page;
        private System.Windows.Forms.LinkLabel linkLabel_author;
        private System.Windows.Forms.GroupBox groupBox_author;
    }
}