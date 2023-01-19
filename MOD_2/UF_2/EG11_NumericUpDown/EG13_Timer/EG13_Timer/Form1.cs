using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG13_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIrFinal_Click(object sender, EventArgs e)
        {
            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(500);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 1;
            }
            catch { timer1.Stop(); }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void CambiarColor(object sender, EventArgs e)
        {
            btnTimer.BackColor = Color.Red;
        }

        private void CambiarColor2(object sender, EventArgs e)
        {
            btnTimer.BackColor = SystemColors.Control;
        }
    }
}
