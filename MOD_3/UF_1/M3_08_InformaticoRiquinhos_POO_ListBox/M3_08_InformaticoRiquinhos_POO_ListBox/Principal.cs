using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_08_InformaticoRiquinhos_POO_ListBox
{
    public partial class frmPrincipal : Form
    {
        Informatico[] arrayInformaticos;
        int posicion;

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (posicion < arrayInformaticos.Length - 1)
            {
                posicion++;

                MostrarDatos(arrayInformaticos[posicion]);
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;

                MostrarDatos(arrayInformaticos[posicion]);
            }
        }

        public frmPrincipal()
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

            MostrarDatos(arrayInformaticos[posicion]);

            txtNombre.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtPasta.ReadOnly = true;

        }

        private void MostrarDatos(Informatico i)
        {
            pBFoto.Image = i.Foto;
            txtNombre.Text = i.Nombre;
            txtCargo.Text = i.Cargo;
            txtPasta.Text = i.Pasta.ToString() + " millones de euros";
        }
    }
}
