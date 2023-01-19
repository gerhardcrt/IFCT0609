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
   
            lbAprobados.Items.Add(txtAgregarAprobado.Text);
            txtAgregarAprobado.Clear();

            btnSuspender.Enabled = true;
            btnSuspenderTodos.Enabled = true;

            lbAprobados.SelectedIndex = lbAprobados.Items.Count - 1;
            txtAgregarAprobado.Focus();
        }

        private void btnAgregarSuspenso_Click(object sender, EventArgs e)
        {
                lbSuspensos.Items.Add(txtAgregarSuspenso.Text);
                txtAgregarSuspenso.Clear();

            btnAprobar.Enabled = true;
            btnAprobarTodos.Enabled = true;

            lbSuspensos.SelectedIndex = lbSuspensos.Items.Count - 1;
            txtAgregarSuspenso.Focus();
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {

           lbSuspensos.Items.Add(lbAprobados.SelectedItem);
           lbAprobados.Items.RemoveAt(lbAprobados.SelectedIndex);

            lbAprobados.SelectedIndex = lbAprobados.Items.Count - 1;

            ComprobarBotones();

        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
                lbAprobados.Items.Add(lbSuspensos.SelectedItem);
                lbSuspensos.Items.RemoveAt(lbSuspensos.SelectedIndex);
                lbSuspensos.SelectedIndex = lbSuspensos.Items.Count - 1;

            ComprobarBotones();

        }

        private void btnSuspenderTodos_Click(object sender, EventArgs e)
        {
            foreach (string elemento in lbAprobados.Items)
            {
                lbSuspensos.Items.Add(elemento);
            }
            lbAprobados.Items.Clear();
            lbSuspensos.SelectedIndex = lbSuspensos.Items.Count - 1;

            ComprobarBotones();
        }

        private void btnAprobarTodos_Click(object sender, EventArgs e)
        {
            for (int i = lbSuspensos.Items.Count - 1; i >= 0; i--)
            {
                lbSuspensos.SelectedIndex = i;
                lbAprobados.Items.Add(lbSuspensos.SelectedItem);

            }
            lbSuspensos.Items.Clear();

            ComprobarBotones();
        }

        private void txtAgregarAprobado_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarAprobado.Text.Length > 0) { btnAgregarAprobado.Enabled = true; }
            else { btnAgregarAprobado.Enabled = false; }
        }

        private void txtAgregarSuspenso_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarSuspenso.Text.Length > 0) { btnAgregarSuspenso.Enabled = true; }
            else { btnAgregarSuspenso.Enabled = false; }

        }
    
        private void ComprobarBotones()
        {
            if (lbSuspensos.Items.Count == 0)
            {
                btnAprobar.Enabled = false;
                btnAprobarTodos.Enabled = false;
            } else
            {
                btnAprobar.Enabled = true;
                btnAprobarTodos.Enabled = true;
            }

            if (lbAprobados.Items.Count == 0)
            {
                btnSuspender.Enabled = false;
                btnSuspenderTodos.Enabled = false;
            }
            else
            {
                btnSuspender.Enabled = true;
                btnSuspenderTodos.Enabled = true;
            }

        }
    
    }
}
