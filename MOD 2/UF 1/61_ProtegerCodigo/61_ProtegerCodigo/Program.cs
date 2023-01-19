using System;

namespace _61_ProtegerCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            byte n0;

            Console.Write("Dame un número: ");
            try
            {
                n0 = byte.Parse(Console.ReadLine());
            } catch (OverflowException e)
            {
                Console.WriteLine("Eso es muy grande o muy pequeño para ser un Byte");
            } catch (FormatException e)
            {
                Console.WriteLine("Eres tonto o entrenas ? Te he pedido un número, no un texto");
            } catch (Exception e)
            {
                Console.WriteLine("Algo diferente ha fallado");
            }
           
            
            Console.Write("Dame un número: ");
            //n1 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Dame un número: ");
            //n2 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine($"La división de {n1} entre {n2} es: {n1 / n2}");

            try
            {
                Console.WriteLine($"La división de {n1} entre {n2} es: {n1 / n2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Se ha producido un error");
            }


            
        }
    }
}
