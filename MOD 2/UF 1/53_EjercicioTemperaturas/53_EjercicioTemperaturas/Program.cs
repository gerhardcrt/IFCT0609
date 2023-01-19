using System;

namespace _53_EjercicioTemperaturas
{
    class Program
    {

        struct DatosTermicos
        {
            public string nombreCiudad;
            public int[] maximas;
            public int[] minimas;
        }


        static void Main(string[] args)
        {
            DatosTermicos ciudad1, ciudad2, ciudad3, ciudad4;

            ciudad1.nombreCiudad = "Ourense";
            ciudad1.maximas = new int[] { 24, 23, 16, 16, 17, 18, 17 };
            ciudad1.minimas = new int[] { 4, 3, 1, 2, 3, 5, 6 };

            ciudad2.nombreCiudad = "Coruña";
            ciudad2.maximas = new int[] { 26, 20, 20, 26, 27, 28, 27 };
            ciudad2.minimas = new int[] { 14, 13, 11, 12, 13, 15, 16 };

            ciudad3.nombreCiudad = "Lugo";
            ciudad3.maximas = new int[] { 10, 16, 16, 16, 17, 18, 17 };
            ciudad3.minimas = new int[] { 6, 6, 1, 0, -1, 0, 2 };

            ciudad4.nombreCiudad = "Ponetvedra";
            ciudad4.maximas = new int[] { 31, 33, 16, 16, 25, 26, 17 };
            ciudad4.minimas = new int[] { 14, 13, 10, 12, 12, 15, 16 };

            DatosTermicos[] TemperaturasCapitales = new DatosTermicos[4];

            TemperaturasCapitales[0] = ciudad1;
            TemperaturasCapitales[1] = ciudad2;
            TemperaturasCapitales[2] = ciudad3;
            TemperaturasCapitales[3] = ciudad4;

            //Temperatura máxima el jueves en Lugo
            Console.WriteLine(TemperaturasCapitales[2].maximas[5]);
        }
    }
}
