namespace Keithley_2000
{
    partial class p_main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(p_main));
            this.label_tittle = new System.Windows.Forms.Label();
            this.panel_voltage = new System.Windows.Forms.Panel();
            this.pictureBox_voltage = new System.Windows.Forms.PictureBox();
            this.label_voltage = new System.Windows.Forms.Label();
            this.panel_resistance = new System.Windows.Forms.Panel();
            this.label_4w = new System.Windows.Forms.Label();
            this.label_2w = new System.Windows.Forms.Label();
            this.pictureBox_resistance_4W = new System.Windows.Forms.PictureBox();
            this.pictureBox_resistance_2W = new System.Windows.Forms.PictureBox();
            this.label_resistance = new System.Windows.Forms.Label();
            this.panel_current = new System.Windows.Forms.Panel();
            this.pictureBox_current = new System.Windows.Forms.PictureBox();
            this.label_current = new System.Windows.Forms.Label();
            this.panel_voltage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_voltage)).BeginInit();
            this.panel_resistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance_4W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance_2W)).BeginInit();
            this.panel_current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tittle
            // 
            this.label_tittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tittle.Location = new System.Drawing.Point(0, 0);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(1020, 23);
            this.label_tittle.TabIndex = 0;
            this.label_tittle.Text = "Measure Function";
            this.label_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_voltage
            // 
            this.panel_voltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_voltage.Controls.Add(this.pictureBox_voltage);
            this.panel_voltage.Controls.Add(this.label_voltage);
            this.panel_voltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_voltage.Location = new System.Drawing.Point(12, 26);
            this.panel_voltage.Name = "panel_voltage";
            this.panel_voltage.Size = new System.Drawing.Size(320, 432);
            this.panel_voltage.TabIndex = 1;
            this.panel_voltage.Click += new System.EventHandler(this.panel_voltage_Click);
            // 
            // pictureBox_voltage
            // 
            this.pictureBox_voltage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_voltage.Image")));
            this.pictureBox_voltage.Location = new System.Drawing.Point(7, 59);
            this.pictureBox_voltage.Name = "pictureBox_voltage";
            this.pictureBox_voltage.Size = new System.Drawing.Size(299, 148);
            this.pictureBox_voltage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_voltage.TabIndex = 1;
            this.pictureBox_voltage.TabStop = false;
            this.pictureBox_voltage.Click += new System.EventHandler(this.pictureBox_voltage_Click);
            // 
            // label_voltage
            // 
            this.label_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_voltage.Location = new System.Drawing.Point(3, 5);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(312, 27);
            this.label_voltage.TabIndex = 0;
            this.label_voltage.Text = "Voltage Measurements";
            this.label_voltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_voltage.Click += new System.EventHandler(this.label_voltage_Click);
            // 
            // panel_resistance
            // 
            this.panel_resistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_resistance.Controls.Add(this.label_4w);
            this.panel_resistance.Controls.Add(this.label_2w);
            this.panel_resistance.Controls.Add(this.pictureBox_resistance_4W);
            this.panel_resistance.Controls.Add(this.pictureBox_resistance_2W);
            this.panel_resistance.Controls.Add(this.label_resistance);
            this.panel_resistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_resistance.Location = new System.Drawing.Point(348, 26);
            this.panel_resistance.Name = "panel_resistance";
            this.panel_resistance.Size = new System.Drawing.Size(320, 432);
            this.panel_resistance.TabIndex = 2;
            this.panel_resistance.Click += new System.EventHandler(this.panel_resistance_Click);
            // 
            // label_4w
            // 
            this.label_4w.AutoSize = true;
            this.label_4w.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_4w.Location = new System.Drawing.Point(6, 230);
            this.label_4w.Name = "label_4w";
            this.label_4w.Size = new System.Drawing.Size(57, 17);
            this.label_4w.TabIndex = 5;
            this.label_4w.Text = "4-Wires";
            this.label_4w.Click += new System.EventHandler(this.label_4w_Click);
            // 
            // label_2w
            // 
            this.label_2w.AutoSize = true;
            this.label_2w.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_2w.Location = new System.Drawing.Point(6, 36);
            this.label_2w.Name = "label_2w";
            this.label_2w.Size = new System.Drawing.Size(57, 17);
            this.label_2w.TabIndex = 4;
            this.label_2w.Text = "2-Wires";
            this.label_2w.Click += new System.EventHandler(this.label_2w_Click);
            // 
            // pictureBox_resistance_4W
            // 
            this.pictureBox_resistance_4W.Image = global::Keithley_2000.Properties.Resources.resistance_4W;
            this.pictureBox_resistance_4W.Location = new System.Drawing.Point(9, 250);
            this.pictureBox_resistance_4W.Name = "pictureBox_resistance_4W";
            this.pictureBox_resistance_4W.Size = new System.Drawing.Size(298, 148);
            this.pictureBox_resistance_4W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_resistance_4W.TabIndex = 3;
            this.pictureBox_resistance_4W.TabStop = false;
            this.pictureBox_resistance_4W.Click += new System.EventHandler(this.pictureBox_resistance_4W_Click);
            // 
            // pictureBox_resistance_2W
            // 
            this.pictureBox_resistance_2W.Image = global::Keithley_2000.Properties.Resources.resistance_2W;
            this.pictureBox_resistance_2W.Location = new System.Drawing.Point(9, 59);
            this.pictureBox_resistance_2W.Name = "pictureBox_resistance_2W";
            this.pictureBox_resistance_2W.Size = new System.Drawing.Size(298, 148);
            this.pictureBox_resistance_2W.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_resistance_2W.TabIndex = 2;
            this.pictureBox_resistance_2W.TabStop = false;
            this.pictureBox_resistance_2W.Click += new System.EventHandler(this.pictureBox_resistance_2W_Click);
            // 
            // label_resistance
            // 
            this.label_resistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_resistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_resistance.Location = new System.Drawing.Point(3, 5);
            this.label_resistance.Name = "label_resistance";
            this.label_resistance.Size = new System.Drawing.Size(312, 27);
            this.label_resistance.TabIndex = 1;
            this.label_resistance.Text = "Resistance Measurements";
            this.label_resistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_resistance.Click += new System.EventHandler(this.label_resistance_Click);
            // 
            // panel_current
            // 
            this.panel_current.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_current.Controls.Add(this.pictureBox_current);
            this.panel_current.Controls.Add(this.label_current);
            this.panel_current.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_current.Location = new System.Drawing.Point(687, 26);
            this.panel_current.Name = "panel_current";
            this.panel_current.Size = new System.Drawing.Size(320, 432);
            this.panel_current.TabIndex = 3;
            this.panel_current.Click += new System.EventHandler(this.panel_current_Click);
            // 
            // pictureBox_current
            // 
            this.pictureBox_current.Image = global::Keithley_2000.Properties.Resources.current;
            this.pictureBox_current.Location = new System.Drawing.Point(7, 59);
            this.pictureBox_current.Name = "pictureBox_current";
            this.pictureBox_current.Size = new System.Drawing.Size(301, 148);
            this.pictureBox_current.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_current.TabIndex = 4;
            this.pictureBox_current.TabStop = false;
            this.pictureBox_current.Click += new System.EventHandler(this.pictureBox_current_Click);
            // 
            // label_current
            // 
            this.label_current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_current.Location = new System.Drawing.Point(3, 5);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(312, 27);
            this.label_current.TabIndex = 1;
            this.label_current.Text = "Current Measurements";
            this.label_current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_current.Click += new System.EventHandler(this.label_current_Click);
            // 
            // p_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_current);
            this.Controls.Add(this.panel_resistance);
            this.Controls.Add(this.panel_voltage);
            this.Controls.Add(this.label_tittle);
            this.MinimumSize = new System.Drawing.Size(0, 461);
            this.Name = "p_main";
            this.Size = new System.Drawing.Size(1020, 461);
            this.Load += new System.EventHandler(this.p_main_Load);
            this.panel_voltage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_voltage)).EndInit();
            this.panel_resistance.ResumeLayout(false);
            this.panel_resistance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance_4W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance_2W)).EndInit();
            this.panel_current.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_current)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.Panel panel_voltage;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.Panel panel_resistance;
        private System.Windows.Forms.Panel panel_current;
        private System.Windows.Forms.Label label_resistance;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.PictureBox pictureBox_voltage;
        private System.Windows.Forms.PictureBox pictureBox_resistance_2W;
        private System.Windows.Forms.PictureBox pictureBox_resistance_4W;
        private System.Windows.Forms.PictureBox pictureBox_current;
        private System.Windows.Forms.Label label_4w;
        private System.Windows.Forms.Label label_2w;
    }
}
