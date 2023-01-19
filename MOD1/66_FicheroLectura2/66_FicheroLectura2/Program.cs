using System;
using System.IO;

namespace _66_FicheroLectura2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader miFichero = new StreamReader("c:\\a\\archivo3.txt");
            string linea;
            int lineaBuscada, cantidadLineasArchivo=0;

            //Contar las lineas del fichero

           while (!miFichero.EndOfStream)
            {
                _ = miFichero.ReadLine();
                cantidadLineasArchivo++;
            }

            miFichero.Close();

            //Leer una línea concreta -Carlos Dixit-
            miFichero = new StreamReader("c:\\a\\archivo3.txt");

            Console.Write($"Dime que línea del fichero quieres leer (max {cantidadLineasArchivo}) : ");
            lineaBuscada = int.Parse(Console.ReadLine());
       
            for (int lineaActual = 0; lineaActual < lineaBuscada-1; lineaActual++)
            {
                _ = miFichero.ReadLine();
            }

            linea = miFichero.ReadLine();
            Console.WriteLine(linea);

            miFichero.Close();

            //Leer todo el fichero
            Console.WriteLine("---------------------");
            miFichero = new StreamReader("c:\\a\\archivo3.txt");

            _=miFichero.ReadLine();
            _ = miFichero.ReadLine();

            linea = miFichero.ReadToEnd();
            Console.WriteLine(linea);

            miFichero.Close();

        }
    }

}
