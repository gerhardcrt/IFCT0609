using System;

namespace _35_fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;
            int n1 = 0;
            int n2 = 0;
            int posicion = 0;

            Console.WriteLine("Dime n1: ");
            int.Parse(Console.ReadLine());

            Console.WriteLine("Dime n2: ");
            int.Parse(Console.ReadLine());

            n = n2 - n1;
            
            if (n == 1)
            Console.WriteLine("posicion= 1");

            for ( i = 2; i <= n; i++)

            {
              posicion = n;

            }
              Console.WriteLine("la posicion es: {n}");




        }
       
    }
}
