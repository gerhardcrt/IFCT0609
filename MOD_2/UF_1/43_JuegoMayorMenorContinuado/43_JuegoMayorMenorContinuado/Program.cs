using System;

namespace _43_JuegoMayorMenorContinuado
{
    class Program
    {
       

        static void Main(string[] args)
        {
            bool continuarJugando = true;
            string rptaSeguir;

            do
            {
                JuegoMayorMenor();

                Console.Write("Pulsa S para otra partida, cualquier otra cosa para salir: ");
                rptaSeguir = Console.ReadLine();

                if (rptaSeguir.Substring(0, 1).ToUpper() != "S")
                {
                    continuarJugando = false;
                }

                Console.Clear();

            } while (continuarJugando);
            
        }

        static void JuegoMayorMenor()
        {
            const int LIMITE_SUPERIOR = 1;

            int numeroUsuario, numeroOrdenador, intentos = 0;
            Random aleatorio = new Random();

            numeroOrdenador = aleatorio.Next(0, LIMITE_SUPERIOR + 1);

            do
            {
                Console.Write($"Dime un número (0-{LIMITE_SUPERIOR}): ");
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

            } while (numeroUsuario != numeroOrdenador);
        }
    }
}
