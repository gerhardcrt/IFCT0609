using System;

namespace _62_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";

            Console.WriteLine(cadena.Length);
            Console.WriteLine(cadena[3]);

            Console.WriteLine("-------------");
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }

            Console.WriteLine("-------------");
            foreach (char letra in cadena)
            {
                Console.WriteLine(letra);
            }


        }
    }
}
