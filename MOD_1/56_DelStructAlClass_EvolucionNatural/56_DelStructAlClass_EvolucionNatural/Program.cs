using System;

namespace _56_DelStructAlClass_EvolucionNatural
{
    class Alumno
    {
        public string Nombre;
        public string DNI;
        public int edad;
        public float[] notas;

        public Alumno()
        {
            notas = new float[3];
        }

        public void MostrarDatosAlumno()
        {

            Console.WriteLine($"El alumno se llama {Nombre}");
            Console.WriteLine($"tiene {edad} años");
            Console.Write("Y sus notas son: ");

            for (int i = 0; i <= notas.GetUpperBound(0); i++)
            {
                Console.Write(notas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public float CalcularMedia()
        {
            float total=0;

            for (int i=0; i <= notas.GetUpperBound(0); i++)
            {
                total += notas[i];
            }

            return total / (float)notas.Length;

        }

        public void GuardarAlumno() { }

    }

    class Program
    {
        struct stAlumno
        {
            public string Nombre;
            public int edad;
            public float[] notas;
        }

        static void Main(string[] args)
        {
            //stAlumno UnAlumno, otroAlumno;

            //UnAlumno = ObtenerDatosAlumno();
            //Console.WriteLine();
            //MostrarDatosAlumno(UnAlumno);

            //otroAlumno = ObtenerDatosAlumno();
            //Console.WriteLine();
            //MostrarDatosAlumno(otroAlumno);

            //-------------------------

            Alumno MiAlumno = new Alumno();

            MiAlumno.Nombre = "Marta";
            MiAlumno.edad = 35;
            
            MiAlumno.notas[0] = 10;
            MiAlumno.notas[1] = 5;
            MiAlumno.notas[2] = 8;

            MiAlumno.MostrarDatosAlumno();

            if (MiAlumno.CalcularMedia() >= 5)
            {
                Console.WriteLine("Enhorabuena, estás aprobado");
            } 
            else
            {
                Console.WriteLine("Lo siento, has suspendido");
                
            }

        }

        static void MostrarDatosAlumno(stAlumno a)
        {

            Console.WriteLine($"El alumno se llama {a.Nombre}");
            Console.WriteLine($"tiene {a.edad} años");
            Console.Write("Y sus notas son: ");

            for (int i = 0; i <= a.notas.GetUpperBound(0); i++)
            {
                Console.Write(a.notas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static stAlumno ObtenerDatosAlumno()
        {
            stAlumno UnAlumno;

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
