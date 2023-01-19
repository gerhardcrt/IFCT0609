using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG05_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblContenido.Text = listBox1.SelectedItem.ToString();
            lblIndice.Text = listBox1.SelectedIndex.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(txtNuevoElemento.Text);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }
    }
}
