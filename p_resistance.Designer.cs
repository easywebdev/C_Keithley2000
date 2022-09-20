namespace Keithley_2000
{
    partial class p_resistance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_tittle = new System.Windows.Forms.Label();
            this.groupBox_file = new System.Windows.Forms.GroupBox();
            this.checkBox_file = new System.Windows.Forms.CheckBox();
            this.panel_file = new System.Windows.Forms.Panel();
            this.label_file = new System.Windows.Forms.Label();
            this.label_counts = new System.Windows.Forms.Label();
            this.label_rezult = new System.Windows.Forms.Label();
            this.contextMenuStrip_Rez = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save_data = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip_Chart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.label_log = new System.Windows.Forms.Label();
            this.groupBox_chart_settings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_chart_points_dell = new System.Windows.Forms.TextBox();
            this.textBox_chart_points = new System.Windows.Forms.TextBox();
            this.label_chart_points_scale = new System.Windows.Forms.Label();
            this.checkBox_chart = new System.Windows.Forms.CheckBox();
            this.groupBox_ohmmeter_settings = new System.Windows.Forms.GroupBox();
            this.label_delay_comment = new System.Windows.Forms.Label();
            this.label_delay = new System.Windows.Forms.Label();
            this.textBox_delay = new System.Windows.Forms.TextBox();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.comboBox_range = new System.Windows.Forms.ComboBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_filter = new System.Windows.Forms.Label();
            this.label_units = new System.Windows.Forms.Label();
            this.label_range = new System.Windows.Forms.Label();
            this.groupBox_measure_settings = new System.Windows.Forms.GroupBox();
            this.textBox_timeout = new System.Windows.Forms.TextBox();
            this.textBox_round = new System.Windows.Forms.TextBox();
            this.textBox_s_counts = new System.Windows.Forms.TextBox();
            this.textBox_m_counts = new System.Windows.Forms.TextBox();
            this.label_timeout = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.label_s_counts = new System.Windows.Forms.Label();
            this.label_m_counts = new System.Windows.Forms.Label();
            this.pictureBox_resistance = new System.Windows.Forms.PictureBox();
            this.label_method = new System.Windows.Forms.Label();
            this.comboBox_method = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.button_copy = new System.Windows.Forms.Button();
            this.groupBox_oneshot = new System.Windows.Forms.GroupBox();
            this.button_oneshot_copy = new System.Windows.Forms.Button();
            this.button_oneshot_clear = new System.Windows.Forms.Button();
            this.button_oneshot = new System.Windows.Forms.Button();
            this.label_oneshot = new System.Windows.Forms.Label();
            this.groupBox_file.SuspendLayout();
            this.panel_file.SuspendLayout();
            this.contextMenuStrip_Rez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip_Chart.SuspendLayout();
            this.groupBox_chart_settings.SuspendLayout();
            this.groupBox_ohmmeter_settings.SuspendLayout();
            this.groupBox_measure_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance)).BeginInit();
            this.panel_settings.SuspendLayout();
            this.groupBox_oneshot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_tittle
            // 
            this.label_tittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tittle.Location = new System.Drawing.Point(0, 2);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(1020, 23);
            this.label_tittle.TabIndex = 1;
            this.label_tittle.Text = "Resistance Measure";
            this.label_tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_file
            // 
            this.groupBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_file.Controls.Add(this.checkBox_file);
            this.groupBox_file.Controls.Add(this.panel_file);
            this.groupBox_file.Location = new System.Drawing.Point(306, 359);
            this.groupBox_file.Name = "groupBox_file";
            this.groupBox_file.Size = new System.Drawing.Size(711, 85);
            this.groupBox_file.TabIndex = 38;
            this.groupBox_file.TabStop = false;
            this.groupBox_file.Text = "Save Log:";
            // 
            // checkBox_file
            // 
            this.checkBox_file.AutoSize = true;
            this.checkBox_file.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_file.Location = new System.Drawing.Point(8, 21);
            this.checkBox_file.Name = "checkBox_file";
            this.checkBox_file.Size = new System.Drawing.Size(45, 17);
            this.checkBox_file.TabIndex = 1;
            this.checkBox_file.Text = "File:";
            this.checkBox_file.UseVisualStyleBackColor = true;
            this.checkBox_file.CheckedChanged += new System.EventHandler(this.checkBox_file_CheckedChanged);
            // 
            // panel_file
            // 
            this.panel_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_file.AutoScroll = true;
            this.panel_file.Controls.Add(this.label_file);
            this.panel_file.Location = new System.Drawing.Point(3, 44);
            this.panel_file.Name = "panel_file";
            this.panel_file.Size = new System.Drawing.Size(702, 38);
            this.panel_file.TabIndex = 0;
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Location = new System.Drawing.Point(4, 5);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(55, 13);
            this.label_file.TabIndex = 0;
            this.label_file.Text = "File name:";
            // 
            // label_counts
            // 
            this.label_counts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_counts.Location = new System.Drawing.Point(695, 71);
            this.label_counts.Name = "label_counts";
            this.label_counts.Size = new System.Drawing.Size(322, 26);
            this.label_counts.TabIndex = 37;
            this.label_counts.Text = "Count / Counts";
            this.label_counts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_rezult
            // 
            this.label_rezult.AutoSize = true;
            this.label_rezult.ContextMenuStrip = this.contextMenuStrip_Rez;
            this.label_rezult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rezult.Location = new System.Drawing.Point(309, 71);
            this.label_rezult.Name = "label_rezult";
            this.label_rezult.Size = new System.Drawing.Size(74, 26);
            this.label_rezult.TabIndex = 36;
            this.label_rezult.Text = "Result";
            // 
            // contextMenuStrip_Rez
            // 
            this.contextMenuStrip_Rez.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip_Rez.Name = "contextMenuStrip_Rez";
            this.contextMenuStrip_Rez.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Keithley_2000.Properties.Resources.edit_copy_16x16;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // button_save_data
            // 
            this.button_save_data.Image = global::Keithley_2000.Properties.Resources.save_16x16;
            this.button_save_data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save_data.Location = new System.Drawing.Point(569, 36);
            this.button_save_data.Name = "button_save_data";
            this.button_save_data.Size = new System.Drawing.Size(84, 23);
            this.button_save_data.TabIndex = 35;
            this.button_save_data.Text = "Save Data";
            this.button_save_data.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save_data.UseVisualStyleBackColor = true;
            this.button_save_data.Click += new System.EventHandler(this.button_save_data_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Image = global::Keithley_2000.Properties.Resources.calculator_16x16;
            this.button_calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_calculate.Location = new System.Drawing.Point(486, 36);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(77, 23);
            this.button_calculate.TabIndex = 34;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_stop
            // 
            this.button_stop.Image = global::Keithley_2000.Properties.Resources.player_stop_16x16;
            this.button_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stop.Location = new System.Drawing.Point(383, 36);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(61, 23);
            this.button_stop.TabIndex = 33;
            this.button_stop.Text = "STOP";
            this.button_stop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Image = global::Keithley_2000.Properties.Resources.player_play_16x16;
            this.button_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_start.Location = new System.Drawing.Point(311, 36);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(68, 23);
            this.button_start.TabIndex = 32;
            this.button_start.Text = "START";
            this.button_start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Title = "Points";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ContextMenuStrip = this.contextMenuStrip_Chart;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(309, 106);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Color = System.Drawing.Color.Black;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(708, 247);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip_Chart
            // 
            this.contextMenuStrip_Chart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.copyToolStripMenuItem1});
            this.contextMenuStrip_Chart.Name = "contextMenuStrip_Chart";
            this.contextMenuStrip_Chart.Size = new System.Drawing.Size(103, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::Keithley_2000.Properties.Resources.clear_16x16;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = global::Keithley_2000.Properties.Resources.copy_document_16x16;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(4, 419);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(299, 23);
            this.button_save_settings.TabIndex = 30;
            this.button_save_settings.Text = "SAVE SETTINGS";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // label_log
            // 
            this.label_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(5, 444);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(28, 13);
            this.label_log.TabIndex = 29;
            this.label_log.Text = "Log:";
            // 
            // groupBox_chart_settings
            // 
            this.groupBox_chart_settings.Controls.Add(this.label1);
            this.groupBox_chart_settings.Controls.Add(this.textBox_chart_points_dell);
            this.groupBox_chart_settings.Controls.Add(this.textBox_chart_points);
            this.groupBox_chart_settings.Controls.Add(this.label_chart_points_scale);
            this.groupBox_chart_settings.Controls.Add(this.checkBox_chart);
            this.groupBox_chart_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_chart_settings.Location = new System.Drawing.Point(3, 185);
            this.groupBox_chart_settings.Name = "groupBox_chart_settings";
            this.groupBox_chart_settings.Size = new System.Drawing.Size(293, 47);
            this.groupBox_chart_settings.TabIndex = 27;
            this.groupBox_chart_settings.TabStop = false;
            this.groupBox_chart_settings.Text = "Chart Settings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Del Points:";
            // 
            // textBox_chart_points_dell
            // 
            this.textBox_chart_points_dell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_chart_points_dell.Location = new System.Drawing.Point(248, 19);
            this.textBox_chart_points_dell.Name = "textBox_chart_points_dell";
            this.textBox_chart_points_dell.Size = new System.Drawing.Size(41, 20);
            this.textBox_chart_points_dell.TabIndex = 4;
            // 
            // textBox_chart_points
            // 
            this.textBox_chart_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_chart_points.Location = new System.Drawing.Point(131, 19);
            this.textBox_chart_points.Name = "textBox_chart_points";
            this.textBox_chart_points.Size = new System.Drawing.Size(41, 20);
            this.textBox_chart_points.TabIndex = 2;
            this.textBox_chart_points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_chart_points_KeyPress);
            // 
            // label_chart_points_scale
            // 
            this.label_chart_points_scale.AutoSize = true;
            this.label_chart_points_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_chart_points_scale.Location = new System.Drawing.Point(60, 23);
            this.label_chart_points_scale.Name = "label_chart_points_scale";
            this.label_chart_points_scale.Size = new System.Drawing.Size(69, 13);
            this.label_chart_points_scale.TabIndex = 1;
            this.label_chart_points_scale.Text = "Scale Points:";
            // 
            // checkBox_chart
            // 
            this.checkBox_chart.AutoSize = true;
            this.checkBox_chart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_chart.Location = new System.Drawing.Point(0, 21);
            this.checkBox_chart.Name = "checkBox_chart";
            this.checkBox_chart.Size = new System.Drawing.Size(54, 17);
            this.checkBox_chart.TabIndex = 0;
            this.checkBox_chart.Text = "Chart:";
            this.checkBox_chart.UseVisualStyleBackColor = true;
            this.checkBox_chart.CheckedChanged += new System.EventHandler(this.checkBox_chart_CheckedChanged);
            // 
            // groupBox_ohmmeter_settings
            // 
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_delay_comment);
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_delay);
            this.groupBox_ohmmeter_settings.Controls.Add(this.textBox_delay);
            this.groupBox_ohmmeter_settings.Controls.Add(this.comboBox_rate);
            this.groupBox_ohmmeter_settings.Controls.Add(this.comboBox_filter);
            this.groupBox_ohmmeter_settings.Controls.Add(this.comboBox_units);
            this.groupBox_ohmmeter_settings.Controls.Add(this.comboBox_range);
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_rate);
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_filter);
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_units);
            this.groupBox_ohmmeter_settings.Controls.Add(this.label_range);
            this.groupBox_ohmmeter_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_ohmmeter_settings.Location = new System.Drawing.Point(3, 77);
            this.groupBox_ohmmeter_settings.Name = "groupBox_ohmmeter_settings";
            this.groupBox_ohmmeter_settings.Size = new System.Drawing.Size(293, 107);
            this.groupBox_ohmmeter_settings.TabIndex = 26;
            this.groupBox_ohmmeter_settings.TabStop = false;
            this.groupBox_ohmmeter_settings.Text = "Ohmmeter settings:";
            // 
            // label_delay_comment
            // 
            this.label_delay_comment.AutoSize = true;
            this.label_delay_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_delay_comment.Location = new System.Drawing.Point(131, 69);
            this.label_delay_comment.Name = "label_delay_comment";
            this.label_delay_comment.Size = new System.Drawing.Size(92, 26);
            this.label_delay_comment.TabIndex = 14;
            this.label_delay_comment.Text = "commands delay, \r\nerror 363 missing";
            // 
            // label_delay
            // 
            this.label_delay.AutoSize = true;
            this.label_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_delay.Location = new System.Drawing.Point(5, 75);
            this.label_delay.Name = "label_delay";
            this.label_delay.Size = new System.Drawing.Size(37, 13);
            this.label_delay.TabIndex = 13;
            this.label_delay.Text = "Delay:";
            // 
            // textBox_delay
            // 
            this.textBox_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_delay.Location = new System.Drawing.Point(49, 72);
            this.textBox_delay.Name = "textBox_delay";
            this.textBox_delay.Size = new System.Drawing.Size(75, 20);
            this.textBox_delay.TabIndex = 12;
            this.textBox_delay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_delay_KeyPress);
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Items.AddRange(new object[] {
            "fast",
            "medium",
            "slow"});
            this.comboBox_rate.Location = new System.Drawing.Point(213, 44);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(75, 21);
            this.comboBox_rate.TabIndex = 8;
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboBox_filter.Location = new System.Drawing.Point(48, 44);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(75, 21);
            this.comboBox_filter.TabIndex = 7;
            // 
            // comboBox_units
            // 
            this.comboBox_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Items.AddRange(new object[] {
            "MΩ",
            "kΩ",
            "Ω"});
            this.comboBox_units.Location = new System.Drawing.Point(213, 19);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(75, 21);
            this.comboBox_units.TabIndex = 6;
            // 
            // comboBox_range
            // 
            this.comboBox_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_range.FormattingEnabled = true;
            this.comboBox_range.Items.AddRange(new object[] {
            "Auto",
            "100M",
            "10M",
            "1M",
            "100K",
            "10K",
            "1K",
            "100"});
            this.comboBox_range.Location = new System.Drawing.Point(48, 19);
            this.comboBox_range.Name = "comboBox_range";
            this.comboBox_range.Size = new System.Drawing.Size(75, 21);
            this.comboBox_range.TabIndex = 5;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rate.Location = new System.Drawing.Point(177, 48);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(33, 13);
            this.label_rate.TabIndex = 4;
            this.label_rate.Text = "Rate:";
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_filter.Location = new System.Drawing.Point(4, 48);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(32, 13);
            this.label_filter.TabIndex = 2;
            this.label_filter.Text = "Filter:";
            // 
            // label_units
            // 
            this.label_units.AutoSize = true;
            this.label_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_units.Location = new System.Drawing.Point(176, 23);
            this.label_units.Name = "label_units";
            this.label_units.Size = new System.Drawing.Size(34, 13);
            this.label_units.TabIndex = 1;
            this.label_units.Text = "Units:";
            // 
            // label_range
            // 
            this.label_range.AutoSize = true;
            this.label_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_range.Location = new System.Drawing.Point(4, 23);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(42, 13);
            this.label_range.TabIndex = 0;
            this.label_range.Text = "Range:";
            // 
            // groupBox_measure_settings
            // 
            this.groupBox_measure_settings.Controls.Add(this.textBox_timeout);
            this.groupBox_measure_settings.Controls.Add(this.textBox_round);
            this.groupBox_measure_settings.Controls.Add(this.textBox_s_counts);
            this.groupBox_measure_settings.Controls.Add(this.textBox_m_counts);
            this.groupBox_measure_settings.Controls.Add(this.label_timeout);
            this.groupBox_measure_settings.Controls.Add(this.label_round);
            this.groupBox_measure_settings.Controls.Add(this.label_s_counts);
            this.groupBox_measure_settings.Controls.Add(this.label_m_counts);
            this.groupBox_measure_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_measure_settings.Location = new System.Drawing.Point(4, 1);
            this.groupBox_measure_settings.Name = "groupBox_measure_settings";
            this.groupBox_measure_settings.Size = new System.Drawing.Size(293, 72);
            this.groupBox_measure_settings.TabIndex = 25;
            this.groupBox_measure_settings.TabStop = false;
            this.groupBox_measure_settings.Text = "Measure Settings:";
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_timeout.Location = new System.Drawing.Point(227, 45);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(61, 20);
            this.textBox_timeout.TabIndex = 7;
            this.textBox_timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_timeout_KeyPress);
            // 
            // textBox_round
            // 
            this.textBox_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_round.Location = new System.Drawing.Point(227, 21);
            this.textBox_round.Name = "textBox_round";
            this.textBox_round.Size = new System.Drawing.Size(61, 20);
            this.textBox_round.TabIndex = 6;
            this.textBox_round.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_round_KeyPress);
            // 
            // textBox_s_counts
            // 
            this.textBox_s_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_s_counts.Location = new System.Drawing.Point(88, 45);
            this.textBox_s_counts.Name = "textBox_s_counts";
            this.textBox_s_counts.Size = new System.Drawing.Size(61, 20);
            this.textBox_s_counts.TabIndex = 5;
            this.textBox_s_counts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_s_counts_KeyPress);
            // 
            // textBox_m_counts
            // 
            this.textBox_m_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_m_counts.Location = new System.Drawing.Point(88, 21);
            this.textBox_m_counts.Name = "textBox_m_counts";
            this.textBox_m_counts.Size = new System.Drawing.Size(61, 20);
            this.textBox_m_counts.TabIndex = 4;
            this.textBox_m_counts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_m_counts_KeyPress);
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_timeout.Location = new System.Drawing.Point(177, 49);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(50, 13);
            this.label_timeout.TabIndex = 3;
            this.label_timeout.Text = "TimeOut:";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_round.Location = new System.Drawing.Point(177, 25);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(42, 13);
            this.label_round.TabIndex = 2;
            this.label_round.Text = "Round:";
            // 
            // label_s_counts
            // 
            this.label_s_counts.AutoSize = true;
            this.label_s_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_s_counts.Location = new System.Drawing.Point(1, 49);
            this.label_s_counts.Name = "label_s_counts";
            this.label_s_counts.Size = new System.Drawing.Size(83, 13);
            this.label_s_counts.TabIndex = 1;
            this.label_s_counts.Text = "Statistic Counts:";
            // 
            // label_m_counts
            // 
            this.label_m_counts.AutoSize = true;
            this.label_m_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_m_counts.Location = new System.Drawing.Point(1, 25);
            this.label_m_counts.Name = "label_m_counts";
            this.label_m_counts.Size = new System.Drawing.Size(87, 13);
            this.label_m_counts.TabIndex = 0;
            this.label_m_counts.Text = "Measure Counts:";
            // 
            // pictureBox_resistance
            // 
            this.pictureBox_resistance.Image = global::Keithley_2000.Properties.Resources.resistance_4W;
            this.pictureBox_resistance.Location = new System.Drawing.Point(4, 52);
            this.pictureBox_resistance.Name = "pictureBox_resistance";
            this.pictureBox_resistance.Size = new System.Drawing.Size(299, 121);
            this.pictureBox_resistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_resistance.TabIndex = 28;
            this.pictureBox_resistance.TabStop = false;
            // 
            // label_method
            // 
            this.label_method.AutoSize = true;
            this.label_method.Location = new System.Drawing.Point(7, 32);
            this.label_method.Name = "label_method";
            this.label_method.Size = new System.Drawing.Size(79, 13);
            this.label_method.TabIndex = 39;
            this.label_method.Text = "Select Method:";
            // 
            // comboBox_method
            // 
            this.comboBox_method.FormattingEnabled = true;
            this.comboBox_method.Items.AddRange(new object[] {
            "2-wires",
            "4-wires"});
            this.comboBox_method.Location = new System.Drawing.Point(93, 28);
            this.comboBox_method.Name = "comboBox_method";
            this.comboBox_method.Size = new System.Drawing.Size(59, 21);
            this.comboBox_method.TabIndex = 40;
            this.comboBox_method.SelectedIndexChanged += new System.EventHandler(this.comboBox_method_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // panel_settings
            // 
            this.panel_settings.Controls.Add(this.groupBox_measure_settings);
            this.panel_settings.Controls.Add(this.groupBox_ohmmeter_settings);
            this.panel_settings.Controls.Add(this.groupBox_chart_settings);
            this.panel_settings.Location = new System.Drawing.Point(4, 177);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(299, 236);
            this.panel_settings.TabIndex = 43;
            // 
            // button_copy
            // 
            this.button_copy.Image = global::Keithley_2000.Properties.Resources.copy_document_16x16;
            this.button_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_copy.Location = new System.Drawing.Point(659, 36);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(60, 23);
            this.button_copy.TabIndex = 44;
            this.button_copy.Text = "Copy";
            this.button_copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // groupBox_oneshot
            // 
            this.groupBox_oneshot.Controls.Add(this.button_oneshot_copy);
            this.groupBox_oneshot.Controls.Add(this.button_oneshot_clear);
            this.groupBox_oneshot.Controls.Add(this.button_oneshot);
            this.groupBox_oneshot.Controls.Add(this.label_oneshot);
            this.groupBox_oneshot.Location = new System.Drawing.Point(740, 25);
            this.groupBox_oneshot.Name = "groupBox_oneshot";
            this.groupBox_oneshot.Size = new System.Drawing.Size(277, 44);
            this.groupBox_oneshot.TabIndex = 49;
            this.groupBox_oneshot.TabStop = false;
            this.groupBox_oneshot.Text = "One Shot Measurements: ";
            // 
            // button_oneshot_copy
            // 
            this.button_oneshot_copy.Image = global::Keithley_2000.Properties.Resources.copy_document_16x16;
            this.button_oneshot_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_oneshot_copy.Location = new System.Drawing.Point(209, 15);
            this.button_oneshot_copy.Name = "button_oneshot_copy";
            this.button_oneshot_copy.Size = new System.Drawing.Size(61, 23);
            this.button_oneshot_copy.TabIndex = 49;
            this.button_oneshot_copy.Text = "Copy";
            this.button_oneshot_copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_oneshot_copy.UseVisualStyleBackColor = true;
            this.button_oneshot_copy.Click += new System.EventHandler(this.button_oneshot_copy_Click);
            // 
            // button_oneshot_clear
            // 
            this.button_oneshot_clear.Image = global::Keithley_2000.Properties.Resources.clear_black_16x16;
            this.button_oneshot_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_oneshot_clear.Location = new System.Drawing.Point(144, 15);
            this.button_oneshot_clear.Name = "button_oneshot_clear";
            this.button_oneshot_clear.Size = new System.Drawing.Size(58, 23);
            this.button_oneshot_clear.TabIndex = 48;
            this.button_oneshot_clear.Text = "Clear";
            this.button_oneshot_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_oneshot_clear.UseVisualStyleBackColor = true;
            this.button_oneshot_clear.Click += new System.EventHandler(this.button_oneshot_clear_Click);
            // 
            // button_oneshot
            // 
            this.button_oneshot.Image = global::Keithley_2000.Properties.Resources.target_black_16x16;
            this.button_oneshot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_oneshot.Location = new System.Drawing.Point(16, 15);
            this.button_oneshot.Name = "button_oneshot";
            this.button_oneshot.Size = new System.Drawing.Size(79, 23);
            this.button_oneshot.TabIndex = 46;
            this.button_oneshot.Text = "One Shot";
            this.button_oneshot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_oneshot.UseVisualStyleBackColor = true;
            this.button_oneshot.Click += new System.EventHandler(this.button_oneshot_Click);
            // 
            // label_oneshot
            // 
            this.label_oneshot.AutoSize = true;
            this.label_oneshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_oneshot.Location = new System.Drawing.Point(101, 18);
            this.label_oneshot.Name = "label_oneshot";
            this.label_oneshot.Size = new System.Drawing.Size(26, 17);
            this.label_oneshot.TabIndex = 47;
            this.label_oneshot.Text = "(0)";
            // 
            // p_resistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_oneshot);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.comboBox_method);
            this.Controls.Add(this.label_method);
            this.Controls.Add(this.groupBox_file);
            this.Controls.Add(this.label_counts);
            this.Controls.Add(this.label_rezult);
            this.Controls.Add(this.button_save_data);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.pictureBox_resistance);
            this.Controls.Add(this.label_tittle);
            this.Name = "p_resistance";
            this.Size = new System.Drawing.Size(1020, 461);
            this.Load += new System.EventHandler(this.p_resistance_Load);
            this.groupBox_file.ResumeLayout(false);
            this.groupBox_file.PerformLayout();
            this.panel_file.ResumeLayout(false);
            this.panel_file.PerformLayout();
            this.contextMenuStrip_Rez.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip_Chart.ResumeLayout(false);
            this.groupBox_chart_settings.ResumeLayout(false);
            this.groupBox_chart_settings.PerformLayout();
            this.groupBox_ohmmeter_settings.ResumeLayout(false);
            this.groupBox_ohmmeter_settings.PerformLayout();
            this.groupBox_measure_settings.ResumeLayout(false);
            this.groupBox_measure_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resistance)).EndInit();
            this.panel_settings.ResumeLayout(false);
            this.groupBox_oneshot.ResumeLayout(false);
            this.groupBox_oneshot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tittle;
        private System.Windows.Forms.GroupBox groupBox_file;
        private System.Windows.Forms.CheckBox checkBox_file;
        private System.Windows.Forms.Panel panel_file;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.Label label_counts;
        private System.Windows.Forms.Label label_rezult;
        private System.Windows.Forms.Button button_save_data;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.GroupBox groupBox_chart_settings;
        private System.Windows.Forms.TextBox textBox_chart_points;
        private System.Windows.Forms.Label label_chart_points_scale;
        private System.Windows.Forms.CheckBox checkBox_chart;
        private System.Windows.Forms.GroupBox groupBox_ohmmeter_settings;
        private System.Windows.Forms.Label label_delay_comment;
        private System.Windows.Forms.Label label_delay;
        private System.Windows.Forms.TextBox textBox_delay;
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.ComboBox comboBox_units;
        private System.Windows.Forms.ComboBox comboBox_range;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.Label label_units;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.GroupBox groupBox_measure_settings;
        private System.Windows.Forms.TextBox textBox_timeout;
        private System.Windows.Forms.TextBox textBox_round;
        private System.Windows.Forms.TextBox textBox_s_counts;
        private System.Windows.Forms.TextBox textBox_m_counts;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label_s_counts;
        private System.Windows.Forms.Label label_m_counts;
        private System.Windows.Forms.PictureBox pictureBox_resistance;
        private System.Windows.Forms.Label label_method;
        private System.Windows.Forms.ComboBox comboBox_method;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Chart;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Rez;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_chart_points_dell;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox_oneshot;
        private System.Windows.Forms.Button button_oneshot_copy;
        private System.Windows.Forms.Button button_oneshot_clear;
        private System.Windows.Forms.Button button_oneshot;
        private System.Windows.Forms.Label label_oneshot;
    }
}
