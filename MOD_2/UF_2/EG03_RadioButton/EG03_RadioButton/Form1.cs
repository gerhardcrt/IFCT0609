using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG03_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1, n2;
            decimal resultado=0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            if (rbSumar.Checked) { resultado = n1 + n2; }
            if (rbRestar.Checked) { resultado = n1 - n2; }
            if (rbMultiplicar.Checked) { resultado = n1 * n2; }
                     

            if (rbDividir.Checked)
            {
                if (n2 == 0)
                {
                    txtResultado.Text = "Indef.";
                    return;
                }
                else
                { resultado = Math.Round(((decimal)n1 / (decimal)n2), 2);
                  }
            }
            txtResultado.Text = resultado.ToString();


        }

        private void rbActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivar.Checked) {btnCalcular.Enabled = true;}
            else { btnCalcular.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
