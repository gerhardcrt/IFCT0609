using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //necesito este espacio de nombres para Image

namespace M3_07_InformaticosRiquinhos_POO
{
    class Informatico
    {
        public string Nombre { get; }
        public string Cargo { get; }
        public int Pasta { get; }
        public Image Foto { get; }

        public Informatico(string n, string c, int p, string ruta)
        {          
            Nombre = n;
            Cargo = c;
            
            if (p<0){Pasta = 0;}
            else { Pasta = p;}

            try
            {
                Foto = Image.FromFile(ruta);
            }
            catch { Foto = null; }        
        }
    }
}
