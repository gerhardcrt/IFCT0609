using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_13_BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btnTareaPesada_Click(object sender, EventArgs e)
        {
            int i, j, total=0;
            int limiteI = 5000;
            int limiteJ = 1000000;

            for (i=0; i<limiteI; i++)
            {
                if (i % 500 == 0)
                {
                    label1.Text = i.ToString();
                    this.Refresh();
                }

                for (j = 0; j < limiteJ; j++)
                { total = i * j;}
            }

            MessageBox.Show("Acabe");

        }
        private void btnPesadaSegundoPlano_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i, j, total = 0;
            int limiteI = 5000;
            int limiteJ = 1000000;

            for (i = 0; i < limiteI; i++)
            {
                if (i % 500 == 0)
                {
                    //label1.Text = i.ToString();
                    //this.Refresh();
                }

                for (j = 0; j < limiteJ; j++)
                {
                    total = i * j;

                }

            }

            MessageBox.Show("Acabe");
        }
    }
}
