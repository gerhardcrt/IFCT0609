using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace M3_30_ADO_MySQL_Commandos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://www.connectionstrings.com/

            MySql.Data.MySqlClient.MySqlConnection con;
            MySql.Data.MySqlClient.MySqlCommand comando;

            string cadenaConexion = "server=localhost;uid=root;pwd=1234;database=postal"; //sCo
            string cadenaComando = "INSERT INTO `alumnos` (`id`, `nombre`, `axuda`, `login`, `pass`) VALUES (NULL, 'Ivan', '444.44', 'ivan01', '1234')";

            con = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, con);


            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Hecho !!!");

            }
            catch (Exception ex) { }

            con.Close();


        }
    }
}
