using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Keithley_2000
{
    class Common
    {
        public static Control UpMenu { set; get; } = null;
        public static Control CBox { set; get; } = null;
        public static Control P { set; get; } = null;
        public static ComboBox SF { set; get; } = null;

        public static string separ = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

        // Блокируем интерфейс (входной параметр - список всех контролов)
        public void BlockIface(Control[] controls)
        {
            foreach(Control control in controls)
            {
                control.Enabled = false;
            }
        }

        // Разблокируем интерфейс (входной параметр - список всех контролов)
        public void UnblockIface(Control[] controls)
        {
            foreach(Control control in controls)
            {
                control.Enabled = true;
            }
        }

        // Функция для открытия порта
        public void open_port(SerialPort _port, PortSettings _portsetings)
        {
            _port.PortName = _portsetings.portname;
            _port.BaudRate = _portsetings.baudrate;
            _port.Parity = _portsetings.parity;
            _port.DataBits = _portsetings.databits;
            _port.StopBits = _portsetings.stopbits;
            _port.Handshake = _portsetings.handshake;
            _port.ReadTimeout = _portsetings.readtimeout;
            _port.WriteTimeout = _portsetings.writetimeout;

            if (!_port.IsOpen)
            {
                _port.Open();
            }
        }

        // Функция для закрытия порта
        public void close_port(SerialPort _port)
        {
            if (_port.IsOpen)
            {
                _port.Close();
            }
        }

        // Функция для преобразования строковых единиц измерения в коеффициент
        public double UnitsCoefficient(string units)
        {
            double Coef = 1;
            string Symb = units.Substring(0, 1);

            switch(Symb)
            {
                case "m":
                    Coef = 1E3;
                    break;
                case "µ":
                    Coef = 1E6;
                    break;
                case "n":
                    Coef = 1E9;
                    break;
                case "k":
                    Coef = 1E-3;
                    break;
                case "M":
                    Coef = 1E-6;
                    break;
            }

            return Coef;
        }

        // Функция для прорисовки графика
        public void DrowChart(Chart ch, int X, double Y, int points, int delpoints)
        {
            if (Math.Abs(Y) < (Double)Decimal.MaxValue)
            {
                ch.Series[0].Points.AddXY(X, Y);
            }

            if(delpoints > 0) // Если надо удалять точки с графика
            {
                if (ch.Series[0].Points.Count > delpoints)
                {
                    ch.Series[0].Points.RemoveAt(0);
                    ch.ResetAutoValues();
                }
            }

            if (points > 0) // Если установить масштаб по оси Х
            {
                if (ch.Series[0].Points.Count > points)
                {
                    ch.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = X - points;
                    ch.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = points - 3;
                }
            }
        }

        // Функция записи в файл
        public void SaveLog(string filename, string data, bool append_data)
        {
            using (StreamWriter outfile = new StreamWriter(filename, append_data))
            {
                outfile.WriteLine(data);
            }
        }

        public string dataToTableString(List<DataTemplate> listData, string value, string units)
        {
            StringBuilder data = new StringBuilder();

            string dataRow = $"#\tDateTime\tTimespan [ms]\t{value} [{units}]";
            data.Append(dataRow).AppendLine();

            foreach (DataTemplate row in listData)
            {
                dataRow = $"{row.Number}\t{ row.DTime.ToString("dd.MM.yyyy HH:mm:ss,fff")}\t{row.TimeSpan.ToString("F0")}\t{row.Data}";
                data.Append(dataRow).AppendLine();
            }

            return data.ToString();
        }
    }

    // Структура данных для записи в файл (для всех измерительных функций)
    struct DataTemplate
    {
        public int Number { set; get; }
        public DateTime DTime { set; get; }
        public double TimeSpan { set; get; }
        public double Data { set; get; }
    }
}
