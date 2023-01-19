using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_13_DetectaPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int largo=0;
            int posicion;

            posicion = BuscarPalabra(textBox1.Text,textBox2.Text,ref largo);

            textBox3.Text = posicion.ToString();
            textBox4.Text = largo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Esta es la frase en la que quiero buscar cosas." + Environment.NewLine;
            textBox1.Text += "\\f0\\fs28 Esto es una cadena en negrita" + Environment.NewLine + "áéíóúÁÉÍÓÚñÑ\\fs29";

            textBox2.Text = "\\f0\\fs28";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;

            ReemplazarPalabra(ref frase, textBox2.Text, textBox5.Text);

            textBox1.Text = frase;
        }
        private int ReemplazarPalabra(ref string  frase, string trozo, string textoNuevo)
        {
            int largo = 0;
            int posicion;
            string palabraSustituir;

            posicion = BuscarPalabra(frase, trozo, ref largo);
            if ( posicion== -1)
            {
                return -1;
            }
            else
            {
                palabraSustituir = frase.Substring(posicion, largo);
                frase = frase.Replace(palabraSustituir, textoNuevo);
                return 0;
            }
            
        }

        private int BuscarPalabra(string frase, string textoBuscado, ref int longitud)
        {
            int posicionInicio = frase.IndexOf(textoBuscado);
            longitud = -1;

            if (posicionInicio != -1)
            {
                for (int i = posicionInicio; i < frase.Length; i++)
                {
                    longitud = i - posicionInicio +1;
                    if (char.IsSeparator(frase[i]) || frase[i]=='\n')
                    {
                        longitud--;                
                        if (frase[i] == '\n') { longitud--; }
                        break;
                    }
                }
            }

            return posicionInicio;
        }


    }
}
