using System;

namespace _30_EnumerandoCS9_OjoCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            //OJO ESTE Código es C#9.0 sobre NET CORE !!!
            float temperaturaNinho;

            Console.Write("Dime la temperatura corporal del niño: ");
            temperaturaNinho = float.Parse(Console.ReadLine());

            switch (temperaturaNinho)
            {
                case (< 35f):
                    Console.WriteLine("Hipotermia"); 
                   break;
                case (< 37.5f):
                    Console.WriteLine("Normal");
                    break;
                case (< 38f):
                    Console.WriteLine("Febricula");
                    break;
                case (>= 38f):
                    Console.WriteLine("Fiebre");
                    break;
            }

        }
    }
}
