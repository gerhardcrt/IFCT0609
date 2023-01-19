using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace M3_03_EscribirUnCSV
{
    public partial class Form1 : Form
    {
        private bool telefonoCorrecto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxProvincia.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtApellido.Text == "" || cbxProvincia.SelectedItem.ToString() == "" || !telefonoCorrecto)
            {
                MessageBox.Show("Debe de rellenar todos los campos");
            }
            else
            {
                GuardaDatosEnCSV();
            }
        }

        private void GuardaDatosEnCSV()
        {
            string nombre, apellidos, provincia, edad, tel;
            string cadenaEscribir;
            StreamWriter ficheroEsc;

            nombre = txtNombre.Text;
            apellidos = txtApellido.Text;
            provincia = cbxProvincia.SelectedItem.ToString();
            edad = nudEdad.Value.ToString();
            tel = txtTelefono.Text;


            cadenaEscribir = tel + ";" + nombre + ";" + apellidos + ";" + edad + ";" + provincia;
            
            ficheroEsc = new StreamWriter("datos.csv", true, System.Text.Encoding.Default);
            ficheroEsc.WriteLine(cadenaEscribir);
            ficheroEsc.Close();

            txtNombre.Clear();
            txtApellido.Clear();
            cbxProvincia.SelectedIndex = 0;
            nudEdad.Value = 18;
            txtTelefono.Clear();
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            //Un tel no es válido si no tiene 9 dígitos exactamente o no comienzo por 6 o 7

            if (txtTelefono.Text.Length==9 && (txtTelefono.Text[0] == '6' || txtTelefono.Text[0]=='7'))
            {
                errpNumeroTelefono.Clear();
                telefonoCorrecto = true;
            }
            else
            {
                errpNumeroTelefono.SetError(txtTelefono, "Número incorrecto");
                telefonoCorrecto = false;
            }
            
        }
    }
}
