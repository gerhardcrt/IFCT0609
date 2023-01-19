using System;

namespace _55_RepasoEstructs_LeerPorTeclado
{
    class Program
    {
        struct Alumno
        {
            public string Nombre;
            public int edad;
            public float[] notas;
        }
        static void Main(string[] args)
        {
           // Alumno UnAlumno;
            Alumno[] ClaseADFStgo = new Alumno[3];
            Alumno[] ClaseAFDNueva;

            Console.Write("Cuanto alumnos quieres dar de alta?: ");
            ClaseAFDNueva = ObtenerDatosClase(int.Parse(Console.ReadLine()));

            for (int i = 0; i< 3; i++)
            {
                //Console.Write("Dime el nombre del alumno: ");
                //UnAlumno.Nombre = Console.ReadLine();

                //Console.Write("Dime la edad del alumno: ");
                //UnAlumno.edad = int.Parse(Console.ReadLine());

                //UnAlumno.notas = new float[3];
                //for (int repeticion = 0; repeticion <= UnAlumno.notas.Length - 1; repeticion++)
                //{
                //    Console.Write($"Dime la nota {repeticion + 1} del alumno: ");
                //    UnAlumno.notas[repeticion] = float.Parse(Console.ReadLine());
                //}

                ClaseADFStgo[i] = ObtenerDatosAlumno();

            }
        }
        static Alumno[] ObtenerDatosClase(int cantidadAlumnos)
        {            
            Alumno[] ClaseAfdActual = new Alumno[cantidadAlumnos];

            for (int i= 0; i < cantidadAlumnos; i++)
            {
                ClaseAfdActual[i] = ObtenerDatosAlumno();
            }

            return ClaseAfdActual;
        }

        static Alumno ObtenerDatosAlumno()
        {
            Alumno UnAlumno;

            Console.Write("Dime el nombre del alumno: ");
            UnAlumno.Nombre = Console.ReadLine();

            Console.Write("Dime la edad del alumno: ");
            UnAlumno.edad = int.Parse(Console.ReadLine());

            UnAlumno.notas = new float[3];
            for (int repeticion = 0; repeticion <= UnAlumno.notas.Length - 1; repeticion++)
            {
                Console.Write($"Dime la nota {repeticion + 1} del alumno: ");
                UnAlumno.notas[repeticion] = float.Parse(Console.ReadLine());
            }

            return UnAlumno;

        }

    }
}
