using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG11_NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            VerificarFecha();
        }

        private void nudMes_ValueChanged(object sender, EventArgs e)
        {
            VerificarFecha();
        }

        private void nudAnho_ValueChanged(object sender, EventArgs e)
        {
            VerificarFecha();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudAnho.Minimum = DateTime.Now.Year;
            nudAnho.Maximum = DateTime.Now.Year+100;

            nudDia.Minimum = 1;
            nudMes.Minimum = 1;

            nudDia.Maximum = 31;
            nudMes.Maximum = 12;

        }

        private void VerificarFecha()
        {
            int anho = (int)nudAnho.Value;
            
            if ((nudMes.Value == 4 ||
                nudMes.Value == 6 ||
                nudMes.Value == 9 ||
                nudMes.Value == 11) && nudDia.Value > 30)
            {

                nudDia.Value = 30;
            }

            if (nudMes.Value==2 && DateTime.IsLeapYear(anho) && nudDia.Value > 29)
            {
                nudDia.Value = 29;
            }

            if (nudMes.Value == 2 && !DateTime.IsLeapYear(anho) && nudDia.Value > 28)
            {
                nudDia.Value = 28;
            }
        }


    }
}
