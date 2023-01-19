using System;

namespace _35_SucesionFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, terminoActual, posicionBuscada, posicionActual;

            Console.Write("Dime las posicion buscada: ");
            posicionBuscada = int.Parse(Console.ReadLine());
            // posicionBuscada = 22;  //esta asignación la uso solo para las pruebas en las que no se introduce el valor por teclado.

            t1 = 0;
            t2 = 1;

            terminoActual = 1;
            posicionActual = 1;

           while (posicionBuscada != posicionActual)
            {
                terminoActual = t1 + t2;
                t1 = t2;
                t2 = terminoActual;
                posicionActual++;

            }

            Console.WriteLine($"La posicion {posicionBuscada} de Fibonacci es {terminoActual}");

        }
    }
}
