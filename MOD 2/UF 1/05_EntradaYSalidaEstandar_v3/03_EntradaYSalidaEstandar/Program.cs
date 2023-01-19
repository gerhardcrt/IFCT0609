using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear un programa que pida el nombre por teclado y saque un saludo del estilo
//"Hola Nommbre"

//Sacar mensaje por pantalla pidiendo nombre
//leer nombre por teclado y almacenarlo en variable nombre
//Sacar por pantalla Hola + Nombre

namespace _03_EntradaYSalidaEstandar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Dime tu nombre: ");

            Console.ForegroundColor = ConsoleColor.Gray;
            nombre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Dime tu apellido: ");

            Console.ForegroundColor = ConsoleColor.Gray;
            apellido = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nTe llamas " + nombre + " " + apellido);


            Console.ReadKey();
        }
    }
}
