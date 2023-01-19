using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG06_ListBox_AplicacionPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarAprobado_Click(object sender, EventArgs e)
        {
           if (txtAgregarAprobado.Text.Length == 0)
            {
                MessageBox.Show("Debe de haber algo en el cuando de texto");
            }
            else
            {
                lbAprobados.Items.Add(txtAgregarAprobado.Text);
                txtAgregarAprobado.Clear();
            }
            
            
        }

        private void btnAgregarSuspenso_Click(object sender, EventArgs e)
        {
            if (txtAgregarSuspenso.Text.Length == 0)
            {
                MessageBox.Show("Debe de haber algo en el cuando de texto");
            }
            else
            {
                lbSuspensos.Items.Add(txtAgregarSuspenso.Text);
                txtAgregarSuspenso.Clear();
            }

                
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            if (lbAprobados.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algo");
            }
            else
            {
                lbSuspensos.Items.Add(lbAprobados.SelectedItem);
                lbAprobados.Items.RemoveAt(lbAprobados.SelectedIndex);
            }
            
            
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (lbSuspensos.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algo");
            }
            else
            {
                lbAprobados.Items.Add(lbSuspensos.SelectedItem);
                lbSuspensos.Items.RemoveAt(lbSuspensos.SelectedIndex);
            }
        }

        private void btnSuspenderTodos_Click(object sender, EventArgs e)
        {
            foreach (string elemento in lbAprobados.Items)
            {
                lbSuspensos.Items.Add(elemento);
            }
            lbAprobados.Items.Clear();
        }

        private void btnAprobarTodos_Click(object sender, EventArgs e)
        {
            for (int i = lbSuspensos.Items.Count - 1; i >= 0; i--)
            {
                lbSuspensos.SelectedIndex = i;
                lbAprobados.Items.Add(lbSuspensos.SelectedItem);

            }
            lbSuspensos.Items.Clear();
        }
    }
}
