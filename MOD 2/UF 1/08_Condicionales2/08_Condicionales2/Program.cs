using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;
            const byte EDAD_MIN_BIRRAS = 18;

            Console.Write("Dime tu edad: ");
            //edad = byte.Parse(Console.ReadLine());
            if (!byte.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Eso no es un número. LEÑE !!, te has quedado sin birras ");
            }

            if (edad >= EDAD_MIN_BIRRAS)
            {
                Console.WriteLine("YUPI !!! BIRRAS !!!");
            }

            if ( (edad >= 14) && (edad<18) )
            {
                Console.WriteLine("YUPI !!! COLA!!!");
            }

            if (edad < 14)
            {
                Console.WriteLine("ZUMO !!!");
            }


            //if (edad >= 18)
            //{
            //    Console.WriteLine("YUPI !!! BIRRAS !!!");
            //}
            //else if (edad >= 14)
            //{
            //    Console.WriteLine("YUPI !!! COLA!!!");
            //}
            //else
            //{
            //    Console.WriteLine("ZUMO !!!");
            //}

            //if (edad >= 18)
            //{
            //    Console.WriteLine("YUPI !!! BIRRAS !!!");
            //}
            //else
            //{
            //    Console.WriteLine("YUPI !!! COLA!!!");
            //}

            Console.ReadKey();

        }
    }
}
