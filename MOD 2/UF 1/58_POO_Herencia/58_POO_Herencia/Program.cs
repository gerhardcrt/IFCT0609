using System;
using _57_POO_PrimerosPasos;


namespace _58_POO_Herencia
{
    class AlumnoAfd : _57_POO_PrimerosPasos.Alumno
    {
        float axuda;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Alumno unAlumno = new Alumno();
            AlumnoAfd OtroAlumno = new AlumnoAfd();

            OtroAlumno.nombre = "Jorge";
            OtroAlumno.notas[0] = 10;
            OtroAlumno.notas[1] = 7;
            OtroAlumno.notas[2] = 7;

            Console.WriteLine(OtroAlumno.EstaAprobado());



        }
    }
}
