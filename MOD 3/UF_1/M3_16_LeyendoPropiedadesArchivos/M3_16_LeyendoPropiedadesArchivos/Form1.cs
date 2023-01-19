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

namespace M3_16_LeyendoPropiedadesArchivos
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
            if (lbFicheros.SelectedIndex != -1)
            {
                lbFicheros.Items.RemoveAt(lbFicheros.SelectedIndex);
            }             
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFechaAcceso.Text = "";
            lblFechaCreacion.Text = "";
            lblFechaModificacion.Text = "";
        }

        private void lbFicheros_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;

                lblFechaCreacion.Text = System.IO.File.GetCreationTime(ficheroSeleccionado.FullName).ToString();
                lblFechaAcceso.Text = ficheroSeleccionado.LastAccessTime.ToString();
                lblFechaModificacion.Text = ficheroSeleccionado.LastWriteTime.ToString();

                dtpCreacion.Value = ficheroSeleccionado.CreationTime;
                dtpModificacion.Value = ficheroSeleccionado.LastWriteTime;
                dtpAcceso.Value = ficheroSeleccionado.LastAccessTime;

            }
        }

        private void btnCambiarCreacion_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;
                ficheroSeleccionado.CreationTime = dtpCreacion.Value;
            }
        }

        private void btnCambiarModificacion_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;
                ficheroSeleccionado.LastWriteTime = dtpModificacion.Value;
            }
        }

        private void btnCambiarAcceso_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;
                ficheroSeleccionado.LastAccessTime = dtpAcceso.Value;
            }
        }

        private void btnCambiarTodos_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            if (lbFicheros.SelectedIndex != -1)
            {
                dtpModificacion.Value = dtpCreacion.Value;
                dtpAcceso.Value = dtpCreacion.Value;

                ficheroSeleccionado = (FileInfo)lbFicheros.SelectedItem;
                ficheroSeleccionado.CreationTime = dtpCreacion.Value;
                ficheroSeleccionado.LastWriteTime = dtpModificacion.Value;
                ficheroSeleccionado.LastAccessTime = dtpAcceso.Value;
            }
        }

        private void btnCambiarTodosArchivos_Click(object sender, EventArgs e)
        {
            FileInfo ficheroSeleccionado;

            foreach(object obj in lbFicheros.Items)
            {
                ficheroSeleccionado = (FileInfo)obj;

                dtpModificacion.Value = dtpCreacion.Value;
                dtpAcceso.Value = dtpCreacion.Value;

                ficheroSeleccionado.CreationTime = dtpCreacion.Value;
                ficheroSeleccionado.LastWriteTime = dtpModificacion.Value;
                ficheroSeleccionado.LastAccessTime = dtpAcceso.Value;
            }

        }
    }
}
