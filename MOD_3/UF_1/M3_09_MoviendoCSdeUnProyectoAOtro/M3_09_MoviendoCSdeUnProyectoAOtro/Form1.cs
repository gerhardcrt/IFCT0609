using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_06_InformaticosRiquinhos
{
    public partial class Form1 : Form
    {
        string[] rutasImagenes, nombres, cargos;
        int[] dinero;
        int posicion;

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (posicion < rutasImagenes.Length - 1)
            {
                posicion++;

                MostrarDatos(posicion);
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;

                MostrarDatos(posicion);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nombres = new string[] { "Bill Gates", "Steve Jobs", "Paul Allen", "Steve Wozniak" };
            cargos = new string[] { "Fundador de MS", "Fundador de Apple", "Fundador de MS", "Fundador de Apple" };
            rutasImagenes = new string[] { "imagenes/foto1.jpg", "imagenes/foto2.jpg", "imagenes/foto3.jpg", "imagenes/foto4.jpg" };
            dinero = new int[] { 134000, 10200, 17500, 100 };
            posicion = 0;

            MostrarDatos(posicion);

            txtNombre.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtPasta.ReadOnly = true;

        }

        private void MostrarDatos(int p)
        {
            pBFoto.Image = Image.FromFile(rutasImagenes[p]);
            txtNombre.Text = nombres[p];
            txtCargo.Text = cargos[p];
            txtPasta.Text = dinero[p].ToString() + " millones de euros";
        }
    }
}
