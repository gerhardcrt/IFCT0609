using System;

namespace _46_ForAnidadosTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int niveles;

            Console.Write("Dime lo niveles que quieres: ");
            niveles = int.Parse(Console.ReadLine());
            Console.Clear();

            //triangulitos(niveles);
            //piramide(niveles);
            //piramide2(niveles);
            //Rombo(niveles);
            Cuadrado(niveles);

        }

        static void triangulitos(int numeroNiveles)
        {
            const char simbolo = '#';

            for (int i=0; i < numeroNiveles; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(simbolo);
                }

                Console.WriteLine();
            }
        }

        static void piramide(int numeroNiveles)
        {
            const char asterisco = '*';
            const char espacio = ' ';

            int cantidadEspacios, cantidadAsteriscos;

            cantidadAsteriscos = 1;
            cantidadEspacios = numeroNiveles-1;
            for (int i = 0; i < numeroNiveles; i++)
            {
                //dibujar espacios
                for (int j=0;j< cantidadEspacios; j++)
                {
                    Console.Write(espacio);
                }
                cantidadEspacios--;

                //dibujar asteriscos
                for (int j = 0; j < cantidadAsteriscos-1; j++)
                {
                    Console.Write(asterisco);
                }
                cantidadAsteriscos += 2;

                Console.Write(asterisco);

                //saltar linea
                Console.WriteLine();
            }
        }

        //versión mejorada
        static void piramide2(int numeroNiveles)
        {
            const char asterisco = '*';
            const char espacio = ' ';

            for (int i = 0; i < numeroNiveles; i++)
            {
                //dibujar espacios
                for (int j = 0; j < numeroNiveles-i-1; j++)
                {
                    Console.Write(espacio);
                }

                //dibujar asteriscos
                for (int j = 1; j < 2*i + 1; j++)
                {
                    Console.Write(asterisco);
                }

                Console.Write(asterisco);

                //saltar linea
                Console.WriteLine();
            }
        }

        static void parteAbajoRombo(int numeroNiveles)
        {
            const char asterisco = '*';
            const char espacio = ' ';

            int cantidadEspacios, cantidadAsteriscos;

            cantidadAsteriscos = numeroNiveles + 2;
            cantidadEspacios = 1;
            for (int i = 0; i < numeroNiveles; i++)
            {
                //dibujar espacios
                for (int j = 0; j < cantidadEspacios; j++)
                {
                    Console.Write(espacio);
                }
                cantidadEspacios++;

                //dibujar asteriscos
                for (int j = 0; j < cantidadAsteriscos; j++)
                {
                    Console.Write(asterisco);
                }
                cantidadAsteriscos -= 2;

                //saltar linea
                Console.WriteLine();
            }
        }

        static void Rombo(int niveles)
        {
            piramide(niveles);
            parteAbajoRombo(niveles);
        }

        static void Cuadrado(int alturas)
        {
            const char asterisco = '*';
            const char espacio = ' ';

            //Primera línea - altura x2
            for (int i = 0; i < (alturas * 2); i++) { Console.Write(asterisco); }
            Console.WriteLine();

            //parte central
            for (int i = 0; i < (alturas -2); i++) {
                Console.Write(asterisco);

                for (int j = 0; j < (alturas * 2 - 2); j++) { Console.Write(espacio); }

                Console.Write(asterisco);
                Console.WriteLine();
            }

            //Última línea - altura x2   
            for (int i = 0; i < (alturas * 2); i++) { Console.Write(asterisco); }
            Console.WriteLine();
        }
    }


    
}
