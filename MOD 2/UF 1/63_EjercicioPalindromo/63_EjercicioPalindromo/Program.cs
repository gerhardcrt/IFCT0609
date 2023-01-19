using System;

namespace _63_EjercicioPalindromo
{

    class Program
    {
        static void Main(string[] args)
        {
            InvertirCadena3("pat");

            Console.WriteLine(EsPalindromo("Ana"));
            Console.WriteLine(EsPalindromo("radar"));
            Console.WriteLine(EsPalindromo("Allarizziralla"));
            Console.WriteLine(EsPalindromo("patata"));
            Console.WriteLine(EsPalindromo("radar1"));

        }

        static bool EsPalindromo(string cadena)
        {
   
            string cadenaInvertida;

            //convierto la cadena a mayúsculas
            cadena = cadena.ToUpper();

            //Invierto la cadena que me pasan como parámetro
            cadenaInvertida = InvertirCadena(cadena);

            //Si la cadena invertida es igual a la cadena que me ha pasado
            //devuelvo true
            //en caso contrario devuelvo false
            if (cadena==cadenaInvertida) {
                return true;
            }
            else
            {
                return false;
            }


        }

        static string InvertirCadena(string cadena)
        {
            string cadenaInvertida = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadenaInvertida += cadena[i];
            }

            return cadenaInvertida;
        }

        static string[] InvertirCadena2(string cadena)
        {
            string[] cadenaInvertidaEnArray = new string[cadena.Length];
            int posicionArray = 0;

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadenaInvertidaEnArray[posicionArray] += cadena[i];
                posicionArray++;
            }

            return cadenaInvertidaEnArray;

        }

        static char[] InvertirCadena3(string cadena)
        {
            char[] cadenaInvertidaEnArray = cadena.ToCharArray();
            Array.Reverse(cadenaInvertidaEnArray);

            return cadenaInvertidaEnArray;

        }

    }
}
