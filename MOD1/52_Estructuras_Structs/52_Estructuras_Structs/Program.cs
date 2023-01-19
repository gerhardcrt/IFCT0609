using System;

namespace _52_Estructuras_Structs
{
    class Program
    {
        struct DatosAlumno
        {
            public string Nombre;
            public int edad;
            public float[] notas;
        }

        static void Main(string[] args)
        {
            DatosAlumno alumno1, alumno2;
            DatosAlumno[] conjuntoAlumnos = new DatosAlumno[2];

            alumno1.Nombre = "Jorge";
            alumno1.edad = 23;
            alumno1.notas = new float[] { 10, 5, 6 };

            alumno2.Nombre = "María";
            alumno2.edad = 55;
            alumno2.notas = new float[] { 5, 7, 4 };

            Console.WriteLine($"El nombre del primer alumno es: {alumno1.Nombre}");
            Console.WriteLine($"La media de {alumno1.Nombre} es: {CalcularMediaAlumno(alumno1)}");

            Console.WriteLine("-----------------");

            conjuntoAlumnos[0] = alumno1;
            conjuntoAlumnos[1] = alumno2;

            foreach(DatosAlumno al in conjuntoAlumnos)
            {
                Console.WriteLine($"La media de {al.Nombre} es: {CalcularMediaAlumno(al)}");
            }


        }

        static float CalcularMediaAlumno(DatosAlumno a)
        {
            float media, total=0;
            
            for (int i=0; i <= a.notas.GetUpperBound(0); i++)
            {
                total += a.notas[i];
            }
            media = total / (float)(a.notas.GetUpperBound(0)+1);
            return media;

        }
    }
}
