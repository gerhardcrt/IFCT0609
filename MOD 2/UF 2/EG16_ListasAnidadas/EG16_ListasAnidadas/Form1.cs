using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG16_ListasAnidadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Equipo
        {
            public string Nombre;

            public Equipo() { }
            public Equipo(string n)
            {
                Nombre = n;
            }
        }
           
        class CabezaSerie:Equipo
        {
            public CabezaSerie(string n) : base(n) { }
            public List<Equipo> posiblesRivales;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var ListaCabezas = new List<CabezaSerie> { };
            var Rivales = new List<Equipo> { };

            Random aleatorio = new Random();
            Equipo RivalEscogido, RivalAEliminar;
            CabezaSerie CabezaSerieEscogido;

            string SalidaRivales="";

            #region "Inicializacion Datos"

            CabezaSerie Ajax = new CabezaSerie("Ajax");
            CabezaSerie Bayern = new CabezaSerie("Bayer de Munich");
            CabezaSerie LiverPool = new CabezaSerie("LiverPool");
            CabezaSerie City = new CabezaSerie("Manchester City");
            CabezaSerie United = new CabezaSerie("Manchester United");
            CabezaSerie RealMadrid = new CabezaSerie("Real Madrid");
            CabezaSerie Juve = new CabezaSerie("Juventus de Turin");
            CabezaSerie Lile = new CabezaSerie("Lile");

            Equipo Psg = new Equipo("Paris Saint Germanin");
            Equipo Sporting = new Equipo("Sporting de Lisboa");
            Equipo Atletico = new Equipo("Atlético de Madrid");
            Equipo Inter = new Equipo("Inter de Milan");
            Equipo Chelsea = new Equipo("Chelsea");
            Equipo Villareal = new Equipo("Villareal");
            Equipo Benfica = new Equipo("Benfica");
            Equipo Salzburgo = new Equipo("Salzburgo");

            //Rivales = new List<Equipo> {Psg,Sporting,Atletico,Inter,Chelsea,Villareal,Benfica,Salzburgo};
            Rivales = new List<Equipo> { Psg, Atletico, Inter, Chelsea, Villareal, Benfica, Salzburgo };
            Ajax.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Psg, Sporting, Atletico, Inter, Chelsea, Villareal, Salzburgo };
            Bayern.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Psg, Sporting, Inter, Villareal, Benfica, Salzburgo };
            LiverPool.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Sporting, Atletico, Inter, Villareal, Benfica, Salzburgo };
            City.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Psg, Sporting, Atletico, Inter, Benfica, Salzburgo };
            United.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Psg, Sporting, Chelsea, Benfica, Salzburgo };
            RealMadrid.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Psg, Sporting, Atletico, Villareal, Benfica, Salzburgo };
            Juve.posiblesRivales = Rivales;

            Rivales = new List<Equipo> { Sporting, Atletico, Inter, Chelsea, Villareal, Benfica };
            Lile.posiblesRivales = Rivales;

            ListaCabezas.Add(Ajax);
            ListaCabezas.Add(Bayern);
            ListaCabezas.Add(LiverPool);
            ListaCabezas.Add(City);
            ListaCabezas.Add(United);
            ListaCabezas.Add(RealMadrid);
            ListaCabezas.Add(Juve);
            ListaCabezas.Add(Lile);

            #endregion

            while (ListaCabezas.Count > 0)
            {
               CabezaSerieEscogido = ListaCabezas[aleatorio.Next(0, ListaCabezas.Count)];

               //Mostrar los rivales posibles
               foreach(Equipo eq in CabezaSerieEscogido.posiblesRivales)
                {
                    SalidaRivales += eq.Nombre + " / ";
                }
                MessageBox.Show("Rivales posibles de " + CabezaSerieEscogido.Nombre + ": " + SalidaRivales);
                SalidaRivales = "";

               RivalEscogido = CabezaSerieEscogido.posiblesRivales[aleatorio.Next(0, CabezaSerieEscogido.posiblesRivales.Count)];

               MessageBox.Show(CabezaSerieEscogido.Nombre + " / " + RivalEscogido.Nombre);

               //Eliminar Rival de todas las lista
               foreach(CabezaSerie c in ListaCabezas)
                {
                    if (c.posiblesRivales.Contains(RivalEscogido))
                    {
                        c.posiblesRivales.Remove(RivalEscogido);
                    }
                }

                ListaCabezas.Remove(CabezaSerieEscogido);

                //Si hay algún Cabeza con un solo Rival lo muestro y lo elimino
                for (int i=ListaCabezas.Count-1;i>=0;i--)
                {
                    if (ListaCabezas[i].posiblesRivales.Count==1)
                    {
                        MessageBox.Show(ListaCabezas[i].Nombre + " / " + ListaCabezas[i].posiblesRivales[0].Nombre);
                        RivalAEliminar = ListaCabezas[i].posiblesRivales[0];
                        ListaCabezas.Remove(ListaCabezas[i]);

                        //Elimino esta opción
                        foreach (CabezaSerie c2 in ListaCabezas)
                        {
                            if (c2.posiblesRivales.Contains(RivalAEliminar))
                            {
                                c2.posiblesRivales.Remove(RivalAEliminar);
                            }
                        }                       
                    }
                }
            }
        }
    }
}
