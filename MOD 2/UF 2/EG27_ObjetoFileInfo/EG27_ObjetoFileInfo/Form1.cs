using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG27_ObjetoFileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo MiInformacionFichero;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MiInformacionFichero = new System.IO.FileInfo(openFileDialog1.FileName);

                label1.Text = MiInformacionFichero.FullName;
                label2.Text = MiInformacionFichero.DirectoryName;
                label3.Text = MiInformacionFichero.Attributes.ToString();
                label4.Text = MiInformacionFichero.Length.ToString();
                label5.Text = MiInformacionFichero.ToString();
            }

            

        }
    }
}
