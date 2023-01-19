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

using Clases;

namespace M3_01_LeerCsv
{
    public partial class Form1 : Form
    {
        //Aquí me voy a crear una estrucutura de datos que pueda almacenar usuarios

        Usuario[] listaUsuario;
        int posicionActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar todos los datos del CSV en un Array de Usuarios
            //Recuperar el Objeto de la primera posición del Array y mostrar los datos en el Formulario
            //Fijar la posición actual en el Array como 0


            listaUsuario = Usuario.CargarDatos("archivo.csv");
            posicionActual = 0;

            MostrarDatos(listaUsuario[posicionActual]);

        }

        private void MostrarDatos(Usuario u)
        {
            //Función auxiliar: Sacar los datos del Objeto usuario y mostrarlos en el Formulario

            txtNombre.Text = u.nombre;
            txtApellidos.Text = u.apellido;
            txtLocalidad.Text = u.localidad;
            nudEdad.Value = u.edad;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Si quedan elementos en el Array,
            //Aumentar la posición en 1
            //Recuperar el Objeto de la posición actual y mostrar los datos en el Formulario

            if (posicionActual<listaUsuario.Length-1) 
            {
                posicionActual++;
                MostrarDatos(listaUsuario[posicionActual]);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //Si no estamos en el elemento de posición 0,
            //Disminuir la posición en 1
            //Recuperar el Objeto de la posición actual y mostrar los datos en el Formulario

            if (posicionActual > 0)
            {
                posicionActual--;
                MostrarDatos(listaUsuario[posicionActual]);
            }
        }

      
    }
}
