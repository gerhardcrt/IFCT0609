using System;

namespace _37_FuncionesYProcedimientos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 50;

            Console.WriteLine("Hello World!");
            Rayita();
            Console.WriteLine("Esto es otro texto");
            Rayita2();
            Rayita3(20);
            Rayita3(5);
            Rayita3(cantidad);
            Rayita4(10,'#');
        }

        static void Rayita()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        static void Rayita2()
        {
            char simbolo = '-';
            int numeroRayitas = 50;

            Console.WriteLine();
            for (int i = 0; i < numeroRayitas; i++)
            {
                Console.Write(simbolo);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Rayita3(int numeroRayas)
        {
            char simbolo = '-';
            //int numeroRayas;
            
            Console.WriteLine();
            for (int i = 0; i < numeroRayas; i++)
            {
                Console.Write(simbolo);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Rayita4(int numeroRayas, char simbolo)
        {
            //char simbolo = '-';
            //int numeroRayas;

            Console.WriteLine();
            for (int i = 0; i < numeroRayas; i++)
            {
                Console.Write(simbolo);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
