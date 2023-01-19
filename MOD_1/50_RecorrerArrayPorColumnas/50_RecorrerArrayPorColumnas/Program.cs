using System;

namespace _50_RecorrerArrayPorColumnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notasAlumnos = new int[,]
            { { 6, 6, 5, 3, 5}, { 6, 8, 9, 10, 5 }, { 4,4,6,6, 8}, {4,10,10,10, 10} };

            float media;
            int total;

            //Voy a recorrer por columnas
            for (int columna = 0; columna <= notasAlumnos.GetUpperBound(1); columna++)
            {
                total = 0;
                for (int fila = 0; fila <= notasAlumnos.GetUpperBound(0); fila++)
                {
                    total += notasAlumnos[fila, columna];
                }
                //necesito convertir a float para que no redondee a entero
                media = total / (float)(notasAlumnos.GetUpperBound(0) + 1);
                Console.WriteLine($"La media del examen {columna + 1} es: {media}");

            }

            



        }
    }
}
