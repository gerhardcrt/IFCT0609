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

namespace M3_U2_29_RegistroJornadaMySQL
{
    public partial class FrmRegistroJornada : Form
    {
        public FrmRegistroJornada()
        {
            InitializeComponent();
        }

        private void FrmRegistroJornada_Load(object sender, EventArgs e)
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=registrojornada";
            cadenaComando = "SELECT * FROM `trabajadores`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            try
            {
                adaptador.Fill(ds);
                conexion.Close();
            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    cbTrabajadores.Items.Add(fila.ItemArray[1].ToString());
                }

                cbTrabajadores.SelectedIndex = 0;
            }
            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string cadenaConexion;
            string cadenaComando;
            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;

            string fecha, horaInicio, horaFin;
            string codigoTrabajador;
            
            codigoTrabajador = ObtenerCodigoTrabajador(cbTrabajadores.SelectedItem.ToString()).ToString();
            fecha = dtpFecha.Value.Year.ToString() + "-" + dtpFecha.Value.Month.ToString() + "-" +  dtpFecha.Value.Day.ToString();
            horaInicio = dtpHoraEntrada.Value.ToShortTimeString() + ":00";
            horaFin = dtpHoraSalida.Value.ToShortTimeString() + ":00";

            if (cbTrabajadores.SelectedIndex != -1)
            {
                cadenaConexion = "server=localhost;uid=root;password=1234;database=registrojornada";
                //cadenaComando = $"INSERT INTO `registro` (`idRegistro`, `trabajador`, `fecha`, `horaEntrada`, `horaSalida`) VALUES (NULL, '1', '2022-03-14', '10:30:00', '14:45:00')";
                  cadenaComando = $"INSERT INTO `registro` (`idRegistro`, `trabajador`, `fecha`, `horaEntrada`, `horaSalida`) VALUES (NULL, '{codigoTrabajador}', '{fecha}', '{horaInicio}', '{horaFin}')";
                conexion = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand(cadenaComando, conexion);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Insertado");
                }
                catch (Exception ex) { }

                conexion.Close();
            }
        }

        private int ObtenerCodigoTrabajador(string nombreTrabajador)
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=registrojornada";
            cadenaComando = $"SELECT `id` FROM `trabajadores` WHERE `nombre` = '{nombreTrabajador}'";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            try
            {
                adaptador.Fill(ds);
                conexion.Close();
                return int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return -1; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
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
