using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_19_PasoPorReferenciayPorValor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BloquearBotones();
        }

        private void BloquearBotones()
        {
            txtContingeciasComunes.ReadOnly = true;
            txtDesempleo.ReadOnly = true;
            txtFormacion.ReadOnly = true;
            txtFogasa.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal salarioBruto, contingenciasComunes=0, fogasa=0, desempleo=0, formacion=0;

            if (txtSalarioBruto.Text.Length > 0)
            {

                try
                {
                    salarioBruto = decimal.Parse(txtSalarioBruto.Text);
                }
                catch
                {
                    salarioBruto = 0;
                    txtSalarioBruto.Text = "0";
                }

                //calculos...
               CalcularCotizacionesEmpresa(salarioBruto, ref contingenciasComunes, ref desempleo, ref fogasa, ref formacion);

                //desempleo = Math.Round(salarioBruto * (decimal)5.5 / 100, 2);
                //fogasa = Math.Round(salarioBruto * (decimal)0.2 / 100, 2);
                //formacion = Math.Round(salarioBruto * (decimal)0.6 / 100, 2);

                txtContingeciasComunes.Text = contingenciasComunes.ToString();
                txtDesempleo.Text = desempleo.ToString();
                txtFogasa.Text = fogasa.ToString();
                txtFormacion.Text = formacion.ToString();
            }
        }

        private decimal CalcularContingenciasComunes(decimal salarioBruto)
        {
            return Math.Round(salarioBruto * (decimal)23.6 / 100, 2);
        }

        private void CalcularCotizacionesEmpresa(decimal salarioBruto, ref decimal contingencias, ref decimal costeDesempleo, ref decimal costeFogasa, ref decimal costeFormacion)
        {
            contingencias = Math.Round(salarioBruto * (decimal)23.6 / 100, 2);
            costeDesempleo = Math.Round(salarioBruto * (decimal)5.5 / 100, 2);
            costeFogasa = Math.Round(salarioBruto * (decimal)0.2 / 100, 2);
            costeFormacion = Math.Round(salarioBruto * (decimal)0.6 / 100, 2);

            
        }
    }
}
