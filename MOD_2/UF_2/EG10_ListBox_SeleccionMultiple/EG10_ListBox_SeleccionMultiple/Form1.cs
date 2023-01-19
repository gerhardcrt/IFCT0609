using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG10_ListBox_SeleccionMultiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (int posicion in lbOrigen.SelectedIndices)
            {
                lbDestino.Items.Add(lbOrigen.Items[posicion]);
            }

            for (int posicion = lbOrigen.SelectedIndices.Count - 1; posicion >= 0; posicion--)
            {
                lbOrigen.Items.RemoveAt(lbOrigen.SelectedIndices[posicion]);
            }



        }
    }
}
