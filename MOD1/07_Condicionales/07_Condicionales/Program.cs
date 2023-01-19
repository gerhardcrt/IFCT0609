using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores lógicops
            // == igual
            // != distinto
            // > mayor
            // < menor
            // >= mayor o igual
            // <= menor o igual

            int a, b;

            a = 10;
            b = 10;

            Console.WriteLine("Esto es un ejemplo de condicional");
            Console.WriteLine("Los condicionales se hacen con IF");

            if (a == b)
            {
                Console.WriteLine("Hoy no va a llover");
            } else 
            {
                if (a > b)
                {
                    Console.WriteLine("Hoy es jueves");
                } else
                {
                    Console.WriteLine("Dije que Hoy es jueves");
                }

            } 




            Console.ReadKey();

        }
    }
}
