using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_11_PuntuacionesEurovision
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Grupo g1 = new Grupo("Tanxugueiras");
            Grupo g2 = new Grupo("Ryden");
            Grupo g3 = new Grupo("Chanel");
            Grupo g4 = new Grupo("Rigoberta Bandini");
            Grupo g5 = new Grupo("Blanca Paloma");
            Grupo g6 = new Grupo("Varry Brava");
            Grupo g7 = new Grupo("Xeinn");
            Grupo g8 = new Grupo("Gonzalo Herminda");

            lbParticipantes.Items.Add(g1);
            lbParticipantes.Items.Add(g2);
            lbParticipantes.Items.Add(g3);
            lbParticipantes.Items.Add(g4);
            lbParticipantes.Items.Add(g5);
            lbParticipantes.Items.Add(g6);
            lbParticipantes.Items.Add(g7);
            lbParticipantes.Items.Add(g8);

            foreach(object obj in lbParticipantes.Items)
            {
                cbSeleccionarParticipante.Items.Add(((Grupo)obj).Nombre);
            }

            cbSeleccionarParticipante.Sorted = true;
        }

        private void ClicarEnPuntuacion(object sender, EventArgs e)
        {
            Grupo grupoActual;
            string cbSeleccionado;

            if (cbSeleccionarParticipante.SelectedIndex != -1)
            {

                cbSeleccionado = cbSeleccionarParticipante.SelectedItem.ToString();

                //recorrer el listbox de participantes
                foreach (object obj in lbParticipantes.Items)
                {
                    grupoActual = (Grupo)obj;


                    if (grupoActual.Nombre == cbSeleccionado)
                    {
                        grupoActual.puntuacion += int.Parse(((Button)sender).Text);
                    }
                }
                OrdenarListBox(lbParticipantes);
            }
                

        }

        private void OrdenarListBox(ListBox lb)
        {
            List<Grupo> participantes = new List<Grupo>();

            foreach (object obj in lb.Items)
            {
                participantes.Add((Grupo)obj);
            }

            participantes.Sort();

            lb.Items.Clear();
            foreach (Grupo g in participantes)
            {
                lb.Items.Add(g);
            }

        }
    }
}
