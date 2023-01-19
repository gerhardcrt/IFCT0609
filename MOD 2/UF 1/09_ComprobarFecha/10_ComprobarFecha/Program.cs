using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ComprobarFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            int anho;
            byte dia, mes;

            bool fechaCorrecta = true;

            Console.Write("Dime el día: ");
            dia = byte.Parse(Console.ReadLine());

            Console.Write("Dime el mes: ");
            mes = byte.Parse(Console.ReadLine());

            Console.Write("Dime el año: ");
            anho = int.Parse(Console.ReadLine());

            if (anho < 1900)         
            {
                fechaCorrecta = false;
            }

            if ( (mes < 1) || (mes > 12) )
            {
                fechaCorrecta = false;
            }

            if ( (dia < 1) ||
                 (dia > 31 ) || 
                 (dia>29 && mes==2) ||
                 (dia > 28 && mes == 2 && !DateTime.IsLeapYear(anho) ) ||
                 (dia>30 && mes==4) || 
                 (dia > 30 && mes == 6) || 
                 (dia > 30 && mes == 9) || 
                 (dia > 30 && mes == 11) )
            {
                fechaCorrecta = false;
            }

            if (fechaCorrecta) //(fechaCorrecta == true)
            {
                Console.WriteLine("Fecha Correcta");
            }
            else{
                Console.WriteLine("Fecha Mala");
            }
             

            Console.ReadKey();
        }
    }
}
