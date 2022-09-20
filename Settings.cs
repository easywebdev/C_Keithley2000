using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Xml.Serialization;
using System.Globalization;

namespace Keithley_2000
{
    [Serializable]
    public class PortSettings
    {
        public string portname { set; get; }     // Port Name
        public int baudrate { set; get; }        // Baudrate Speed data transfer (look device settings)
        public Parity parity { set; get; }       // Parity
        public int databits { set; get; }        // Data Bits
        public StopBits stopbits { set; get; }   // Stop Bits
        public Handshake handshake { set; get; } // HandShake
        public int readtimeout { set; get; }     // Read TimeOut waiting responce to read data from device
        public int writetimeout { set; get; }    // Write TimeOut waiting responce to write data to device

        // Конструктор с настройками по умолчанию
        public PortSettings()
        {
            portname = "COM1";
            baudrate = 19200;
            parity = (Parity)Enum.Parse(typeof(Parity), "None");
            databits = 8;
            stopbits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
            readtimeout = 4000;
            writetimeout = 4000;
        }
    }

    [Serializable]
    public class MeasureSettings
    {
        public int MCounts { set; get; }               // Колличество измерений
        public int SCounts { set; get; }               // Колличестов точек для статистики
        public int Round { set; get; }                 // Округлегие (колличество цыфр после запятой, 0 = неокруглять)
        public int TimeOut { set; get; }               // Задержка между циклами измерения

        // Конструктор с настройками по умолчанию
        public MeasureSettings()
        {
            MCounts = 100;
            SCounts = 1;
            Round = 0;
            TimeOut = 0;
        }
    }

    public class ChartSettings
    {
        public bool EnableChart { set; get; }             // Включить / выключить график
        public int Points { set; get; }                   // Колличество точек после которых включается масштаб
        public int DelPoints { set; get; }                // Колличество точек на графике

        // Конструктор с настройками по умолчанию
        public ChartSettings()
        {
            EnableChart = true;
            Points = 0;
            DelPoints = 0;
        }
    }

    [Serializable]
    public class VoltmeterSettings
    {
        public string Range { set; get; }                   // Диапазон
        public string Units { set; get; }                   // Единицы измерения
        public string Filter { set; get; }                  // Фильтр
        public string Rate { set; get; }                    // Время интегрирования (fast, medium, slow)
        public int Delay { set; get; }                      // Задержка между командами для прибора, нужна чтобы не получать ERROR 363

        // Конструктор с настройками по умолчанию
        public VoltmeterSettings()
        {
            Range = "Auto";
            Units = "mV";
            Filter = "ON";
            Rate = "medium";
            Delay = 0;
        }
    }

    [Serializable]
    public class AmpermeterSettings
    {
        public string Range { set; get; }                   // Диапазон
        public string Units { set; get; }                   // Единицы измерения
        public string Filter { set; get; }                  // Фильтр
        public string Rate { set; get; }                    // Время интегрирования (fast, medium, slow)
        public int Delay { set; get; }                      // Задержка между командами для прибора, нужна чтобы не получать ERROR 363

        // Конструктор с настройками по умолчанию
        public AmpermeterSettings()
        {
            Range = "Auto";
            Units = "mA";
            Filter = "ON";
            Rate = "medium";
            Delay = 1;
        }
    }

    [Serializable]
    public class OhmmeterSettings
    {
        public string Range { set; get; }                   // Диапазон
        public string Units { set; get; }                   // Единицы измерения
        public string Filter { set; get; }                  // Фильтр
        public string Rate { set; get; }                    // Время интегрирования (fast, medium, slow)
        public int Delay { set; get; }                      // Задержка между командами для прибора, нужна чтобы не получать ERROR 363
        public string Method { set; get; }                  // Метод измерения (2-wires / 4-wires)

        // Конструктор с настройками по умолчанию
        public OhmmeterSettings()
        {
            Range = "Auto";
            Units = "Ω";
            Filter = "ON";
            Rate = "medium";
            Delay = 0;
            Method = "4-wires";
        }
    }

    // Общий класс, который объединяет классы всех настроек и используется для сериализации
    public class Settings
    {
        public PortSettings ComPort { set; get; }
        public MeasureSettings MS { set; get; }
        public VoltmeterSettings VS { set; get; }
        public AmpermeterSettings AS { set; get; }
        public OhmmeterSettings OS { set; get; }
        public ChartSettings ChS { set; get; }
    }

    // Класс для реализации операций сериализации и десериализации всех настроек
    public class Serializator
    {
        // функция десериализации, которая читает из файла все настройки возвращает в переенную все нстройки
        public Settings GetSerialize(string file)
        {
            XmlSerializer settings = new XmlSerializer(typeof(Settings));

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                Settings output = (Settings)settings.Deserialize(fs);
                return output;
            }
        }

        // функция для сериализации, которая сохраняет в файл все настройки
        public void SetSerialize(Settings input, string file)
        {
            XmlSerializer settings = new XmlSerializer(typeof(Settings));

            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                settings.Serialize(fs, input);
            }
        }
    }
}
