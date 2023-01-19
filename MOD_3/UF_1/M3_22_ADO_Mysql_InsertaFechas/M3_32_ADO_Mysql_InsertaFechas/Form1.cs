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

namespace M3_32_ADO_Mysql_InsertaFechas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarTodo();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            MySql.Data.MySqlClient.MySqlCommand comando;

            //dtpFechaAlta.Value.ToString()

            if (txtLogin.Text!="" && txtNombre.Text!="" && txtPass.Text != "")
            {
                string cadenaConexion = "server=localhost;uid=root;pwd=1234;database=postal"; //sCo
                string cadenaComando = $"INSERT INTO `alumnos` (`id`, `nombre`, `axuda`, `login`, `pass`, `fechaAlta`) VALUES (NULL, '{txtNombre.Text}', '{nudAxuda.Value.ToString().Replace(',', '.')}', '{txtLogin.Text}', '{txtPass.Text}', '{dtpFechaAlta.Value.ToString("yyyy-MM-dd")}')";

                con = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand(cadenaComando, con);


                try
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Hecho !!!");
                    BorrarTodo();

                }
                catch (Exception ex) {
                    if (ex.ToString().Contains("Duplicate entry"))
                    {
                        MessageBox.Show("Login duplicado");
                    }
                    else
                    {
                        MessageBox.Show("Algo ha fallado, llama a Soporte");
                    }
                }
                    

                con.Close();
            }
            else
            {
                MessageBox.Show("Debe cubrir todos los datos");
            }

            
        }

        private void BorrarTodo()
        {
            txtLogin.Clear();
            txtNombre.Clear();
            txtPass.Clear();
            nudAxuda.Value = 0;
            dtpFechaAlta.Value = DateTime.Now;
        }
    }
}
