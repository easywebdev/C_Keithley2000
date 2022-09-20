using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keithley_2000
{
    public class Keithley2000
    {
        public string RST { set; get; }                        // Сбросить девайс
        public string Function { set; get; }                   // Выбор измерительной функции
        public string AutoZerou { set; get; }                  // Авто-Обнуление
        public string TrigCount { set; get; }                  // Тригер Коунт
        public string Display { set; get; }                    // Включить/Выключить дисплей
        public string Range { set; get; }                      // Выбро диапазона
        public string Filter { set; get; }                     // Установка фильтра
        public string Rate { set; get; }                       // Установка скорости интегрирования
        public string Read { set; get; }                       // Получить данные из буфера

        public Keithley2000()
        {
            RST = "*RST";
            Function = ":SENS:FUNC 'VOLT:DC'";
            AutoZerou = ":SYST:AZER:STAT OFF";
            TrigCount = ":TRIG:COUN 1";
            Display = ":DISP:ENAB ON";
            Range = ":SENSe:VOLTage:DC:RANGe:AUTO ON";
            Filter = ":SENS:VOLT:DC:AVER:STAT ON";
            Rate = ":SENS:VOLT:DC:NPLC 0.01";
            Read = ":READ?";
        }
    }
}
