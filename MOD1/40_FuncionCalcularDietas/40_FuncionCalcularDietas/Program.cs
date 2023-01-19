using System;

namespace _40_FuncionCalcularDietas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kilometros, costePeajes, eurosARecibir = 0;
            bool comida = false, circular = false;
            char rptaS_N;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            eurosARecibir = CalcularDietas(peaje: 10m, kilometros: 100m) ;
            Console.WriteLine($"Con los datos indicados le correponde cobrar: {eurosARecibir} € ");

            

            Console.Write("Dime cuanto kilometros has recorrido: ");
            kilometros = decimal.Parse(Console.ReadLine());

            Console.Write("Dime lo que te has gastado en peajes: ");
            costePeajes = decimal.Parse(Console.ReadLine());

            Console.Write("Has comido fuera (s/n): ");
            rptaS_N = char.Parse(Console.ReadLine());
            if (rptaS_N == 's' || rptaS_N == 'S') { comida = true; }

            Console.Write("El viaje era de ida y vuelta (s/n): ");
            rptaS_N = char.Parse(Console.ReadLine());
            if (rptaS_N == 's' || rptaS_N == 'S') { circular = true; }

            eurosARecibir = CalcularDietas(kilometros, costePeajes, comida, circular);
            Console.WriteLine($"Con los datos indicados le correponde cobrar: {eurosARecibir} € ");
        }

       static decimal CalcularDietas(decimal kilometros, decimal peaje=0, bool dietas = false, bool viajeCircular = true)
        {
            const decimal COSTE_KM = 0.19m;
            const decimal COSTE_DIETAS = 34.70m;
            decimal eurosTotales=0;

            eurosTotales += (kilometros * COSTE_KM) + peaje;
            if (viajeCircular){eurosTotales *= 2;}
            if (dietas) { eurosTotales += COSTE_DIETAS; }

            return eurosTotales;
        }
    }
}
