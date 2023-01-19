using System;

namespace REP01_ConsolaFelicitacionMS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime anhoNuevo = new DateTime(2022, 1, 1);
            
            if (DateTime.Now >= anhoNuevo)
            {
                Console.WriteLine("Feliz Año Nuevo!");
            }
            else
            {
                Console.WriteLine("Aún es 2021!");
            }

            //---------------------------------

            if (int.Parse(DateTime.Now.ToShortDateString().Split('/')[2])>2021)
            {
                Console.WriteLine("Feliz Año Nuevo!");
            }
            else
            {
                Console.WriteLine("Aún es 2021!");
            }



        }
    }
}
