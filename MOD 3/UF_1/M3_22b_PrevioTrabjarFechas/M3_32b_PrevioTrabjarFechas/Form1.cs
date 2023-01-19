using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_32b_PrevioTrabjarFechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string cadenaFecha;

            label1.Text = dateTimePicker1.Value.ToString();
            label2.Text = dateTimePicker1.Value.ToLongDateString();
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Value.Year.ToString();
            label5.Text = dateTimePicker1.Value.Month.ToString();
            label6.Text = dateTimePicker1.Value.Day.ToString();

            cadenaFecha = label4.Text + " " + label5.Text + " " + label6.Text;

            label7.Text = cadenaFecha;

            label8.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }
    }
}
