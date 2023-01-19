using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG02_MiniCalculadoraV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            try
            {
                n1 = int.Parse(txtN1.Text);
            } catch
            {
                txtN1.Text = "0";
                n1 = 0;
            }
            
            n2 = int.Parse(txtN2.Text);

            resultado = n1 + n2;

            lblResultado.Text = "Resultado: " + resultado.ToString();

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            resultado = n1 - n2;

            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            resultado = n1 * n2;

            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int n1, n2;
            decimal resultado;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            try
            {
                resultado = (decimal)n1 / (decimal)n2;
                resultado = Math.Round(resultado, 2);
                lblResultado.Text = "Resultado: " + resultado.ToString();

            } catch
            {
                lblResultado.Text = "indeterminado";
            }

            
            
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            //int n;

            try
            {
                //n = int.Parse(txtN2.Text);
                _ = int.Parse(txtN2.Text);
                errP_N2.Clear();
            }


            catch
            {
                //txtN2.Text="0";
                //txtN2.Select(0, 1);
                //errP_N2.SetError(txtN2, "Tío eso no es un número, lercho !!!");
                txtN2.TextChanged -= new System.EventHandler(txtN2_TextChanged);
            }
        }
    }
}
