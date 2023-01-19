using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_10_PrevioPosicionarEnListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

            //listBox1.Sorted = true; //Este siempre ordena de mayor a menor
            OrdenarListBox(listBox1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Grupo g1 = new Grupo("Tanxugueiras");
            Grupo g2 = new Grupo("Ryden",100);
            Grupo g3 = new Grupo("Chanel");
            Grupo g4 = new Grupo("Rigoberta Bandini",300);

            listBox2.Items.Add(g1);
            listBox2.Items.Add(g2);
            listBox2.Items.Add(g3);
            listBox2.Items.Add(g4);

            OrdenarListBox2();

         }

        private void OrdenarListBox(ListBox l)
        {
            int[] arrayDatos = new int[l.Items.Count];
            int posicion = 0;

            foreach (object dato in l.Items)
            {
                arrayDatos[posicion] = int.Parse(dato.ToString());
                posicion++;
            }

            Array.Sort(arrayDatos);
            Array.Reverse(arrayDatos);

            l.Items.Clear();

            foreach (int i in arrayDatos)
            {
                l.Items.Add(i);
            }
            
        }

        private void OrdenarListBox2()
        {
            List<Grupo> participantes = new List<Grupo>();

            foreach (object obj in listBox2.Items)
            {
                participantes.Add((Grupo)obj);
            }

            participantes.Sort();

            listBox2.Items.Clear();
            foreach (Grupo g in participantes)
            {
                listBox2.Items.Add(g);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado;
            grupoSeleccionado = (Grupo)listBox2.SelectedItem;

            grupoSeleccionado.puntuacion += int.Parse(textBox2.Text);
            OrdenarListBox2();
        }
    }


    public class Grupo : IComparable
    {
        public string Nombre;
        public int puntuacion;

        public Grupo(string n)
        {
            Nombre = n;
            puntuacion = 0;
        }

        public Grupo(string n, int p)
        {
            Nombre = n;
            puntuacion = p;
        }

        public int CompareTo(object obj)
        {
            return ((Grupo)obj).puntuacion - puntuacion;
        }

        public override string ToString()
        {
            return Nombre + " " + puntuacion;
        }
    }

 
}
