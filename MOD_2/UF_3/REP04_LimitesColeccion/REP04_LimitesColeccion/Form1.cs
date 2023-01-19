using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REP04_LimitesColeccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var miColeccion = new HashSet<double>();

            Random al = new Random();
            int cantidad = 0;

            while (true)
            {
                miColeccion.Add(al.Next());

                if (miColeccion.Count % 1000000 == 0)
                { 
                    cantidad++;
                    button1.Text = cantidad.ToString();
                    this.Refresh();
                }
            }


        }
    }
}
