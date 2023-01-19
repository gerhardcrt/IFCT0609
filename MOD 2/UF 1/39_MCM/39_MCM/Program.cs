using System;

namespace _39_MCM
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1, n2, mayor, resultado;

            //Console.Write("Dime el primer número: ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.Write("Dime el segundo número: ");
            //n2 = int.Parse(Console.ReadLine());

            //if (n1 > n2) { mayor = n1; } else { mayor = n2; }

            //for (resultado=mayor; resultado <= n1 * n2; resultado++)
            //{
            //    if ((resultado % n1 == 0) && (resultado % n2 == 0))
            //    {
            //        break;
            //    }
            //}

            //Mismo bucle que el anterior pero con While (usar sólo 1)
            //resultado = mayor;
            //while ((resultado % n1 != 0) || (resultado % n2 != 0))
            //{
            //    resultado++;
            //}

            //Console.WriteLine($"El MCM de {n1} y {n2} es {resultado}");

            //Mismo código usando la función MCM

            int n1, n2;

            Console.Write("Dime el primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El MCM de {n1} y {n2} es {Mcm(n1,n2)}");
            
        }

        //Esta función calcula el mínimo común múltiplo de 2 números enteros
        static int Mcm(int n1, int n2)
        {
            int mayor, resultado;

            if (n1 > n2) { mayor = n1; } else { mayor = n2; }

            for (resultado = mayor; resultado <= n1 * n2; resultado++)
            {
                if ((resultado % n1 == 0) && (resultado % n2 == 0))
                {
                    break;
                }
            }

            return resultado;
        }
    }
}
