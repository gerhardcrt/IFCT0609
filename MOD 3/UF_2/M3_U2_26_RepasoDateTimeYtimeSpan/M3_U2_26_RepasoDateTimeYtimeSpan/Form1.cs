using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_26_RepasoDateTimeYtimeSpan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            TimeSpan fechaTS;

            fecha = dateTimePicker1.Value;
            fechaTS = new TimeSpan(dateTimePicker1.Value.Ticks);
            fechaTS = new TimeSpan(dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);

            dateTimePicker2.Value = fecha;
            dateTimePicker2.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,fechaTS.Hours, fechaTS.Minutes, fechaTS.Seconds);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

