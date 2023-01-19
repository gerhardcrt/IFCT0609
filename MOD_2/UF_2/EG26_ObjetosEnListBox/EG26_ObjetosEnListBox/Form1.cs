using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG26_ObjetosEnListBox
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno(txtNombre.Text, txtEmail.Text);

            lbAlumnos.Items.Add(a);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (lbAlumnos.SelectedIndex != -1)
            {
                lEmail.Text = ((Alumno)lbAlumnos.SelectedItem).MostrarEmail();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlumnoAFD UnAlumnoAfd = new AlumnoAFD("Jorge", "1234@jorge.com");

            MessageBox.Show(UnAlumnoAfd.ToString());

        }
    }

    public class Alumno
    {
        private string _nombre;
        private string _email;
        
        public Alumno(string n, string e)
        {
            _nombre = n;
            _email = e;
        }

        public override string ToString()
        {
            //return _nombre + " (" + _email + ")";
            return _nombre;
        }

        public string MostrarEmail() { return _email; }

    }

    public class AlumnoAFD: Alumno
    {
        public AlumnoAFD(string n, string e) : base(n, e) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
