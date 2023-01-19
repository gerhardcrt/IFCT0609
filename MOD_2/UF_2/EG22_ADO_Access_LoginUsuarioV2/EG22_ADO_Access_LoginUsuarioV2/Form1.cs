using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG22_ADO_Access_LoginUsuarioV2
{
    public partial class FormValidar : Form
    {
        public FormValidar()
        {
            InitializeComponent();
        }

        //private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.usuariosBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.loginDataSet);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'loginDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.loginDataSet.usuarios);

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Recorro las filas del dataset buscando el usuario, si lo encuentro, miro el password y
            //y si coincide está ok

            //int usuarioEncontrado = -1;
            DataRow filaEncontrada = null;

            //for (int filas = 0; filas < loginDataSet.Tables["usuarios"].Rows.Count; filas++)
            //{

            //    if (txtUsuario.Text == loginDataSet.Tables["usuarios"].Rows[filas].ItemArray[0].ToString())
            //    {
            //        usuarioEncontrado = filas;
            //        break;
            //    } 

            //}
            
            //if (usuarioEncontrado != -1)
            //{
            //    if (txtPassword.Text == loginDataSet.Tables["usuarios"].Rows[usuarioEncontrado].ItemArray[1].ToString())
            //    {
            //        MessageBox.Show("PASA COLEGA");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Pass Mal");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("user no existe");
            //}

            foreach (DataRow fila in loginDataSet.Tables["usuarios"].Rows)
            {
                if (fila.ItemArray[0].ToString() == txtUsuario.Text)
                {
                    filaEncontrada = fila;
                    break;
                }
            }

            if (filaEncontrada != null)
            {
                if (filaEncontrada.ItemArray[1].ToString() == txtPassword.Text)
                {
                    MessageBox.Show("PASA COLEGA");
                }
                else
                {
                    MessageBox.Show("Pass Mal");
                }
            }
            else
            {
                MessageBox.Show("user no existe");
            }

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            int posicionBuscada = usuariosBindingSource.Find("usuario", txtUsuario.Text);

            if (posicionBuscada == -1)
            {
                if (MessageBox.Show("User not found. Quieres crearlo ?", "MIERDA algo falla !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    MessageBox.Show("Vale si no quieres no pasa nada");
                }
                else
                {
                    MessageBox.Show("Vamos a crear un nuevo usuario");
                }
                    
            }
            else
            {
                if (loginDataSet.Tables["usuarios"].Rows[posicionBuscada].ItemArray[1].ToString() == txtPassword.Text)
                {
                    //MessageBox.Show("PASA!");
                    MenuPrincipal NuevoFormulario = new MenuPrincipal();
                    NuevoFormulario.Show();
                    //this.Close(); --> Si lo cierrom, se cierra la APP
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password mal !!");
                }
            }
        }
    }
}
