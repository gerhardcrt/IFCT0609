using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_POO_PrimerosPasos
{
    class Alumno
    {
        public string nombre;
        public int[] notas;

        //Constructor
        public Alumno()
        {
            notas = new int[3];
        }

        public void LeerDatosAlumno()
        {
            Console.Write("Dime el nombre el alumno: ");
            nombre = Console.ReadLine();

            for (int i = 0; i <= notas.GetUpperBound(0); i++)
            {
                Console.Write($"Dime la nota ({i+1}): ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public float CalcularMedia()
        {
            int total = 0;
            //float media; El return es la media, pero ahorro la variable

            for (int i = 0; i <= notas.GetUpperBound(0); i++)
            {
                total += notas[i];
            }

            return total / (float)notas.Length;
        }

        public bool EstaAprobado()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i]<7) { return false; }
            }

            return true;
        }
    }
}
