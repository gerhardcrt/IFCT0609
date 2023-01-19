using System;

namespace _38_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;

            //Sumar();

            //Console.Write("Dime el primer numero: ");
            //a = int.Parse(Console.ReadLine());

            //Console.Write("Dime el segundo numero: ");
            //b = int.Parse(Console.ReadLine());

            //Sumar2(a, b);
            //Sumar2(10, 30);

            res = Sumar3(10, 20);
            Console.WriteLine($"El resultado es: {res}");

            Console.WriteLine($"El resultado es: {Sumar3(5,7)}");

        }

        static void Sumar()
        {
            int numero1, numero2, resultado;

            Console.Write("Dime el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.WriteLine($"El resultado es: {resultado}");
        }

        static void Sumar2(int numero1, int numero2)
        {
            int resultado;

            resultado = numero1 + numero2;
            Console.WriteLine($"El resultado es: {resultado}");
        }

        static int Sumar3(int numero1, int numero2)
        {
            int resultado;

            resultado = numero1 + numero2;
            return resultado;
        }

    }
}
