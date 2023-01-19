using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clases;

namespace M3_U2_30_RegistroJornadaMySQL_POO

{
    public partial class FrmRegistroJornada : Form
    {
        BD mysql;

        public FrmRegistroJornada()
        {
            InitializeComponent();
        }

        private void FrmRegistroJornada_Load(object sender, EventArgs e)
        {
            mysql = new BD("localhost", "registrojornada", "root", "1234");
            List<Trabajador> listadoTrabajadores = Jornada.ObtenerTrabajadores(mysql);

            foreach (Trabajador t in listadoTrabajadores)
            {
                cbTrabajadores.Items.Add(t);
            }
            if (cbTrabajadores.Items.Count > 0)
            {
                cbTrabajadores.SelectedIndex = 0;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            Jornada jornadaActual = new Jornada(dtpFecha.Value, dtpHoraEntrada.Value, dtpHoraSalida.Value, (Trabajador)cbTrabajadores.SelectedItem);
            if (jornadaActual.AgregarJornada(mysql) == 0)
            {
                MessageBox.Show("insertado");
            }
            else
            {
                MessageBox.Show("algo ha fallado");
            }

        }

        

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
        }

        private void btnAhoraEntrada_Click(object sender, EventArgs e)
        {
            dtpHoraEntrada.Value = DateTime.Now;
        }

        private void btnAhoraSalida_Click(object sender, EventArgs e)
        {
            dtpHoraSalida.Value = DateTime.Now;
        }
    }
}
