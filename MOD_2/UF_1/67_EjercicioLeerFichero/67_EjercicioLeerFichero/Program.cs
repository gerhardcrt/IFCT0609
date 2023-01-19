using System;
using System.IO;

namespace _67_EjercicioLeerFichero
{
    class Program
    {
        static void Main(string[] args)
        {
            //My.Computer.SpecialDirectories.Desktop --> VB
            string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DatosAlumnos.txt";
            StreamReader f = new StreamReader(rutaArchivo);
            String lineaActual;
            float numeroActual, menorNota = 10;

            while (!f.EndOfStream)
            {
                lineaActual = f.ReadLine();
                lineaActual = lineaActual.Replace('.', ',');
                numeroActual = float.Parse(lineaActual);
                if (numeroActual < menorNota) { menorNota = numeroActual; }
            }

            Console.WriteLine(menorNota);
            Console.WriteLine(ObtenerNotaMinimaFichero(rutaArchivo));

            f.Close();
        }

        static float ObtenerNotaMinimaFichero(string ruta)
        {
            StreamReader f;
            float[] arrayNotas;
            int numeroLineas=0;

            //while (!f.EndOfStream)
            //{
            //    _=f.ReadLine();
            //    numeroLineas++;
            //}
            //f.Close();
            numeroLineas = CalcularLineasFicheroTexto(ruta);

            arrayNotas = new float[numeroLineas];

            f = new StreamReader(ruta); //Necesito abrirlo de nuevo para comenzar desde el principio
            numeroLineas = 0;
            while (!f.EndOfStream)
            {
                arrayNotas[numeroLineas] = float.Parse(f.ReadLine());
                numeroLineas++;
            }
            f.Close();

            Array.Sort(arrayNotas);
            
            return arrayNotas[0];
        }

        static int CalcularLineasFicheroTexto(string ruta)
        {
            StreamReader f = new StreamReader(ruta);
            int numeroLineas = 0;

            while (!f.EndOfStream)
            {
                _ = f.ReadLine();
                numeroLineas++;
            }
            f.Close();

            return numeroLineas;

        }
    }
}
