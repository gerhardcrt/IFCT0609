using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG23_CuadrosDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Quieres sufrir", "Titulo Sufridor", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Pues sufre");
            }
            else
            {
                MessageBox.Show("Pues no sufras");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Por que lo cancelas ???");
            }
            else
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }
    }
}
