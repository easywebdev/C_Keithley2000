﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace Keithley_2000
{
    public partial class p_voltage : UserControl
    {
        public p_voltage()
        {
            InitializeComponent();
        }

        /* Переменные */
        bool _mstop = false;                            // Остановить измерения
        Settings settings;                              // Все настройки (данные присваиваем в событии OnLoad)
        string _filename = null;                        // Файл для записи данных
        /**/

        /* Объекты и экземпляры классов */
        // Создаём екземпляр класса с функциями серилизации и десирелизации (создал этот класс и функции в файле Settings.cs)
        Serializator serializator = new Serializator();

        // Экземпляр класса комманд, которые подаём на Keithley2000
        Keithley2000 device = new Keithley2000();

        // Создаём экземпляр класса SerialPort
        SerialPort SP = new SerialPort();

        // Экземпляр класса для общих функций
        Common CF = new Common();

        // Экземпляр класса данных
        DataTemplate DT = new DataTemplate();
        List<DataTemplate> _row = new List<DataTemplate>();
        List<DataTemplate> oneshotData = new List<DataTemplate>();
        /**/

        /* Функции */
        // устанавливаем настройки
        public void SetSettings(Settings settings)
        {
            try
            {
                settings.MS.MCounts = int.Parse(textBox_m_counts.Text);
                if (settings.MS.MCounts == 0)
                {
                    settings.MS.MCounts = 1;
                    textBox_m_counts.Text = settings.MS.MCounts.ToString();
                    MessageBox.Show("Error! Measure Counts must be > 0", "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                textBox_m_counts.Text = settings.MS.MCounts.ToString();
                MessageBox.Show("Error! Measure Counts must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                settings.MS.SCounts = int.Parse(textBox_s_counts.Text);
                if (settings.MS.MCounts == 0)
                {
                    settings.MS.SCounts = 1;
                    textBox_s_counts.Text = settings.MS.SCounts.ToString();
                    MessageBox.Show("Error! Statistic Counts must be > 0", "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                textBox_s_counts.Text = settings.MS.SCounts.ToString();
                MessageBox.Show("Error! Statiatic Counts must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                settings.MS.Round = int.Parse(textBox_round.Text);
            }
            catch (Exception ex)
            {
                textBox_round.Text = settings.MS.Round.ToString();
                MessageBox.Show("Error! Round must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                settings.MS.TimeOut = int.Parse(textBox_timeout.Text);
            }
            catch (Exception ex)
            {
                textBox_timeout.Text = settings.MS.TimeOut.ToString();
                MessageBox.Show("Error! TimeOut must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            settings.VS.Range = comboBox_range.SelectedItem.ToString();
            settings.VS.Units = comboBox_units.SelectedItem.ToString();
            settings.VS.Filter = comboBox_filter.SelectedItem.ToString();
            settings.VS.Rate = comboBox_rate.SelectedItem.ToString();
            try
            {
                settings.VS.Delay = int.Parse(textBox_delay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Delay must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                settings.ChS.DelPoints = int.Parse(textBox_chart_points_dell.Text);
            }
            catch (Exception ex)
            {
                textBox_chart_points_dell.Text = settings.ChS.DelPoints.ToString();
                MessageBox.Show("Error! Points must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                settings.ChS.Points = int.Parse(textBox_chart_points.Text);
            }
            catch (Exception ex)
            {
                textBox_chart_points.Text = settings.ChS.Points.ToString();
                MessageBox.Show("Error! Points must be an intager\n\n" + ex, "Erorr parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        // Устанавливаем команды, которые нужно подать на Keithley2000
        public void VoltmeterCommands(VoltmeterSettings vs, Keithley2000 device)
        {

            switch(vs.Range)
            {
                case "Auto":
                    device.Range = ":SENSe:VOLTage:DC:RANGe:AUTO ON";
                    break;
                case "1000V":
                    device.Range = ":SENSe:VOLTage:DC:RANGe 1000";
                    break;
                case "100V":
                    device.Range = ":SENSe:VOLTage:DC:RANGe 100";
                    break;
                case "10V":
                    device.Range = ":SENSe:VOLTage:DC:RANGe 10";
                    break;
                case "1V":
                    device.Range = ":SENSe:VOLTage:DC:RANGe 1";
                    break;
                case "100mV":
                    device.Range = ":SENSe:VOLTage:DC:RANGe 0.1";
                    break;
            }

            switch(vs.Filter)
            {
                case "ON":
                    device.Filter = ":SENS:VOLT:DC:AVER:STAT ON";
                    break;
                case "OFF":
                    device.Filter = ":SENS:VOLT:DC:AVER:STAT OFF";
                    break;
            }

            switch(vs.Rate)
            {
                case "fast":
                    device.Rate = ":SENS:VOLT:DC:NPLC 0.01";
                    break;
                case "medium":
                    device.Rate = ":SENS:VOLT:DC:NPLC 1";
                    break;
                case "slow":
                    device.Rate = ":SENS:VOLT:DC:NPLC 10";
                    break;
            }
        }

        // Функция имерения, которая выполняется в отдельном потоке
        void Measure()
        {
            // Запускаем счётчик времени
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // открываем порт и подаём стартовые команды для прибора
            try
            {
                CF.open_port(SP, settings.ComPort);

                SP.WriteLine(device.RST);
                SP.WriteLine(device.Function);
                SP.WriteLine(device.Range);
                SP.WriteLine(device.Rate);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Device Connection Error!\nCheck the Device connectson and settings\n\n" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Временные переменные
            double V = 0;                                     // вычисленное напряжение


            // Обнуляем коллекцию (List)
            _row.Clear();

            // Основной цикл измерения
            for (int i = 0; i < settings.MS.MCounts; i++)
            {
                // Елси нжали на кнопку "STOP"
                if (_mstop)
                {
                    _mstop = false;
                    break;
                }

                // Временные переменные
                double ReZ = 0;                                   // переменная для накапливания результата

                // Внутренний цыкл
                for (int j = 0; j < settings.MS.SCounts; j++)
                {
                    // Временные переменные
                    string _rez = null;                               // переменная для получения данных из буфера Keithly2000

                    // если останавливаем измерения
                    if (_mstop)
                    {
                        if (j != 0)
                        {
                            settings.MS.SCounts = j;
                        }
                        else
                        {
                            settings.MS.SCounts = 1;
                        }
                        break;
                    }

                    try
                    {
                        SP.WriteLine(device.Read);
                        _rez = SP.ReadLine();
                        ReZ += double.Parse(_rez.Replace(".", Common.separ));
                        if (settings.AS.Delay != 0)
                        {
                            Thread.Sleep(settings.VS.Delay);            // Задержка нужна чтобы не получать ERROR 363 (Input buffer overrun)
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Device Connection Error!\nCheck the Device connectson and settings\n\n" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //_mstop = true;
                    }
                }

                V = (ReZ / settings.MS.SCounts) * CF.UnitsCoefficient(settings.VS.Units);

                // если есть округление
                if (settings.MS.Round != 0)
                {
                    V = Math.Round(V, settings.MS.Round);
                }

                DT.Number = i + 1;
                DT.DTime = DateTime.Now;
                if(i > 0)
                {
                    DT.TimeSpan = (DateTime.Now - _row[0].DTime).TotalMilliseconds;
                    
                }
                else
                {
                    DT.TimeSpan = 0;
                }
                DT.Data = V;

                _row.Add(DT);

                // Если стоит галочка писать файл
                if(_filename != null)
                {
                    string data = DT.Number + "\t" + DT.DTime.ToString("dd.MM.yyyy HH:mm:ss,fff") + "\t" + DT.TimeSpan.ToString("F0") + "\t" + DT.Data;

                    if (!File.Exists(_filename))
                    {
                        string _tittle = "#\tDateTime\tTimeSpan [ms]\tV [" + settings.VS.Units + "]";
                        CF.SaveLog(_filename, _tittle, false);
                        CF.SaveLog(_filename, data, true);
                    }
                    else
                    {
                        CF.SaveLog(_filename, data, true);
                    }
                }

                //Вывод результата
                this.Invoke(new ThreadStart(() =>
                {
                    label_rezult.Text = V.ToString() + " " + settings.VS.Units;
                    label_counts.Text = (i + 1).ToString() + " / " + settings.MS.MCounts.ToString();

                    if(settings.ChS.EnableChart)
                    {
                        CF.DrowChart(chart1, i + 1, V, settings.ChS.Points, settings.ChS.DelPoints);
                    }
                }));
                
                // Задержка между измерениями
                Thread.Sleep(settings.MS.TimeOut);
            }

            // закрываем порт
            CF.close_port(SP);

            // Останавливаем счётчик времени
            sw.Stop();

            this.Invoke(new ThreadStart(() =>
            {
                // Снимаем блокировку интерфейса
                Control[] controls = new Control[] { Common.UpMenu, Common.CBox, panel_settings, button_start, button_save_data, button_calculate, button_copy, groupBox_oneshot };
                CF.UnblockIface(controls);

                // пишем в лог информацию о завершении измерений
                label_log.Text = "Log: Measure finished, Elapsed time: " + sw.ElapsedMilliseconds * 1E-3 + " sec";
            }));
        }
        /**/

        private void p_voltage_Load(object sender, EventArgs e)
        {
            // Задаём функцию измерения - Постоянное напряжение
            device.Function = ":SENS:FUNC 'VOLT:DC'";

            // Применяем настройки
            settings = Form1.settings;

            // Выводим настройки в интерфейс
            textBox_m_counts.Text = settings.MS.MCounts.ToString();
            textBox_s_counts.Text = settings.MS.SCounts.ToString();
            textBox_round.Text = settings.MS.Round.ToString();
            textBox_timeout.Text = settings.MS.TimeOut.ToString();

            if(settings.ChS.EnableChart)
            {
                checkBox_chart.CheckedChanged -= checkBox_chart_CheckedChanged;
                checkBox_chart.Checked = true;
                checkBox_chart.CheckedChanged += checkBox_chart_CheckedChanged;
            }
            textBox_chart_points.Text = settings.ChS.Points.ToString();
            textBox_chart_points_dell.Text = settings.ChS.DelPoints.ToString();

            comboBox_range.SelectedItem = settings.VS.Range.ToString();
            comboBox_units.SelectedItem = settings.VS.Units.ToString();
            comboBox_filter.SelectedItem = settings.VS.Filter.ToString();
            comboBox_rate.SelectedItem = settings.VS.Rate.ToString();
            textBox_delay.Text = settings.VS.Delay.ToString();

            // настройки по умолчинию для графика
            chart1.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = false;
        }

        private void checkBox_chart_CheckedChanged(object sender, EventArgs e)
        {
            if(settings.ChS.EnableChart)
            {
                settings.ChS.EnableChart = false;
            }
            else
            {
                settings.ChS.EnableChart = true;
            }
        }

        private void button_save_settings_Click(object sender, EventArgs e)
        {
            // Применяем настройки
            SetSettings(settings);

            // Пишем настройки в файл
            serializator.SetSerialize(settings, Form1._SettingsFile);
        }

        private void textBox_m_counts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_s_counts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_round_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_timeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_delay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_chart_points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            _mstop = false;
            label_log.Text = "Log: Measure Started";
            label_counts.Text = "0 / " + settings.MS.MCounts.ToString();

            // Блокируем интерфейс
            Control[] controls = new Control[] { Common.UpMenu, Common.CBox, panel_settings, button_start, button_save_data, button_calculate, button_copy, groupBox_oneshot };
            CF.BlockIface(controls);

            // Применяем настройки
            SetSettings(settings);
            VoltmeterCommands(settings.VS, device);

            // График
            if(settings.ChS.EnableChart)
            {
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "V, " + comboBox_units.SelectedItem.ToString();
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(); // Сбрасываем скролбар
                chart1.ResetAutoValues();
            }

            // Лог файл
            if(_filename != null)
            {
                string _tittle = "#\tDateTime\tTimeSpan [ms]\tV [" + settings.VS.Units + "]";
                CF.SaveLog(_filename, _tittle, false);
            }

            // Запуск процесса измерения
            Thread th = new Thread(Measure);
            th.IsBackground = true;
            th.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            _mstop = true;
        }

        private void checkBox_file_CheckedChanged(object sender, EventArgs e)
        {
            if (_filename == null && checkBox_file.Checked == true)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
                else
                {
                    _filename = null;
                    checkBox_file.CheckedChanged -= checkBox_file_CheckedChanged;
                    checkBox_file.Checked = false;
                    checkBox_file.CheckedChanged += checkBox_file_CheckedChanged;
                }
            }
            else
            {
                _filename = null;
                checkBox_file.CheckedChanged -= checkBox_file_CheckedChanged;
                checkBox_file.Checked = false;
                checkBox_file.CheckedChanged += checkBox_file_CheckedChanged;
            }
            label_file.Text = "File name: " + _filename;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double _mean = _row.Select(x => x.Data).Average();
            label_rezult.Text = _mean.ToString() + " " + settings.VS.Units;
        }

        private void button_save_data_Click(object sender, EventArgs e)
        {
            string _file = null;
            string _tittle = "#\tDateTime\tTimeSpan [ms]\tV [" + settings.VS.Units + "]";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _file = saveFileDialog1.FileName;

                if(_file != null)
                {
                    using(StreamWriter outfile = new StreamWriter(_file))
                    {
                        outfile.WriteLine(_tittle);
                        foreach (DataTemplate row in _row)
                        {
                            string data = row.Number.ToString() + " \t" + row.DTime.ToString("dd.MM.yyyy HH:mm:ss,fff") + "\t" + row.TimeSpan.ToString("F0") + "\t" + row.Data.ToString();
                            outfile.WriteLine(data);
                        }
                    }

                    label_log.Text = "Log: Data successfuly saved to file: " + _file;
                }
            }
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if (_row.Count > 0)
            {
                Clipboard.SetText(CF.dataToTableString(_row, "V", settings.VS.Units));
                label_log.Text = "Log: Measurements data copied";
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if(settings.ChS.DelPoints != 0)
            {
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(); // Сбрасываем скролбар
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = label_rezult.Text;
            string[] spliter = data.Split(' ');
            Clipboard.SetText(spliter[0]);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 0)
            {
                StringBuilder data = new StringBuilder();

                string dataRow = $"#\tV [{settings.VS.Units}]";
                data.Append(dataRow).AppendLine();

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                {
                    dataRow = $"{chart1.Series[0].Points[i].XValue}\t{chart1.Series[0].Points[i].YValues[0]}";
                    data.Append(dataRow).AppendLine();
                }

                Clipboard.SetText(data.ToString());
                label_log.Text = "Log: Chart data copied";
            }
        }

        private void button_oneshot_Click(object sender, EventArgs e)
        {
            _mstop = false;
            
            // Log information
            label_log.Text = "Log: One Shot measurements started";
            
            // Блокируем интерфейс
            Control[] controls = new Control[] { Common.UpMenu, Common.CBox, panel_settings, button_start, button_save_data, button_calculate, button_copy, button_oneshot, button_oneshot_copy, button_oneshot_clear };
            CF.BlockIface(controls);

            // Применяем настройки
            SetSettings(settings);
            VoltmeterCommands(settings.VS, device);

            // Запуск процесса измерения
            Thread oneshotTH = new Thread(() => {
                double Rez = 0;

                // open port
                try
                {
                    CF.open_port(SP, settings.ComPort);

                    //SP.WriteLine(device.RST);
                    SP.WriteLine(device.Function);
                    SP.WriteLine(device.Range);
                    SP.WriteLine(device.Rate);
                }
                catch (Exception ex)
                {
                    _mstop = true;
                    MessageBox.Show("Device Connection Error!\nCheck the Device connectson and settings\n\n" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                for (int i = 0; i < settings.MS.SCounts; i++)
                {
                    // если останавливаем измерения
                    if (_mstop)
                    {
                        if (i != 0)
                        {
                            settings.MS.SCounts = i;
                        }
                        else
                        {
                            settings.MS.SCounts = 1;
                        }
                        break;
                    }

                    try
                    {
                        SP.WriteLine(device.Read);
                        Rez += double.Parse(SP.ReadLine().Replace(".", Common.separ));

                        if (settings.VS.Delay != 0)
                        {
                            Thread.Sleep(settings.VS.Delay);            // Задержка нужна чтобы не получать ERROR 363 (Input buffer overrun)
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Device Connection Error!\nCheck the Device connectson and settings\n\n" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _mstop = true;
                    }
                }

                Rez = (Rez / settings.MS.SCounts) * CF.UnitsCoefficient(settings.VS.Units);

                // если есть округление
                if (settings.MS.Round != 0)
                {
                    Rez = Math.Round(Rez, settings.MS.Round);
                }

                DT.DTime = DateTime.Now;
                if (oneshotData.Count > 0)
                {
                    DT.TimeSpan = (DateTime.Now - oneshotData[0].DTime).TotalMilliseconds;

                }
                else
                {
                    DT.TimeSpan = 0;
                }

                DT.Number = oneshotData.Count + 1;
                DT.Data = Rez;

                oneshotData.Add(DT);

                // close port
                CF.close_port(SP);

                // Show results
                this.Invoke(new ThreadStart(() => {
                    label_rezult.Text = $"{DT.Data} {settings.VS.Units}";
                    label_oneshot.Text = $"({oneshotData.Count})";
                    label_log.Text = "Log: One Shot measuremrnts finished";
                    CF.UnblockIface(controls);
                }));
            });
            oneshotTH.IsBackground = true;
            oneshotTH.Start();
        }

        private void button_oneshot_clear_Click(object sender, EventArgs e)
        {
            oneshotData.Clear();
            label_oneshot.Text = oneshotData.Count.ToString();
        }

        private void button_oneshot_copy_Click(object sender, EventArgs e)
        {
            if(oneshotData.Count > 0)
            {
                Clipboard.SetText(CF.dataToTableString(oneshotData, "V", settings.VS.Units));
            }
        }
    }
}
