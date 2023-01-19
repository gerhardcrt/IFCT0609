using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculoAnhoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int anho;
            bool esBisiesto = false;

            Console.Write("Dieme el año: ");
            anho = int.Parse(Console.ReadLine());

            //if (anho % 4 == 0) { esBisiesto = true; }
            //if (anho % 100 == 0) { esBisiesto = false; }
            //if (anho % 400 == 0) { esBisiesto = true; }

            //if (esBisiesto)
            //{
            //    Console.WriteLine("Bisiesto");
            //}
            //else
            //{
            //    Console.WriteLine("No no no");
            //}

            if ( anho % 4 == 0 && (anho % 100 !=0 || anho % 400 ==0))
            {
                Console.WriteLine("Bisiesto");
            }
            else
            {
                Console.WriteLine("No no no");
            }

            Console.ReadKey();

        }
    }
}
