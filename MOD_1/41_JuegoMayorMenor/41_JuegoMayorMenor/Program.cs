using System;

namespace _41_JuegoMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario, numeroOrdenador, intentos = 0;
            Random aleatorio = new Random();

            numeroOrdenador = aleatorio.Next(0, 11);

            numeroUsuario = -1; //Con esto garantizo que no acierte y que entre en el bucle
            while (numeroUsuario != numeroOrdenador)
            {

                Console.Write("Dime un número: ");
                numeroUsuario = int.Parse(Console.ReadLine());
                intentos++;

                if (numeroUsuario == numeroOrdenador)
                {
                    Console.WriteLine($"Has ganado en {intentos} intentos");
                }
                else
                {
                    Console.WriteLine("No has acertado");
                    if (numeroOrdenador < numeroUsuario)
                    {
                        Console.WriteLine("El número que has dicho es mayor que el mío");
                    }
                    else
                    {
                        Console.WriteLine("El número que has dicho es menor que el mío");
                    }
                }

            }

            


        }
    }
}
