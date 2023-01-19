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

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Dime tu apellido: ");
            apellido = Console.ReadLine();

            //Console.WriteLine(); //Esto es un simple salto de línea
            //Console.Write("\n"); //Esto es una "secuencia de escape" -->Esto también es un salto de línea
            Console.Write("\nTe llamas " + nombre + " " + apellido);


            Console.ReadKey();
        }
    }
}
