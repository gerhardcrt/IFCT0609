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

namespace M3U2_01_RepasoFicheros_Dialogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.StreamWriter sr;

            saveFileDialog1.ShowDialog();

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    sr = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.Default);
            //    sr.WriteLine(textBox1.Text);
            //    sr.Close();
            //    textBox1.Clear();
            //}


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamWriter sr;

            sr = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.Default);
            sr.WriteLine(richTextBox1.Text);
            sr.Close();
            richTextBox1.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
            textBox1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 
                richTextBox1.SelectionFont.Size + 5, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                btnColorSeleccionado.BackColor = colorDialog1.Color;
            }
            
        }

        private void btnColorSeleccionado_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = btnColorSeleccionado.BackColor;
        }
    }
}
