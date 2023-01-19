using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace M3_02_EscribirEnFicheroTexto
{
    public partial class Form1 : Form
    {
        private StreamWriter ficheroEscritura;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEscribirLinea_Click(object sender, EventArgs e)
        {
            //Si la el cuadro de texto está vacío
            //      Protestamos
            //En caso contrario
            //      Sacamos el contenido del cuadro de texto por un messageBox

            ficheroEscritura = new StreamWriter("datos.txt",false);

            if (txtLinea.Text == "")
            {
                MessageBox.Show("El cuadro está vacío");
            } else
            {
                ficheroEscritura.WriteLine(txtLinea.Text);
                txtLinea.Clear();
            }

            ficheroEscritura.Close();
        }

        private void btnEscribir2_Click(object sender, EventArgs e)
        {
            StreamWriter ficheroEscritura2 = new StreamWriter("FicheroTexto.txt", false);
            StreamWriter ficheroHTML = new StreamWriter("index.html", false);

            if (txtTextoHTML.Text == "")
            {
                MessageBox.Show("El cuadro está vacío");
            }
            else
            {
                ficheroEscritura2.WriteLine(txtTextoHTML.Text);

                ficheroHTML.WriteLine("<HTML><HEAD><TITLE>Mi web de prueba</TITLE></HEAD><BODY><H2>");
                for(int i=0;i<txtTextoHTML.Text.Length;i++)
                {
                    if (txtTextoHTML.Text[i] != '\r')
                    {
                        ficheroHTML.Write(txtTextoHTML.Text[i]);
                    }
                    else
                    {
                        ficheroHTML.Write("<br>");
                    }
                }
                
                
                ficheroHTML.WriteLine("</H2></BODY></HTML>");

                txtTextoHTML.Clear();
            }

            ficheroEscritura2.Close();
            ficheroHTML.Close();

        }
    }
}
