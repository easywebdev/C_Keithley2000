using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keithley_2000
{
    public partial class p_main : UserControl
    {
        public p_main()
        {
            InitializeComponent();
        }

        /* Объекты и экземпляры классов */

        // Создаём экземпляры класса для страничек интерфейса "User Controls"
        p_voltage P_voltage = new p_voltage();
        p_resistance P_resistance = new p_resistance();
        p_current P_current = new p_current();

        /**/

        /* Функции */
        // Фунция для загрузки user control
        public void LoadPage(Control panel, Control page)
        {
            panel.Controls.Clear();
            panel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }
        /**/

        private void p_main_Load(object sender, EventArgs e)
        {
            
        }

        private void panel_voltage_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_voltage);
            Common.SF.SelectedItem = "Voltage Measurements";
        }

        private void pictureBox_voltage_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_voltage);
            Common.SF.SelectedItem = "Voltage Measurements";
        }

        private void label_voltage_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_voltage);
            Common.SF.SelectedItem = "Voltage Measurements";
        }

        private void panel_resistance_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void label_resistance_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void label_2w_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void label_4w_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void pictureBox_resistance_2W_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void pictureBox_resistance_4W_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_resistance);
            Common.SF.SelectedItem = "Resistance Measurements";
        }

        private void panel_current_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_current);
            Common.SF.SelectedItem = "Current Measurements";
        }

        private void label_current_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_current);
            Common.SF.SelectedItem = "Current Measurements";
        }

        private void pictureBox_current_Click(object sender, EventArgs e)
        {
            LoadPage(Common.P, P_current);
            Common.SF.SelectedItem = "Current Measurements";
        }
    }
}
