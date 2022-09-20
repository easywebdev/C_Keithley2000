using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml.Serialization;

namespace Keithley_2000
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* Переменные */
        string[] ports = SerialPort.GetPortNames();              // получаем список всех COM-портов в системе
        Settings settings;
        /**/

        /* Объекты и экземпляры классов */
        // Создаём екземпляр класса с функциями серилизации и десирелизации (создал этот класс и функции в файле Settings.cs)
        Serializator serializator = new Serializator();
        /**/

        /* Функции */
        public PortSettings apply_settings(PortSettings port)
        {
            try
            {
                port.portname = comboBox_port1.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Measurements is imposible.\nNo COM ports\n\n" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            port.baudrate = int.Parse(comboBox_baudrate1.SelectedItem.ToString());
            port.parity = (Parity)Enum.Parse(typeof(Parity), comboBox_parity1.SelectedItem.ToString());

            try
            {
                port.databits = int.Parse(textBox_databits1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("DataBits must be an integer\n\n" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            port.stopbits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stopbits1.SelectedItem.ToString());
            port.handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_handshake1.SelectedItem.ToString());

            try
            {
                port.readtimeout = int.Parse(textBox_readtimeout1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Read Timeout must be an integer\n\n" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                port.writetimeout = int.Parse(textBox_writetimeout1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Write Timeout must be an integer\n\n" + ex, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return port;
        }
        /**/

        private void Form2_Load(object sender, EventArgs e)
        {
            // Применяем все настройки
            settings = Form1.settings;

            // Формируем списки для формы
            comboBox_port1.Items.AddRange(ports);

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboBox_parity1.Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                comboBox_stopbits1.Items.Add(s);
            }

            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                comboBox_handshake1.Items.Add(s);
            }

            // Пишем настройки порта в интерфейс
            if(ports.Length > 0)
            {
                comboBox_port1.SelectedItem = settings.ComPort.portname;
                comboBox_baudrate1.SelectedItem = settings.ComPort.baudrate.ToString();
                comboBox_parity1.SelectedItem = settings.ComPort.parity.ToString();
                textBox_databits1.Text = settings.ComPort.databits.ToString();
                comboBox_stopbits1.SelectedItem = settings.ComPort.stopbits.ToString();
                comboBox_handshake1.SelectedItem = settings.ComPort.handshake.ToString();
                textBox_readtimeout1.Text = settings.ComPort.readtimeout.ToString();
                textBox_writetimeout1.Text = settings.ComPort.writetimeout.ToString();
            }
            else
            {
                MessageBox.Show("Measurements is imposible.\nNo COM ports", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            settings.ComPort = apply_settings(settings.ComPort);
            serializator.SetSerialize(settings, Form1._SettingsFile);
        }
    }
}
