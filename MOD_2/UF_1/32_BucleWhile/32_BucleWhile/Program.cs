using System;

namespace _32_BucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;

            //i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Crea un programa que pida números del 1 al 10,
            //y los sume, para salir el usuario debe introducir
            //un cero.

            int numero;
            int total=0;

            numero = -1;
            while (numero!=0)
            {
                Console.Write("Dime un número 1-10 (0 para salir): ");
                numero = byte.Parse(Console.ReadLine());
                total += numero;
            }


            Console.WriteLine("El total es: " + total);
            
        }
    }
}
