using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EntradaDeDatosNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte edad;

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Dime tu edad: ");
            edad = byte.Parse(Console.ReadLine());

            Console.Write("\nTe llamas " + nombre + " y tienes " + edad.ToString() + " años.");

            Console.ReadKey();
        }
    }
}
