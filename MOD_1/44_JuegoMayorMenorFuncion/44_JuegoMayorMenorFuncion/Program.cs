using System;

namespace _44_JuegoMayorMenorFuncion
{
    class Program
    {


        static void Main(string[] args)
        {
            bool continuarJugando = true;
            string rptaSeguir;
            int record =int.MaxValue, intentosActuales;

            do
            {
                intentosActuales = JuegoMayorMenor(30);

                if (intentosActuales < record)
                {
                    record = intentosActuales;
                    Console.WriteLine("Enhorabuena has batido el record !!!");
                }

                Console.Write("Pulsa S para otra partida, cualquier otra cosa para salir: ");
                rptaSeguir = Console.ReadLine();

                if (rptaSeguir.Substring(0, 1).ToUpper() != "S")
                    //Substring saca una cadena dentro de otra
                    //ToUpper convierte minúsculas a mayúsculas, en caso contrario seria ToLower
                {
                    continuarJugando = false;
                }

                Console.Clear();
                //Limpia la pantalla

            } while (continuarJugando);

        }
        //Función
        static int JuegoMayorMenor(int limiteSuperior)
        {
           int numeroUsuario, numeroOrdenador, intentos = 0;
            Random aleatorio = new Random();

            numeroOrdenador = aleatorio.Next(0, limiteSuperior + 1);

            do
            {
                Console.Write($"Dime un número (0-{limiteSuperior}): ");
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
                        //creo un nuevo bucle mayor o menor
                    {
                        Console.WriteLine("El número que has dicho es mayor que el mío");
                    }
                    else
                    {
                        Console.WriteLine("El número que has dicho es menor que el mío");
                    }
                }

            } while (numeroUsuario != numeroOrdenador);

            return intentos;
        }
    }
}
