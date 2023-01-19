using System;

namespace EG18_EstoNoEsUNGrafico_DLL_DNI
{
    public class Validador
    {
        public static string CalcularLetraDNI(string dni)
        {
            int numeroDNI, resto;
            string secuenciaLetrasNIF = "TRWAGMYFPDXBNJZSQVHLCKE";

            numeroDNI = int.Parse(dni);
            resto = numeroDNI % 23;

            return secuenciaLetrasNIF[resto].ToString();
        }

    }
}
