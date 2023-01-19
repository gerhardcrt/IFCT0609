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

namespace M3_17_Renombrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            DirectoryInfo miCarpeta;
            FileInfo[] archivosEnCarpeta;

            if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
            {
                miCarpeta = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                archivosEnCarpeta = miCarpeta.GetFiles();

                foreach (FileInfo fichero in archivosEnCarpeta)
                {
                    lbFicheros.Items.Add(fichero);
                    lbNuevoNombre.Items.Add(fichero.Name);
                }
            }

            txtNuevoNombre.Clear();
      

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreFicheroActual;
            string nuevoNombre;
            int contador = 1;

            for(int i = 0; i < lbNuevoNombre.Items.Count; i++)
            {
                nombreFicheroActual = lbNuevoNombre.Items[i].ToString();
                nuevoNombre = txtNuevoNombre.Text +AgregarPrefijoCeros(i+1, lbFicheros.Items.Count) + contador.ToString() +( (FileInfo)lbFicheros.Items[i]).Extension;
                contador++;

                lbNuevoNombre.Items[i] = nuevoNombre;
            }         

        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            FileInfo f;
            string origen, destino;

            for(int posicion=0;posicion<lbFicheros.Items.Count; posicion++)
            {
                f = (FileInfo)lbFicheros.Items[posicion];
                origen = f.FullName;
                destino = f.DirectoryName + "\\" + lbNuevoNombre.Items[posicion];

                System.IO.File.Move(origen, destino);
                
            }

            MessageBox.Show("Todo listo");
            lbFicheros.Items.Clear();
            lbNuevoNombre.Items.Clear();
            txtNuevoNombre.Clear();
        }

        private string AgregarPrefijoCeros(int numero, int total)
        {

            if (total < 10) { return ""; }
            else if (total < 100)
            {
                if (numero < 10) { return "0"; }
                else { return ""; }
            }
                
            else if (total < 1000){
                if (numero < 10) { return "00"; }
                else if (numero <100){ return "0"; }
            }

            return "";

        }


    }
}
