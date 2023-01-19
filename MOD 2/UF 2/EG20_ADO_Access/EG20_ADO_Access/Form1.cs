using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG20_ADO_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void companhiasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companhiasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejercitoV2DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercitoV2DataSet.companhias' Puede moverla o quitarla según sea necesario.
            this.companhiasTableAdapter.Fill(this.ejercitoV2DataSet.companhias);

        }
    }
}
