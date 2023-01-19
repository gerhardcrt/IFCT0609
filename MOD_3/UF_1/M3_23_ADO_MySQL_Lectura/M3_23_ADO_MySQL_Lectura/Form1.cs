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

namespace M3_23_ADO_MySQL_Lectura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySql.Data.MySqlClient.MySqlConnection con;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaConexion = "server=localhost;uid=root;pwd=1234;database=postal";
            string cadenaComando = "SELECT * FROM `alumnos`;";

            con = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, con);
            adaptador = new MySqlDataAdapter(comando);

            ds = new DataSet();

            adaptador.Fill(ds);
            con.Close();

            MessageBox.Show(ds.Tables[0].Rows[3].ItemArray[1].ToString() + " - " +
                            ds.Tables[0].Rows[3].ItemArray[2].ToString() + " - " +
                            ds.Tables[0].Rows[3].ItemArray[4].ToString());

            }
    }
}
