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

namespace M3_18_RenombradoPorGrupos
{
    public partial class Form1 : Form
    {
        List<Extensiones> listaExtensiones;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            DirectoryInfo miCarpeta;
            FileInfo[] archivosEnCarpeta;

            Extensiones extensionActual;

            if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
            {
                miCarpeta = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                archivosEnCarpeta = miCarpeta.GetFiles();

                listaExtensiones = new List<Extensiones>();

                foreach (FileInfo fichero in archivosEnCarpeta)
                {
                    lbFicheros.Items.Add(fichero);
                    
                    extensionActual = new Extensiones(fichero.Extension);

                    if (listaExtensiones.Contains(extensionActual))
                    {
                        listaExtensiones[listaExtensiones.IndexOf(extensionActual)].CantidadTotal++;
                    }
                    else
                    {
                        listaExtensiones.Add(extensionActual);
                    }
                }
            }

            txtNuevoNombre.Clear();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            FicheroRenombrable f;
            string origen, destino;

            foreach(object obj in lbNuevoNombre.Items)
            {
                f = (FicheroRenombrable)obj;
                origen = f.informacion.FullName;
                destino = f.informacion.DirectoryName + "\\" + f.NuevoNombre;
                System.IO.File.Move(origen, destino);
            }

            MessageBox.Show("Todo listo");
            lbFicheros.Items.Clear();
            lbNuevoNombre.Items.Clear();
            txtNuevoNombre.Clear();
        }


        private void txtNuevoNombre_Leave(object sender, EventArgs e)
        {
            FicheroRenombrable fichero;
            
            if (txtNuevoNombre.Text.Length > 0)
            {

                for (int i = 0; i < lbFicheros.Items.Count; i++)
                {
                    fichero = new FicheroRenombrable(((FileInfo)lbFicheros.Items[i]).FullName, ref listaExtensiones, txtNuevoNombre.Text);
                    lbNuevoNombre.Items.Add(fichero);
                }

            }


        }
    }

    public class Extensiones : IEquatable<Extensiones>
    {
        public string Extension { set; get; }
        public int CantidadTotal { set; get; }

        public int IndiceActual { set; get; }

        public Extensiones(string e)
        {
            Extension = e;
            CantidadTotal = 0;
            IndiceActual = 1;
        }

        public bool Equals(Extensiones other)
        {
            if (other.Extension == Extension) { return true; }
            else { return false; }

        }

    }
    public class FicheroRenombrable
    {
        public FileInfo informacion { set; get; }
        public string NuevoNombre { set; get; }

        public FicheroRenombrable(string ruta, ref List<Extensiones> lista, string textoNuevoNombre)
        {
            Extensiones extActual;

            informacion = new FileInfo(ruta);
            extActual = lista[lista.IndexOf(new Extensiones(informacion.Extension))];

            NuevoNombre = textoNuevoNombre + AgregarPrefijoCeros(extActual.IndiceActual,extActual.CantidadTotal) + extActual.IndiceActual + extActual.Extension;
            extActual.IndiceActual++;

            lista[lista.IndexOf(new Extensiones(informacion.Extension))]=extActual;
        }

        public override string ToString()
        {
            return NuevoNombre;
        }

        private string AgregarPrefijoCeros(int numero, int total)
        {

            if (total < 10) { return ""; }
            else if (total < 100)
            {
                if (numero < 10) { return "0"; }
                else { return ""; }
            }

            else if (total < 1000)
            {
                if (numero < 10) { return "00"; }
                else if (numero < 100) { return "0"; }
            }

            return "";

        }

    }

}
