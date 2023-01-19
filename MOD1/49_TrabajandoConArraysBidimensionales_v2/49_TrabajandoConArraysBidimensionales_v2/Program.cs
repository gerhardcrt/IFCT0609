using System;

namespace _49_TrabajandoConArraysBidimensionales_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notasAlumnos = new int[,]
            { { 8, 6, 5, 3, 5}, { 7, 8, 9, 10, 5 }, { 4,4,6,6, 8}, {10,10,10,10, 10} };

            float media;
            int total;
            int numeroAlumno; //lo voy a usar para sacar la media de sólo 1 alumno

            //recorre toda la matriz y saca todas las medias
            for (int fila = 0; fila <= notasAlumnos.GetUpperBound(0); fila++)
            {
                total = 0;
                for (int columna = 0; columna <= notasAlumnos.GetUpperBound(1); columna++)
                {
                    total += notasAlumnos[fila, columna];
                }
                //necesito convertir a float para que no redondee a entero
                media = total / (float)(notasAlumnos.GetUpperBound(1)+1);
                Console.WriteLine($"La media del alumno {fila+1} es: {media}");

            }

            Console.WriteLine();

            //Sacar la media de un sólo alumno
            Console.Write("Dime el alumno del que quieres sacar la media: ");
            numeroAlumno = int.Parse(Console.ReadLine());

            total = 0;
            for (int columna = 0; columna <= notasAlumnos.GetUpperBound(1); columna++)
            {
                //Le resto 1 al alumno para ir a su posición en el array
                total += notasAlumnos[numeroAlumno - 1, columna];
            }
            media = total / (float)(notasAlumnos.GetUpperBound(1) + 1);
            Console.WriteLine($"La media del alumno es: {media}");



        }
    }
}
