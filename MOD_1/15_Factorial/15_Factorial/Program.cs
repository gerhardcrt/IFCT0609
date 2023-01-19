using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, repeticiones;
            int total = 1;
            int total2 = 1;

            Console.Write("Dime un número: ");
            numero = int.Parse(Console.ReadLine());

            //Opcion 2
            for (int numeroActual = numero; numeroActual > 1; numeroActual--)
            {
                total2 = total2 * numeroActual;
            }

            Console.WriteLine("El factorial es: " + total2);

            repeticiones = numero;
            //Aquí se realiza el factorial
            for (int w = 0; w < repeticiones; w += 1)
            {
                total = total * numero;
                numero -= 1;
            }

            Console.WriteLine("El factorial es: " + total);

            Console.ReadKey();
        }
    }
}
