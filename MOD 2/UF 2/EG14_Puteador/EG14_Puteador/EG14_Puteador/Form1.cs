using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG14_Puteador
{
    public partial class Form1 : Form
    {
        bool estaArriba = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSufrir_Click(object sender, EventArgs e)
        {
            btnSufrir.Text = "Pues sufre";
            btnSufrir.Enabled = false;
        }

        private void Ocultar(object sender, EventArgs e)
        {
            btnNoPorfa.Visible = false;
            //HACER ALGO QUE NOS VUELVA A "AGRANDAR EL BOTON NI DE COÑA"
            tmCrecer.Start();
        }

        private void Mostrar(object sender, EventArgs e)
        {
            btnNoPorfa.Visible = true;
        }

        private void Desplazar(object sender, EventArgs e)
        {
            // if (!estaArriba)
            //{
            //    btnNoNoNo.Top = btnPosicion1.Top;
            //    estaArriba = true;
            //}
            //else
            //{
            //    btnNoNoNo.Top = btnPosicion2.Top;
            //    estaArriba = false;
            //}

            if (btnNoNoNo.Top == btnPosicion1.Top)
            {
                btnNoNoNo.Top = btnPosicion2.Top;
            } else
            {
                btnNoNoNo.Top = btnPosicion1.Top;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPosicion1.Visible = false;
            btnPosicion2.Visible = false;
            btnTamanhoNiDeConha.Visible = false;
            btnTamanhoNiDeConha.Width = btnNideConha.Width;

            btnLimiteInferiorDerecha.Visible = false;
            btnLimiteSuperiorIzquierda.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Encoger(object sender, EventArgs e)
        {
            //while (btnNideConha.Width > 0)
            //{
            //    //Problema de este sistema: bloqueo el hilo principal
            //    btnNideConha.Width -= 2;
            //    System.Threading.Thread.Sleep(3);
            //}

            tmEncoger.Start();
        }

        private void tmEncoger_Tick(object sender, EventArgs e)
        {
            if (btnNideConha.Width > 0)
            {
                btnNideConha.Width -= 2;
            } else
            {
                tmEncoger.Stop();
            }
        }

        private void tmCrecer_Tick(object sender, EventArgs e)
        {
            tmEncoger.Stop();
            if (btnNideConha.Width < btnTamanhoNiDeConha.Width)
            {
                btnNideConha.Width += 2;
            }
            else
            {
                tmCrecer.Stop();
            }
        }

        private void Escapar(object sender, EventArgs e)
        {
            Random posicionAleatoria = new Random();

            btnNegativo.Left = posicionAleatoria.Next(btnLimiteSuperiorIzquierda.Left, btnLimiteInferiorDerecha.Left);
            btnNegativo.Top = posicionAleatoria.Next(btnLimiteSuperiorIzquierda.Top, btnLimiteInferiorDerecha.Top);


        }
    }
}
