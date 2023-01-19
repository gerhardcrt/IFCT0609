using System;

namespace _36_CalculoSeguridadSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal PORCENTA_SS_EMPLEADO = 4.7M;
            const decimal PORCENTA_SS_EMPRESARIO = 25.1M; //23.60 + 1.50 de contingencias
                                                          //https://www.seg-social.es/wps/portal/wss/internet/Trabajadores/CotizacionRecaudacionTrabajadores/10721/10957/2222/2225
                                                          //https://www.mites.gob.es/es/portada/serviciohogar/nueva-regulacion/segsocial/index.htm

            //Estas son las bases de cotización actuales

            //1.º Hasta 240,00    206,00
            //2.º Desde 240,01 hasta 375,00   340,00
            //3.º Desde 375,01 hasta 510,00   474,00
            //4.º Desde 510,01 hasta 645,00   608,00
            //5.º Desde 645,01 hasta 780,00   743,00
            //6.º Desde 780,01 hasta 914,00   877,00
            //7.º Desde 914,01 hasta 1.050,00 1.050,00
            //8.º Desde 1.050,01 hasta 1.144,00 1.097,00
            //9.º Desde 1.144,01 hasta 1.294,00 1.232,00
            //10.º Desde 1.294,01 Retribución mensual

            const decimal LIMITE1 = 240m;
            const decimal LIMITE2 = 375m;
            const decimal LIMITE3 = 510m;
            const decimal LIMITE4 = 645m;
            const decimal LIMITE5 = 780m;
            const decimal LIMITE6 = 914m;
            const decimal LIMITE7 = 1050m;
            const decimal LIMITE8 = 1144m;
            const decimal LIMITE9 = 1294m;

            const decimal TRAMO1 = 206m;
            const decimal TRAMO2 = 340m;
            const decimal TRAMO3 = 474m;
            const decimal TRAMO4 = 608m;
            const decimal TRAMO5 = 743m;
            const decimal TRAMO6 = 877m;
            const decimal TRAMO7 = 1050m;
            const decimal TRAMO8 = 1097m;
            const decimal TRAMO9 = 1232m;
            
            Console.OutputEncoding = System.Text.Encoding.UTF8; //esto le indica a la consola que coja la codificación que admite tildes y símbolo de €

            decimal salarioBruto, salarioNeto, baseCotizacion, ssEmpleado, ssEmpresario;

            //salarioBruto = 800M;
            Console.Write("Dame el salario bruto: ");
            salarioBruto = decimal.Parse(Console.ReadLine());

            //--------------- ESTO FALTA -------------
            //baseCotizacion = 877M; //Esta base cambia en funcion del salario bruto CALCULAR LUEGO !!!

            switch (salarioBruto)
            {
                case <= LIMITE1:
                    baseCotizacion = TRAMO1;
                break;

                case <= LIMITE2:
                    baseCotizacion = TRAMO2;
                    break;

                case <= LIMITE3:
                    baseCotizacion = TRAMO3;
                    break;

                case <= LIMITE4:
                    baseCotizacion = TRAMO4;
                    break;

                case <= LIMITE5:
                    baseCotizacion = TRAMO5;
                    break;

                case <= LIMITE6:
                    baseCotizacion = TRAMO6;
                    break;

                case <= LIMITE7:
                    baseCotizacion = TRAMO7;
                    break;

                case <= LIMITE8:
                    baseCotizacion = TRAMO8;
                    break;

                case <= LIMITE9:
                    baseCotizacion = TRAMO9;
                    break;

                default:
                    baseCotizacion = salarioBruto;
                    break;

            }


            //--------------- ESTO FALTA -------------

            ssEmpleado = Math.Round(baseCotizacion * PORCENTA_SS_EMPLEADO / 100,2);
            ssEmpresario = Math.Round(baseCotizacion * PORCENTA_SS_EMPRESARIO / 100, 2);
            salarioNeto = salarioBruto - ssEmpleado;

            Console.WriteLine($"El salario bruto es: {salarioBruto} €");
            Console.WriteLine($"El salario neto es: {salarioNeto} €");
            Console.WriteLine($"La SS total es: {ssEmpleado+ssEmpresario} €");
            Console.WriteLine($"De la cual la parte del EMPLEADOR es: {ssEmpresario} €");
            Console.WriteLine($"y la del TRABAJADOR es: {ssEmpleado} €");

        }
    }
}
