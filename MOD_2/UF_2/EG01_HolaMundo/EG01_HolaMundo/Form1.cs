using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG01_HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola !!!");

            //if (lblEtiquetaSaludo.Text== "Hola chicxs!!!")
            //{
            //    lblEtiquetaSaludo.Text = "";
            //}
            //else { lblEtiquetaSaludo.Text = "Hola chicxs!!!"; }

            //if (lblEtiquetaSaludo.Visible == false)
            if (!lblEtiquetaSaludo.Visible)
            {
                lblEtiquetaSaludo.Visible = true;
            }
            else { lblEtiquetaSaludo.Visible = false; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEtiquetaSaludo.Text = "Hola chicxs !!!";
            lblSaludoNombre.Text = "";
        }

        private void btnPulsameNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length ==0)
            {
                MessageBox.Show("No te has olvidado de algo ???");
            }
            //else { lblSaludoNombre.Text = "Hola " + txtNombre.Text + "!!!";  }
            else {  lblSaludoNombre.Text = $"Hola {txtNombre.Text} !!!";  }
          
               
        }
    }
}
