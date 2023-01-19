using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_28_PequenhoDetalleCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno a1 = new Alumno("Chus", 8.75m);
            Alumno a2 = new Alumno("Toño", 3.0m);
            Alumno a3 = new Alumno("Gabri", 9.99m);

            List<Alumno> listaClase = new List<Alumno> { a1, a2, a3 };

            //foreach (Alumno item in listaClase)
            //{
            //    MessageBox.Show(item.Nombre);
            //}

            listaClase.ForEach(al => MessageBox.Show(al.Nombre));

        }

        
    }

    public class Alumno
    {
        public string Nombre { get; set; }
        public decimal NotaFinal { get; set; }

        public Alumno(string n, decimal not)
        {
            Nombre = n;
            NotaFinal = not;
        }
    }
}
