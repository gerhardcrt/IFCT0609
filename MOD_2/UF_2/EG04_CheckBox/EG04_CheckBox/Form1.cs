using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG04_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cadenaResultado = "";
            byte numeroIdiomas = 0;

            // si el nombre introducido es incorrecto
            if (txtNombre.Text.Length < 2) { MessageBox.Show("Longitud de nombre incorrecta"); } 
            else
            {
                if (ckbEspanhol.Checked) { numeroIdiomas += 1; }
                if (ckbGalego.Checked) { numeroIdiomas += 1; }
                if (ckbIngles.Checked) { numeroIdiomas += 1; }

                cadenaResultado = "Hola " + txtNombre.Text + ". Dominas " + numeroIdiomas.ToString() + " idiomas.";
                MessageBox.Show(cadenaResultado);
                //te muestra el número de idiomas que hablas
            }

            
        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {

            string cadenaResultado = "";
            byte numeroIdiomas = 0;
            string cadenaIdiomas = "";

            
            if (txtNombre.Text.Length < 2) { MessageBox.Show("Longitud de nombre incorrecta"); }
            else
            {
                if (ckbEspanhol.Checked) { numeroIdiomas += 1; cadenaIdiomas += " Español,"; }
                if (ckbGalego.Checked) { numeroIdiomas += 1; cadenaIdiomas += " Galego,"; }
                if (ckbIngles.Checked) { numeroIdiomas += 1; cadenaIdiomas += " Inglés,"; }

                cadenaIdiomas = cadenaIdiomas.Trim();
                cadenaIdiomas = cadenaIdiomas.TrimEnd(',');

                cadenaResultado = "Hola " + txtNombre.Text + ". Dominas " + numeroIdiomas.ToString() + " idiomas. Que son: " + cadenaIdiomas + ".";
                MessageBox.Show(cadenaResultado);
                // aquí te mostraría, a mayores de la cantidad, los idiomas con su nombre
            }

        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {
            string cadenaResultado = "";
            byte numeroIdiomas = 0;

            var idiomas = new List<string>();

            if (txtNombre.Text.Length < 2) { MessageBox.Show("Longitud de nombre incorrecta"); }
            else
            {                
                if (ckbEspanhol.Checked) { numeroIdiomas += 1; idiomas.Add("Español"); }
                if (ckbGalego.Checked) { numeroIdiomas += 1; idiomas.Add("Galego"); }
                if (ckbIngles.Checked) { numeroIdiomas += 1; idiomas.Add(ckbIngles.Text); }

                cadenaResultado = "Hola " + txtNombre.Text + ". Dominas " + numeroIdiomas.ToString() + " idiomas. Que son: " ;
                
                foreach(string idioma in idiomas)
                {
                    cadenaResultado += idioma + " ";
                }
                

                MessageBox.Show(cadenaResultado);
            }

        }
    }
}
