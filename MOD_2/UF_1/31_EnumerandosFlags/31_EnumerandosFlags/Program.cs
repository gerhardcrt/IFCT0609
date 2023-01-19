using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_EnumerandosFlags
{
    [Flags]
    enum diasSemana : Byte
    {
        Lunes = 0b_0000_0001,
        Martes = 0b_0000_0010,
        Miercoles = 0b_0000_0100,
        Jueves = 0b_0000_1000,
        Viernes = 0b_0001_0000,
        Sabado = 0b_0010_0000,
        Domingo = 0b_0100_0000
    }

    [Flags]
    enum idiomas : Byte
    {
        castellano = 0b_0000_0001,
        galego = 0b_0000_0010,
        ingles = 0b_0000_0100,
        frances = 0b_0000_1000,
        portugues = 0b_0001_0000
    }

    class Program
    {
        static void Main(string[] args)
        {
            int siete = 0b_0111; //El 7 decimal en binario
            diasSemana noLectivos = diasSemana.Sabado | diasSemana.Domingo;
            idiomas idiomasUsuarioNuevo = idiomas.castellano | idiomas.ingles | idiomas.galego;
            idiomas idiomasUsuarioNuevoNo = idiomas.frances | idiomas.portugues;

            Console.WriteLine($"Los días de la semana son: {siete}");
            diasSemana diaExamen = (diasSemana)3;

            Console.WriteLine($"El día del examen es: {diaExamen}");
            Console.WriteLine($"No hay clases: {noLectivos}");

            Console.WriteLine($"El usuario domina: {idiomasUsuarioNuevo}");
            Console.WriteLine($"El usuario no domina: {idiomasUsuarioNuevoNo}");

            Console.ReadKey();

        }
    }
}
