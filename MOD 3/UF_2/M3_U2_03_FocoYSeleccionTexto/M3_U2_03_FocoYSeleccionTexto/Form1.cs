using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_03_FocoYSeleccionTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Select(0, 10);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
            textBox1.Select(textBox1.Text.Length, 0);
        }
    }
}
