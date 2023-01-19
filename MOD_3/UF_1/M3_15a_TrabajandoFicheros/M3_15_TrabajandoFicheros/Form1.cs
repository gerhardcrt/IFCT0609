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

namespace M3_15_TrabajandoFicheros
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
                }
            }
      

            
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;
                
                try
                {
                    System.IO.File.Delete(ficheroSeleccionado.FullName);
                    lbFicheros.Items.RemoveAt(lbFicheros.SelectedIndex);
                }
                catch(Exception ex)
                {
                    if(ex.ToString().Contains("siendo utilizado en otro proceso"))
                    {
                        MessageBox.Show("No es posible eliminarlo porque está abierto o en uso");
                    }
                }
                
            }

            
        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;
            DirectoryInfo miCarpeta;
            FileInfo[] archivosEnCarpeta;


            //Leo todos los fichero y los borro
            foreach (object obj in lbFicheros.Items)
            {
                ficheroSeleccionado = (FileInfo)obj;

                try
                {System.IO.File.Delete(ficheroSeleccionado.FullName);}
                catch {}
            }

            //vacío el listBox
            lbFicheros.Items.Clear();

            //Vuelvo a recargar el ListBox, los que quedan son lo que estaban bloqueados
            if (folderBrowserDialog1.SelectedPath != "")
            {
                miCarpeta = new DirectoryInfo(folderBrowserDialog1.SelectedPath);

                archivosEnCarpeta = miCarpeta.GetFiles();

                foreach (FileInfo fichero in archivosEnCarpeta)
                {
                    lbFicheros.Items.Add(fichero);
                }

                if (lbFicheros.Items.Count > 0)
                {
                    MessageBox.Show("No ha sido posible eliminarlos todos porque estos estaban en uso");
                }
            }
            


        }
    }
}
