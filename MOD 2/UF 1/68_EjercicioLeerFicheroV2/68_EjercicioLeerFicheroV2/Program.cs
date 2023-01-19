using System;
using System.IO;

namespace _68_EjercicioLeerFicheroV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DatosAlumnos2.txt";
            StreamReader f = new StreamReader(rutaArchivo);
            String lineaActual, nombreUsuarioMenorNota="";
            float numeroActual, menorNota = 10;
            string[] arrayLinea;

            while (!f.EndOfStream)
            {
                lineaActual = f.ReadLine();
                lineaActual = lineaActual.Replace('.', ',');
                
                //divido línea en un array
                arrayLinea = lineaActual.Split(';');

                numeroActual = float.Parse(arrayLinea[1]);
                if (numeroActual < menorNota) { 
                    menorNota = numeroActual;
                    nombreUsuarioMenorNota = arrayLinea[0];
                
                }
            }

            Console.WriteLine(nombreUsuarioMenorNota + ": " + menorNota);


            f.Close();
        }
    }
}
