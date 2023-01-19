using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EG18_EstoNoEsUNGrafico_DLL_DNI;

namespace EG17_ValidarDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbLetraDNI.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeroDNI;
            //EG18_EstoNoEsUNGrafico_DLL_DNI.Validador MiValidador = new EG18_EstoNoEsUNGrafico_DLL_DNI.Validador();
            //Validador MiValidador = new Validador();


            if (int.TryParse(txtNumeroDNI.Text, out numeroDNI))
            {
                lbLetraDNI.Text = Validador.CalcularLetraDNI(txtNumeroDNI.Text);
                //lbLetraDNI.Text = MiValidador.CalcularLetraDNI(txtNumeroDNI.Text);
                //lbLetraDNI.Text=CalcularLetraDNI(txtNumeroDNI.Text);
            }
            else
            {
                MessageBox.Show("Eso no es un número !!!");
                lbLetraDNI.Text = "";
            }

        }

        //private string CalcularLetraDNI(string dni)
        //{
        //    int numeroDNI, resto;
        //    string secuenciaLetrasNIF = "TRWAGMYFPDXBNJZSQVHLCKE";

        //    numeroDNI = int.Parse(dni);
        //    resto = numeroDNI % 23;

        //    return secuenciaLetrasNIF[resto].ToString();
        //}
    }
}
