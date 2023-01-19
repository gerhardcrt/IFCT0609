using System;

namespace EXM2_UF1_Ej1
{
    class Program
    {

        //hacer un programa que a partir de una frase diga cuantas vocales tiene
        static void Main(string[] args)
        {
            //string frase = "Mira que os liais la manta a la cabeza";
            string frase = "murcielagoollllla,";
            int contador = 0;

            //Voy a recorrer la frase letra a letra, si encuentro una vocal aumento
            //el contador

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {
                if (frase[posicion] == 'a' ||
                    frase[posicion] == 'e' || 
                    frase[posicion] == 'i' ||
                    frase[posicion] == 'o' ||
                    frase[posicion] == 'u')
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
            Console.WriteLine(ContarVocales("AAAA"));
            Console.WriteLine(contador);
            Console.WriteLine(ContarVocales2("AAAAaeiouj"));
            Console.WriteLine(ContarVocales3("AAAAaeiouWQTY"));
            Console.WriteLine(ContarLetras("AAAAaeiouWQTY","aeiouq"));
            Console.WriteLine(ContarVocalesCarlosMod("aeirouq"));
            Console.WriteLine(ContarVocalesCarlosMod2("aeirouq"));

        }

        static int ContarVocales(string frase)
        {
            int contador = 0;

            frase = frase.ToLower();

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {
                if (frase[posicion] == 'a' ||
                    frase[posicion] == 'e' ||
                    frase[posicion] == 'i' ||
                    frase[posicion] == 'o' ||
                    frase[posicion] == 'u')
                {
                    contador++;
                }
            }

            return contador;

        }

        static int ContarVocales2(string frase)
        {
            int contador = 0;
            char[] letrasContar = new char[] { 'a', 'e', 'i', 'o', 'u' };

            frase = frase.ToLower();

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {

                for (int vocalActual = 0; vocalActual < letrasContar.Length; vocalActual++)
                {
                    if (frase[posicion] == letrasContar[vocalActual]) { contador++; }
                }


            }

            return contador;

        }

        static int ContarVocales3(string frase)
        {
            int contador = 0;
            string letrasContar = "aeiou";

            frase = frase.ToLower();

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {

                if (letrasContar.Contains(frase[posicion])) { contador++; }

            }

            return contador;

        }

        static int ContarLetras(string frase, string letrasContar)
        {
            int contador = 0;

            frase = frase.ToLower();

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {

                if (letrasContar.Contains(frase[posicion])) { contador++; }

            }

            return contador;

        }

        static int ContarVocalesCarlosMod(string frase)
        {
            string fraseEditada = frase;
            int candidadBorrados = 0;

            for (int posicion = 0; posicion < frase.Length; posicion++)
            {
                if (frase[posicion] == 'a' ||
                    frase[posicion] == 'e' ||
                    frase[posicion] == 'i' ||
                    frase[posicion] == 'o' ||
                    frase[posicion] == 'u')
                { }
                else { 
                    fraseEditada = fraseEditada.Remove(posicion-candidadBorrados, 1);
                    candidadBorrados++;
                }
            }


            return fraseEditada.Length;
        }

        static int ContarVocalesCarlosMod2(string frase)
        {
            string fraseEditada = frase;

            for (int posicion = frase.Length-1; posicion > 0; posicion--)
            {
                if (frase[posicion] == 'a' ||
                    frase[posicion] == 'e' ||
                    frase[posicion] == 'i' ||
                    frase[posicion] == 'o' ||
                    frase[posicion] == 'u')
                { }
                else
                {
                    fraseEditada = fraseEditada.Remove(posicion, 1);

                }
            }


            return fraseEditada.Length;
        }


    }
}
