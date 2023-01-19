using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REP03_TecladoBotones
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtContenido.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //txtContenido.Text += ((Button)sender).Text;
            
            //Estas dos soluciones son equivalentes

            Button miBoton;
            miBoton = (Button)sender;

            if (txtContenido.Text.Length == 0)
            {
                txtContenido.Text += miBoton.Text;
            }
            else
            {
                //Solo escribo en el cuadro de texto, si es un número, o un más pero si no hay otro recién puesto
                if (miBoton.Text != "+" || !(txtContenido.Text.Substring(txtContenido.Text.Length - 1, 1) == "+"))
                {
                    txtContenido.Text += miBoton.Text;
                }

            }


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] numeroEnTexto;
            int total=0;


            txtContenido.Text = txtContenido.Text.Trim('+');
            numeroEnTexto = txtContenido.Text.Split('+');

            foreach (string texto in numeroEnTexto)
            {
                total += int.Parse(texto);
            }

            txtContenido.Text = total.ToString();

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Button[] botonesNumericos;
            bool nuevoEstado;

            botonesNumericos = new Button[] { btn_0, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };

            if (btn_1.Enabled == false)
            {
                nuevoEstado = true;
            }
            else
            {
                nuevoEstado = false;
            }

            foreach (Button b in botonesNumericos)
            {
                b.Enabled = nuevoEstado;
            }

        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            Button botonActual;
            byte numero;


            foreach (object elemento in this.Controls)
            {
                if (elemento.GetType() == typeof(Button))
                {
                    botonActual = (Button)elemento;

                    if (byte.TryParse(botonActual.Text,out numero))
                    {
                        botonActual.Enabled = false;
                    }                    
                }
                
            }
        }

        private void BailarNumeros(object sender, MouseEventArgs e)
        {
            int[] posiciones;
            Button[] botonesNumericos;
            
            posiciones = Auxiliares.Aleatorios.GenerarArrayAleatorios2(10, 0, 9);
            botonesNumericos = new Button[] { btn_0, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };

            for (int i = 0; i < botonesNumericos.Length; i++)
            {
                botonesNumericos[i].Text = posiciones[i].ToString();
            }
        }

    }
}
