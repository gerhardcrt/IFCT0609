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

namespace M3_24_ADO_MySQL_LoginV1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarTodo();
        }

        private void BorrarTodo()
        {
            txtLogin.Clear();
            txtPass.Clear();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Si el todos los campos tienen contenido
            //      Descargar base de datos a un dataset local
            //      Recorro todas las filas de la tabla de usuarios en el DS
            //          Si encuentro un usuario cuyo login coincida con el del cuadro de texto
            //              Compruebo la contraseña
            //                  Si coincide --> validado
            //                  En caso contrario --> no validado
            //          Si no lo encuentro --> no validado
            //En caso contrario
            //      Error

            MySql.Data.MySqlClient.MySqlConnection con;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            string cadenaConexion, cadenaComando;
            bool encontrado;


            System.Data.DataSet ds;

            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debes de rellenar todos los campos");
            }
            else
            {
                #region "Cargado del DS a partir de la BD"
                cadenaConexion = "server=localhost;uid=root;pwd=1234;database=postal";
                cadenaComando = "SELECT * FROM `alumnos`;";

                con = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand(cadenaComando, con);
                adaptador = new MySqlDataAdapter(comando);

                ds = new DataSet();

                adaptador.Fill(ds);
                con.Close();
                #endregion

                encontrado = false;
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i].ItemArray[3].ToString() == txtLogin.Text)
                    {
                        encontrado = true;
                        if (ds.Tables[0].Rows[i].ItemArray[4].ToString() == txtPass.Text)
                        {
                            MessageBox.Show("Pasa \"palante\"");
                        }
                        else
                        {
                            MessageBox.Show("NO NO NO");
                        }

                        break;
                    }

                 }
                if (!encontrado)
                {
                    MessageBox.Show("NO NO NO : NO EXISTE");
                }
            }

        }
    }
}
