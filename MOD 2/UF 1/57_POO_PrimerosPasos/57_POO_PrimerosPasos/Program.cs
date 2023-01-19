using System;

namespace _57_POO_PrimerosPasos
{

    //Hacer un programa que pida el nombre y las notas (3) de 5 alumnos
    //y muestre quien tiene la media más alta y más baja
    class Program
    {
        static void Main(string[] args)
        {
            //Defino variables para 5 alumnos
            //string NombreAlumno1, NombreAlumno2, NombreAlumno3, NombreAlumno4, NombreAlumno5;
            //string[] nombresAlumnos = new string[5];

            //int[] notasAlumno1 = new int[3];
            //int[] notasAlumno2 = new int[3];
            //int[] notasAlumno3 = new int[3];
            //int[] notasAlumno4 = new int[3];
            //int[] notasAlumno5 = new int[3];
            //int[,] notasAlumnos = new int[5, 3];

            //Console.Write("Dime el nombre el alumno1: ");
            //NombreAlumno1 = Console.ReadLine();

            //-------------------------------------------------
            const int CANTIDAD_ALUMNOS = 3;

            Alumno[] MisAlumnos = new Alumno[CANTIDAD_ALUMNOS];
            float mayor=0, menor=10, mediaActual;
            Alumno MejorAlumno, PeorAlumno;

            

            MejorAlumno = new Alumno();
            PeorAlumno = new Alumno();

            for (int cantidad = 0; cantidad < MisAlumnos.Length; cantidad++)
            {
                MisAlumnos[cantidad] = new Alumno();
                MisAlumnos[cantidad].LeerDatosAlumno();
            }

            for (int j = 0; j < MisAlumnos.Length; j++)
            {
                mediaActual = MisAlumnos[j].CalcularMedia();

                if (MisAlumnos[j].EstaAprobado())
                {
                    Console.WriteLine($"{MisAlumnos[j].nombre} has aprobado.");
                }
                else
                {
                    Console.WriteLine($"{MisAlumnos[j].nombre} has suspendido.");
                }

                //if (mediaActual > mayor) { MejorAlumno=MisAlumnos[j]; mayor = mediaActual; }
                //if (mediaActual < menor) { PeorAlumno= MisAlumnos[j]; menor = mediaActual; }
            }

            //Console.WriteLine($"La mayor media es: {mayor}, que pertene a {MejorAlumno.nombre}");
            //Console.WriteLine($"La menor media es: {menor} , que pertene a {PeorAlumno.nombre}");

        }
    }
}
