using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TipoDatosEstandar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es un comentario monolínea

            /* Esto es un comentario
             multilínea */

            //Esto también
            //    puede ser un comentario multilínea

            //DECLARACIÓN DE VARIABLES

            int numeroHijos;

            //TIPO DE DATOS EN C#
            // https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            //Numéricos
            //  Enteros
            byte tipoEnteroPequenho; //0 a 255
            sbyte tipoEnteroPequenhoConSigno; //-128 a 127
            short tipoEnteroMediano;    // -32.768 a 32.767
            ushort tipoEnteroMedianoSinSigno; // 0 a 65535
            int enteroLargo; // -2.147.483.648 a 2.147.483.647
            uint enteroLargoSinSigno;
            long enteroMuyLargo; // De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //  Decimales

            decimal numeroDecimalMuyPreciso;
            float numeroDecimal; // De ±1,5 x 10E-45 a ±3,4 x 10E38
            double numeroDecimalMuyGrande;


            //Texto
            // Caracteres
            char unaSolaLetra; // Ojo, no 2, ni 3 UNA !!!        
            // Cadenas
            String cadena; //Cadenas Largas

            //Otros
            //Booleanos
            bool datoLogico; //Solo pueden valer TRUE o FALSE
            //Fechas (Si el lenguaje lo contempla)
            // Tipos de datos personalizados

            //En un solo paso puedo hacer DECLARACIÓN E INICIALIZACIÓN (Asignar un valor inicial)
            int numeroEspecial = 100;

            //Una vez declaradas puedo empeza a utilizarlas
            tipoEnteroPequenhoConSigno = -10;
            // tipoEnteroPequenhoConSigno = 10000; //Saldría del rango
            enteroLargo = 100000000;
            numeroDecimalMuyPreciso = 10.5M; //Esta M significa que es un decimal no un double
            numeroDecimal = 10.5F; //Esta F significa Float
            numeroDecimalMuyGrande = 10.5; //Con los double no protesta
            unaSolaLetra = 'R';
            cadena = "Hola";

        }
    }
}
