using System;

namespace _64_MetodosString
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "http://periodico.diario.marca.com";
            string[] trozosCadena;

            int posicionUltimoPunto;
            string subcadenaDominio;

            trozosCadena = cadena.Split('.');
            Console.WriteLine($"La extensión de dominio es: {trozosCadena[trozosCadena.Length - 1]}");
            //divide la cadena delimitada en subcadenas que están separadas por un caracter conocido
            //rompe un string en arrays

            posicionUltimoPunto = cadena.LastIndexOf('.');
            //subcadenaDominio = cadena.Substring(posicionUltimoPunto + 1);
            //indica la posición de índice de base cero de la última aparición de un caracter
            //devuelve -1, si el caracter o cadena no se encuentran en esta instancia
            subcadenaDominio = cadena.Substring(posicionUltimoPunto + 1, cadena.Length-posicionUltimoPunto-1);
            //obtiene parte de la cadena en un índice inicial a través de una longitud especificada

            cadena = ".....hasta....luego.......lucas...";

            Console.WriteLine(cadena.TrimStart('.'));
            //borra los espacios al principio
            Console.WriteLine(cadena.TrimEnd('.'));
            //borra los espacios al final
            Console.WriteLine(cadena.Trim('.'));
            //borra los espacios al principio y al final

            //Replace: devuelve una nueva cadena en la que un String de la cadena actual se reemplaza por otro String
            //Contains: devuelve un valor que indica si un carácter especificado aparece dentro de esta cadena


            cadena = " Hola     ";

            Console.ReadKey();

        }
    }
}
