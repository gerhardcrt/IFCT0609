using System;

namespace _34_CalcularSiPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor;
            bool esPrimo = true;

            Console.Write("Dime un número: ");
            numero = int.Parse(Console.ReadLine());

            //for (divisor=2;divisor<numero; divisor++)
            //{
            //    if (numero % divisor == 0)
            //    {
            //        esPrimo = false;
            //        break;
            //    }
            //}

            divisor = 2;
            while (divisor < numero)
            {
                if (numero % divisor == 0)
                {
                    esPrimo = false;
                    break;
                }
                divisor++;
            }

            if (esPrimo)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No no no");
            }


        }
    }
}
