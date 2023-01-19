using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_04_ProyectoAgendaCSV
{
    public partial class Form1 : Form
    {
        Agenda miAgenda;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            miAgenda = new Agenda("datos.csv");

            if (miAgenda.Elementos == null)
            {
                MessageBox.Show("No hay elementos en la agenda. Agregue alguno");
            }
            else
            {
                foreach (Contacto c in miAgenda.Elementos)
                {
                    lbContactos.Items.Add(c);
                }

            }

            txtEmail.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtTelefono.ReadOnly = true;
        }

        private void lbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contacto c;

            if (lbContactos.SelectedIndex != -1)
            {
                c = (Contacto)lbContactos.SelectedItem;
                
                txtTelefono.Text = c.Telefono;
                txtNombre.Text = c.Nombre;
                txtEmail.Text = c.Email;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Contacto c;

            if (lbContactos.SelectedIndex != -1)
            {
                c = (Contacto)lbContactos.SelectedItem;
                lbContactos.Items.RemoveAt(lbContactos.SelectedIndex);
                miAgenda.Borrar(c);
                
                txtEmail.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
            }
        }

        private void CerrandoPrograma(object sender, FormClosingEventArgs e)
        {
            miAgenda.Guardar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Contacto nuevo = new Contacto(txtTelefono.Text, txtNombre.Text, txtEmail.Text);

            if (btnModificar.Text == "Modificar")
            {
                if (lbContactos.SelectedIndex == -1)
                {
                    MessageBox.Show("No hay contacto seleccionado");
                }
                else
                {
                    btnModificar.Text = "Guardar";
                    btnModificar.Font = new Font(btnModificar.Font.FontFamily, btnModificar.Font.Size + 4);
                    GestionarTodosLosControles(false);
                }
                
            }
            else
            {

                miAgenda.Modificar((Contacto)lbContactos.SelectedItem,nuevo);

                lbContactos.Items[lbContactos.SelectedIndex] = nuevo;
                btnModificar.Text = "Modificar";
                btnModificar.Font = new Font(btnModificar.Font.FontFamily, btnModificar.Font.Size - 4);
                GestionarTodosLosControles(true);
            }
        }

        private void GestionarTodosLosControles(bool estado)
        {
            txtEmail.ReadOnly = estado;
            txtNombre.ReadOnly = estado;

            txtTelefono.Enabled = estado;

            lbContactos.Enabled = estado;
            txtFiltro.Enabled = estado;

            btnBorrar.Enabled = estado;
            btnAnhadir.Enabled = estado;
        }

        private void GestionarTodosLosControlesAnhadir(bool estado)
        {
            if (!estado)
            {
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNombre.Clear();
            }      

            txtTelefono.ReadOnly = estado;
            txtEmail.ReadOnly = estado;
            txtNombre.ReadOnly = estado;

            lbContactos.Enabled = estado;
            txtFiltro.Enabled = estado;

            btnBorrar.Enabled = estado;
            btnModificar.Enabled = estado;
        }

        private void btnAnhadir_Click(object sender, EventArgs e)
        {
            Contacto c;

            if (btnAnhadir.Text == "Añadir")
            {
                btnAnhadir.Text = "Guardar";
                btnAnhadir.Font = new Font(btnAnhadir.Font.FontFamily, btnAnhadir.Font.Size + 4);
                GestionarTodosLosControlesAnhadir(false);
            }
            else
            {
                if (txtTelefono.Text !="" && txtNombre.Text != "" && txtEmail.Text != "")
                {
                    c = new Contacto(txtTelefono.Text, txtNombre.Text, txtEmail.Text);

                    if (miAgenda.Anhadir(c) == 0)
                    {
                        lbContactos.Items.Add(c);
                        lbContactos.SelectedIndex = lbContactos.Items.Count - 1;

                    }
                    else 
                    {
                        MessageBox.Show("Ya existe un contacto con ese teléfono");
                        txtTelefono.Clear();
                        txtEmail.Clear();
                        txtNombre.Clear();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debes rellenar todos los campos");
                    txtTelefono.Clear();
                    txtEmail.Clear();
                    txtNombre.Clear();
                }

                GestionarTodosLosControlesAnhadir(true);
                btnAnhadir.Text = "Añadir";
                btnAnhadir.Font = new Font(btnAnhadir.Font.FontFamily, btnAnhadir.Font.Size - 4);

            }




        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //    Creamos una segunda lista que contenga sólo los elementos cuyo nombre o teléfono o email contengan el valor del texto convertido a minúscula y sin tildes

            //    Borramos el listBox
            //    Mostramos sólo los elementos de esta segunda lista

            List<Contacto> Lista2 = new List<Contacto>();

            
            if (txtFiltro.Text.Length >= 3)
            {
                foreach (Contacto c in miAgenda.Elementos)
                { 
                    if (c.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()) || c.Email.ToLower().Contains(txtFiltro.Text.ToLower()) || c.Telefono.ToLower().Contains(txtFiltro.Text.ToLower()))
                    {
                        Lista2.Add(c);
                    }
                }

                lbContactos.Items.Clear();
                foreach (Contacto c in Lista2)
                {
                    lbContactos.Items.Add(c);
                }


            } else if (txtFiltro.Text.Length == 0)
            {
                lbContactos.Items.Clear();
                foreach (Contacto c in miAgenda.Elementos)
                {
                    lbContactos.Items.Add(c);
                }
            }
            else
            {
                lbContactos.Items.Clear();
                lbContactos.Items.Add("El filtro funciona a partir de 3 caracteres");
            }

        }
    }
}
