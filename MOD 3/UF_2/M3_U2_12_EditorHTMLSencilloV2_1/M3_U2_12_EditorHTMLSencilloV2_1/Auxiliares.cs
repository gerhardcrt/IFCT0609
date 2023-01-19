using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_U2_12_EditorHTMLSencilloV2_1
{
    class Auxiliares
    {
        public static int ReemplazarPalabra(ref string frase, string trozo, string textoNuevo)
        {
            int largo = 0;
            int posicion;
            string palabraSustituir;

            posicion = BuscarPalabra(frase, trozo, ref largo);
            if (posicion == -1)
            {
                return -1;
            }
            else
            {
                palabraSustituir = frase.Substring(posicion, largo);
                frase = frase.Replace(palabraSustituir, textoNuevo);
                return 0;
            }

        }

        private static int BuscarPalabra(string frase, string textoBuscado, ref int longitud)
        {
            int posicionInicio = frase.IndexOf(textoBuscado);
            longitud = -1;

            if (posicionInicio != -1)
            {
                for (int i = posicionInicio; i < frase.Length; i++)
                {
                    longitud = i - posicionInicio + 1;
                    if (char.IsSeparator(frase[i]) || frase[i] == '\n')
                    {
                        longitud--;
                        if (frase[i] == '\n') { longitud--; }
                        break;
                    }
                }
            }

            return posicionInicio;
        }
    }
}
