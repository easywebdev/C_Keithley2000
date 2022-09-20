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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Переменные */
        public static string _SettingsFile = "settings.xml";                    // Файл для хранения настроек
        /**/

        /* Объекты и экземпляры классов */

        // Создаём экземпляры класса для страничек интерфейса "User Controls"
        p_main P_main = new p_main();
        p_voltage P_voltage = new p_voltage();
        p_resistance P_resistance = new p_resistance();
        p_current P_current = new p_current();

        // Экземпляр класса для общих функций
        Common CF = new Common();

        // Создаём екземпляр класса для настроек СОМ-порта
        public static PortSettings ComPort = new PortSettings();

        // Создаём екземпляр класса всех настроек для работы с ними
        public static MeasureSettings MS = new MeasureSettings();
        public static VoltmeterSettings VS = new VoltmeterSettings();
        public static AmpermeterSettings AS = new AmpermeterSettings();
        public static OhmmeterSettings OS = new OhmmeterSettings();
        public static ChartSettings ChS = new ChartSettings();
        public static Settings settings = new Settings();

        // Создаём екземпляр класса с функциями серилизации и десирелизации (создал этот класс и функции в файле Settings.cs)
        Serializator serializator = new Serializator();

        /* Функции */
        // Фунция для загрузки user control
        public void LoadPage(Panel panel, Control page)
        {
            panel.Controls.Clear();
            panel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }
        /**/

        private void Form1_Load(object sender, EventArgs e)
        {
            // Грузим страницу по умолчанию (P_main) сработает событие в комбобокс "select measura function"
            comboBox_measure_function.SelectedItem = "Select...";

            // Проверяем есть ли в системе хотябы один COM-port
            string[] ports = SerialPort.GetPortNames();
            if(ports.Length == 0)
            {
                MessageBox.Show("Measurements is imposible.\nNo COM ports", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            // Устанавливаем настройки если есть файл с настройками, иначе будут взяты настройи по умолчанию из конструктора
            if(File.Exists(_SettingsFile))
            {
                settings = serializator.GetSerialize(_SettingsFile);
                ComPort = settings.ComPort;
                MS = settings.MS;
                VS = settings.VS;
                AS = settings.AS;
                OS = settings.OS;
                ChS = settings.ChS;
            }
            else
            {
                settings.ComPort = ComPort;
                settings.MS = MS;
                settings.VS = VS;
                settings.AS = AS;
                settings.OS = OS;
                settings.ChS = ChS;
                serializator.SetSerialize(settings, _SettingsFile);
            }

            // Устанавливаем элементы управления, которые нужно блокировать/разблокировать из других UserControls
            Common.UpMenu = menuStrip1;
            Common.CBox = comboBox_measure_function;
            Common.P = panel_maine;
            Common.SF = comboBox_measure_function;
        }

        private void comboBox_measure_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Тут пишем функцию для загрузки страничек в панель. Сами Старнички уже создал.
            string page = comboBox_measure_function.SelectedItem.ToString();

            switch(page)
            {
                case "Select...":
                    LoadPage(panel_maine, P_main);
                    break;
                case "Voltage Measurements":
                    LoadPage(panel_maine, P_voltage);
                    break;
                case "Resistance Measurements":
                    LoadPage(panel_maine, P_resistance);
                    break;
                case "Current Measurements":
                    LoadPage(panel_maine, P_current);
                    break;
            }
        }

        private void portSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FSettings = new Form2();
            FSettings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 FAbout = new Form3();
            FAbout.ShowDialog();
        }
    }
}
