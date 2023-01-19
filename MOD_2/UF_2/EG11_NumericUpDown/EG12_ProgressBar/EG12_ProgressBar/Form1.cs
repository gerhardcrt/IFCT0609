using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG12_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value -= 20;
            }
            catch { }
            
        }


        private void btnMasStep_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}
