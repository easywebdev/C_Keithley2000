using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keithley_2000
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel_web_page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://it-experience.xyz/index.php/en/developments-en/for-measuring-instruments-en/84-keithley-2000-data-loger-en");
        }

        private void linkLabel_author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://it-experience.xyz/index.php/en/contacts-en/10-shurygin-fedor");
        }
    }
}
