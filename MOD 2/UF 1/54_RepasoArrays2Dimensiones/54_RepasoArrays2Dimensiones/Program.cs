using System;

namespace _54_RepasoArrays2Dimensiones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] datos = new int[2, 3];

            //aquí leo los datos
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= datos.GetUpperBound(1); j++)
                {
                    Console.Write($"Dame el valor de la posicion ({i},{j}): ");
                    datos[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            //aquí muestro los datos leídos
            for (int i = 0; i <= datos.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= datos.GetUpperBound(1); j++)
                {
                    Console.Write($"({i},{j}): {datos[i,j]} \t");
                }
                Console.WriteLine();
            }




        }
    }
}
