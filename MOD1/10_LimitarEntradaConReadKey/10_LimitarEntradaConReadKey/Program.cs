using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_LimitarEntradaConReadKey
{
    class Program
    {
        //Programa que rechaza los números
        static void Main(string[] args)
        {
            string cadenaSinNumeros = "";
            ConsoleKeyInfo pulsacion;

            Console.Write("Introduce un texto sin números: ");
            do
            {
                
                pulsacion = Console.ReadKey(true);

                if (!char.IsDigit(pulsacion.KeyChar))
                {
                    cadenaSinNumeros += pulsacion.KeyChar.ToString();
                    Console.Write(pulsacion.KeyChar.ToString());
                } 


            } while (pulsacion.Key != ConsoleKey.Enter);

            Console.WriteLine();
            Console.WriteLine("El texto es: " + cadenaSinNumeros);

            Console.WriteLine("Pulsa cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
