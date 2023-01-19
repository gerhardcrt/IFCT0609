using System;

namespace _42_JuegoMayorMenorRefinado
{
    class Program
    {
        const int LIMITE_SUPERIOR = 10;

        static void Main(string[] args)
        {
            int numeroUsuario, numeroOrdenador, intentos = 0;
            Random aleatorio = new Random();

            numeroOrdenador = aleatorio.Next(0, LIMITE_SUPERIOR+1);

            do
            {
                Console.Write($"Dime un número (0-{LIMITE_SUPERIOR}): ");
                numeroUsuario = int.Parse(Console.ReadLine());
                intentos++;

                if (numeroUsuario == numeroOrdenador)
                {
                    Console.WriteLine($"Has ganado en {intentos} intentos");
                    Console.ReadKey();
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

            } while (numeroUsuario != numeroOrdenador);
           



        }
        

    }

}
