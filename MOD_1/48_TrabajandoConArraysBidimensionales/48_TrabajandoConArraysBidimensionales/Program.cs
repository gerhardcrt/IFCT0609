using System;

namespace _48_TrabajandoConArraysBidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notasAlumnos = new int[,]
            { { 8, 6, 5, 3 }, { 7, 8, 9, 10 }, { 4,4,6,6} };

            float media;
            int total;
            int numeroAlumno; //lo voy a usar para sacar la media de sólo 1 alumno

            //recorre toda la matriz y saca todas las medias
            for (int fila = 0; fila <= 2; fila++)
            {
                total = 0;
                for (int columna = 0; columna <= 3; columna++)
                {
                    total += notasAlumnos[fila, columna];
                }
                media = total / 4f;
                Console.WriteLine($"La media del alumno es: {media}");

            }
            
            Console.WriteLine();

            //Sacar la media de un sólo alumno
            Console.Write("Dime el alumno del que quieres sacar la media: ");
            numeroAlumno = int.Parse(Console.ReadLine());

            total = 0;
            for (int columna = 0; columna <= 3; columna++)
            {
                //Le resto 1 al alumno para ir a su posición en el array
                total += notasAlumnos[numeroAlumno-1, columna];
            }
            media = total / 4f;
            Console.WriteLine($"La media del alumno es: {media}");



        }
    }
}
