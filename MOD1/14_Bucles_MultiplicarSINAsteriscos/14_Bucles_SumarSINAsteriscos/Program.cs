using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Bucles_SumarSINAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, total=0;

            Console.Write("Dime el primer operando de la multiplicación: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo operando de la multiplicación: ");
            numero2 = int.Parse(Console.ReadLine());

            if( numero1==0 && numero2 == 0)
            {
                Console.Write("El resultado de multiplicar 0 x 0 es INDETERMINADO");
            }
            else
            {
                for (int i = 1; i <= numero2; i++)
                {
                    total += numero1;
                }
                Console.Write("El resultado de multiplicar " + numero1.ToString() + " x " + numero2.ToString() + " es: " + total);

            }


            Console.ReadKey();
        }
    }
}
