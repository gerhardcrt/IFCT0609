using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG14_Puteador
{
    public partial class Form1 : Form
    {
        bool estaArriba = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSufrir_Click(object sender, EventArgs e)
        {
            btnSufrir.Text = "Pues sufre";
            btnSufrir.Enabled = false;
        }

        private void Ocultar(object sender, EventArgs e)
        {
            btnNoPorfa.Visible = false;
        }

        private void Mostrar(object sender, EventArgs e)
        {
            btnNoPorfa.Visible = true;
        }

        private void Desplazar(object sender, EventArgs e)
        {
             if (!estaArriba)
            {
                btnNoNoNo.Top = btnPosicion1.Top;
                estaArriba = true;
            }
            else
            {
                btnNoNoNo.Top = btnPosicion2.Top;
                estaArriba = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPosicion1.Visible = false;
            btnPosicion2.Visible = false;
        }
    }
}
