using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BucleFor_Sumar10Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, numeroActual;

            total = 0;

            for (int repeticiones=0; repeticiones<5; repeticiones++)
            {
                Console.Write("Dime el número (" + (repeticiones+1).ToString() +"): ");
                numeroActual = int.Parse(Console.ReadLine());
                total += numeroActual; //total = total + numeroActual;
            }

            Console.Write("El total es: " + total.ToString());

            Console.ReadKey();
        }
    }
}
