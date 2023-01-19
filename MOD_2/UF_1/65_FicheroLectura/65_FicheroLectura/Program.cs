using System;
using System.IO;

namespace _65_FicheroLectura
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader miFichero;
            string linea;
            int total =0;

            miFichero = new StreamReader("c:\\a\\archivo.txt");

            linea=miFichero.ReadLine();
            Console.WriteLine(linea);

            linea = miFichero.ReadLine();
            Console.WriteLine(linea);

            linea = miFichero.ReadLine();
            Console.WriteLine(linea);

            miFichero.Close();

            miFichero = new StreamReader("c:\\a\\archivo2.txt");
            
            linea = miFichero.ReadLine();
            total += int.Parse(linea);

            miFichero.ReadLine();

            linea = miFichero.ReadLine();
            total += int.Parse(linea);

            Console.WriteLine(total);

        }

        static string LimpiarFrase(string frase, char letraQuitar)
        {
            string fraseLimpia="";

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != letraQuitar)
                {
                    fraseLimpia += frase[i];
                }
            }

            return fraseLimpia;
        }
    }
}
