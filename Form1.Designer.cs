namespace Keithley_2000
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_maine = new System.Windows.Forms.Panel();
            this.comboBox_measure_function = new System.Windows.Forms.ComboBox();
            this.label_measure_functions = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSettingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portSettingsToolStripMenuItem
            // 
            this.portSettingsToolStripMenuItem.Name = "portSettingsToolStripMenuItem";
            this.portSettingsToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.portSettingsToolStripMenuItem.Text = "Port Settings";
            this.portSettingsToolStripMenuItem.Click += new System.EventHandler(this.portSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel_maine
            // 
            this.panel_maine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_maine.Location = new System.Drawing.Point(0, 62);
            this.panel_maine.Name = "panel_maine";
            this.panel_maine.Size = new System.Drawing.Size(1020, 461);
            this.panel_maine.TabIndex = 1;
            // 
            // comboBox_measure_function
            // 
            this.comboBox_measure_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_measure_function.FormattingEnabled = true;
            this.comboBox_measure_function.Items.AddRange(new object[] {
            "Select...",
            "Voltage Measurements",
            "Resistance Measurements",
            "Current Measurements"});
            this.comboBox_measure_function.Location = new System.Drawing.Point(186, 32);
            this.comboBox_measure_function.Name = "comboBox_measure_function";
            this.comboBox_measure_function.Size = new System.Drawing.Size(202, 24);
            this.comboBox_measure_function.TabIndex = 2;
            this.comboBox_measure_function.SelectedIndexChanged += new System.EventHandler(this.comboBox_measure_function_SelectedIndexChanged);
            // 
            // label_measure_functions
            // 
            this.label_measure_functions.AutoSize = true;
            this.label_measure_functions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_measure_functions.Location = new System.Drawing.Point(12, 36);
            this.label_measure_functions.Name = "label_measure_functions";
            this.label_measure_functions.Size = new System.Drawing.Size(168, 17);
            this.label_measure_functions.TabIndex = 3;
            this.label_measure_functions.Text = "Select Measure Function:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 529);
            this.Controls.Add(this.label_measure_functions);
            this.Controls.Add(this.comboBox_measure_function);
            this.Controls.Add(this.panel_maine);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1036, 568);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keithley 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_maine;
        private System.Windows.Forms.ComboBox comboBox_measure_function;
        private System.Windows.Forms.Label label_measure_functions;
    }
}

