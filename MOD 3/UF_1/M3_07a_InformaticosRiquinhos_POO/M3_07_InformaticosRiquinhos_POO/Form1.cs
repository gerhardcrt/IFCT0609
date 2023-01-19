using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_07_InformaticosRiquinhos_POO
{
    public partial class Form1 : Form
    {
        Informatico[] arrayInformaticos;
        int posicion;

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (posicion < arrayInformaticos.Length - 1)
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
            Informatico i1 = new Informatico("Bill Gates", "Fundador de MS", 134000, "imagenes/foto1.jpg");
            Informatico i2 = new Informatico("Steve Jobs", "Fundador de Apple", 10200, "imagenes/foto2.jpg");
            Informatico i3 = new Informatico("Paul Allen", "Fundador de MS", 17500, "imagenes/foto3.jpg");
            Informatico i4 = new Informatico("Steve Wozniak", "Fundador de Apple", 100, "imagenes/foto4.jpg");

            arrayInformaticos = new Informatico[] { i1, i2, i3, i4 };

            posicion = 0;

            MostrarDatos(posicion);

            txtNombre.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtPasta.ReadOnly = true;

        }

        private void MostrarDatos(int p)
        {
            //pBFoto.Image = Image.FromFile(rutasImagenes[p]);
            //txtNombre.Text = nombres[p];
            //txtCargo.Text = cargos[p];
            //txtPasta.Text = dinero[p].ToString() + " millones de euros";
        }
    }
}
