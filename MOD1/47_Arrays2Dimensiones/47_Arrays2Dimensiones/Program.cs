using System;

namespace _47_Arrays2Dimensiones
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] calificaciones = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 4, 5, 6 } };
            int[,] notas = new int[3, 2];

            Console.WriteLine(calificaciones[1, 0]);
            Console.WriteLine(calificaciones[0, 2]);

            notas[0, 0] = 10;
            notas[0, 1] = 3;

            notas[1, 0] = 6;
            notas[1, 1] = 7;

            notas[2, 0] = 9;
            notas[2, 1] = 10;

            Console.WriteLine("----------------");

            for (int filas=0;filas<3; filas++)
            {
                for (int columnas = 0; columnas < 2; columnas++)
                {
                    Console.Write(notas[filas, columnas] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------");

            for (int filas = 0; filas <= calificaciones.GetUpperBound(0); filas++)
            {
                for (int columnas = 0; columnas <= calificaciones.GetUpperBound(1); columnas++)
                {
                    Console.Write(calificaciones[filas, columnas] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
