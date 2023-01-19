using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_11_PuntuacionesEurovision
{
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
