using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliares
{
    class Aleatorios
    {
        public static int[] GenerarArrayAleatorios(int cantidad, int valorMin, int valorMax)
        {
            int[] resultado = new int[cantidad];
            Random al = new Random();
            int numero;
                 
            if (cantidad<2 || valorMin>valorMax)
            {
                //throw new Exception("Tio no me vaciles");
                return null;
            }
            else
            {
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = -9999999;
                }

                for (int posicion = 0; posicion < resultado.Length; posicion++)
                {
                    do
                    {   //generas un numero aletorio, mientras esté repetido en el array
                        numero = al.Next(valorMin, valorMax + 1);
                    } while (ExisteNumeroEnArray(resultado, numero));

                    resultado[posicion] = numero;
                }


            }

            return resultado;
        }

        private static bool ExisteNumeroEnArray(int[] arr, int valorBuscado)
        {

            foreach(int valorActual in arr)
            {
                if(valorActual == valorBuscado) { return true; }
            }

            return false;
        }

        public static int[] GenerarArrayAleatorios2(int cantidad, int valorMin, int valorMax)
        {
            var colleccion = new HashSet<int>(cantidad);
            Random al = new Random();

            while (colleccion.Count < cantidad)
            {
                colleccion.Add(al.Next(valorMin, valorMax+1));
            }

            return colleccion.ToArray();


        }


    }
}
