using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG21_ADO_Access_Login
{
    public partial class Form1 : Form
    {
        int[] datos = new int[] { 2, 3, 6, 8, 10 };
        int posicionActual;
        int posicionEnTabla;

        public Form1()
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

            posicionEnTabla = 0;
            txtContenido.Text = loginDataSet.Tables["usuarios"].Rows[posicionEnTabla].ItemArray[0].ToString();
                       
            posicionActual = 0;
            txtTestArray.Text = datos[posicionActual].ToString();
        }

        private void btnAvanzarArray_Click(object sender, EventArgs e)
        {
            posicionActual++;
            txtTestArray.Text = datos[posicionActual].ToString();
        }

        private void btnRetrocederArray_Click(object sender, EventArgs e)
        {
            posicionActual--;
            txtTestArray.Text = datos[posicionActual].ToString();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {

            posicionEnTabla++;
            try
            {
                txtContenido.Text = loginDataSet.Tables["usuarios"].Rows[posicionEnTabla].ItemArray[0].ToString();
            }
            catch
            {
                posicionEnTabla--;
            }

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            posicionEnTabla--;
            try
            {
                txtContenido.Text = loginDataSet.Tables["usuarios"].Rows[posicionEnTabla].ItemArray[0].ToString();

            }
            catch
            {
                posicionEnTabla++;
            }

        }

        private void btnAvanzar2_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.Position++;

        }

        private void btnRetroceder2_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.Position--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginOK = false;

            for (int i = 0; i < usuariosBindingSource.Count; i++)
            {
                if(usuarioTextBox.Text == txtUser.Text && passwordTextBox.Text == txtPassword.Text)
                {
                    loginOK = true;
                    break;
                } else { usuariosBindingSource.Position++;}
            }

            usuariosBindingSource.Position = 0;
            if (loginOK) { MessageBox.Show("LOGEADO"); } 
            else { MessageBox.Show("NO NO NO");}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool loginOK = false;

            for (int i = 0; i < loginDataSet.Tables["usuarios"].Rows.Count; i++)
            {
                if (loginDataSet.Tables["usuarios"].Rows[i].ItemArray[0].ToString() == txtUser.Text)
                {
                    if (loginDataSet.Tables["usuarios"].Rows[i].ItemArray[1].ToString() == txtPassword.Text)
                    {
                        MessageBox.Show("Login ok");
                        loginOK = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Login incorrecto - mal password");
                        loginOK = false;
                        break;
                    }
                }

            }
            if (loginOK) { MessageBox.Show("LOGEADO"); }
            else { MessageBox.Show("NO NO NO"); }
        }
    }
}
