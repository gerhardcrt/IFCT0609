using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REP02_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            DateTime anhoNuevo = new DateTime(2022, 1, 1);

            if (DateTime.Now >= anhoNuevo)
            {
                MessageBox.Show("Feliz Año Nuevo!");
            }
            else
            {
                MessageBox.Show("Aún es 2021!");
            }
        }

        private void btnComprobar2_Click(object sender, EventArgs e)
        {
            DateTime fechaComprobar;
            DateTime anhoNuevo = new DateTime(2022, 1, 1);

            try
            {
                fechaComprobar = new DateTime(int.Parse(txtAnho.Text), int.Parse(txtMes.Text), int.Parse(txtDia.Text));

                if (fechaComprobar >= anhoNuevo)
                {
                    MessageBox.Show("Feliz Año Nuevo!");
                }
                else
                {
                    MessageBox.Show("Aún es 2021!");
                }

            }
            catch
            {
                MessageBox.Show("Eso no es una fecha Mendrugo/a/e !");
            }
        } 
    }
}
