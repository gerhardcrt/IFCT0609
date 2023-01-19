using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG07_ForzandoColecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MiLista = new List<string>();
            ulong datoActual = 0;

            while (datoActual < ulong.MaxValue)
            {
                try
                {
                    MiLista.Add("000");
                    if (datoActual % 100000 == 0) { 
                        button1.Text = datoActual.ToString(); 
                        this.Refresh(); 
                    }
                }
                catch
                {
                    MessageBox.Show("He roto en la iteracion: " + datoActual.ToString());
                    break;
                }
                
                datoActual++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                button2.Text = i.ToString();
                this.Refresh();
            }
        }
    }
}
