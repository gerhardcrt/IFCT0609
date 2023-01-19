using System;

namespace _46a
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int niveles;

                Console.Write("Dime lo niveles que quieres: ");
                niveles = int.Parse(Console.ReadLine());
                Console.Clear();

                triangulitos(niveles);
            }

            static void triangulitos(int numeroNiveles);
            

            const char asterisco = '*';
            const char espacio = ' ';

            int numeroNiveles = 0;
            for (int i = 0; i < numeroNiveles; i++)
            {

            Console.WriteLine(new String(' ', numeroNiveles - i - 1) + new String('*', i + i + 1));
            }

            Console.ReadKey();
        }
    }

}