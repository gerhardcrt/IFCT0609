using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace M3_04_ProyectoAgendaCSV
{
    class Contacto
    {
        public string Telefono { get; }
        public string Nombre { get; }
        public string Email { get; }

        public Contacto(string t, string n, string e)
        {
            Telefono = t;
            Nombre = n;
            Email = e;
        }

        public override string ToString()
        {
            return Nombre + " (" + Telefono + ")";
        }

        public string GenerarCSV()
        {
            return $"{Telefono};{Nombre};{Email}";
        }
    }

    class Agenda
    {
        private string _ruta;
        public List<Contacto> Elementos { get; }

        public Agenda(string r)
        {
            StreamReader fichero;
            string linea;
            string[] trozosLinea;
            Contacto c;

            Elementos = new List<Contacto>();
            _ruta = r;

            try
            {
                fichero = new StreamReader(_ruta, System.Text.Encoding.Default);

                while (!fichero.EndOfStream)
                {
                    linea = fichero.ReadLine();
                    trozosLinea = linea.Split(';');
                    c = new Contacto(trozosLinea[0], trozosLinea[1], trozosLinea[2]);
                    Elementos.Add(c);
                }

                fichero.Close();
            }
            catch
            {
                Elementos = null;
            }
  

        }

        public int  Anhadir(Contacto c)
        {
            if (BuscarContacto(c) == -1) //si no lo encuentra
            {
                Elementos.Add(c);
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int BuscarContacto(Contacto c)
        {
            for(int i = 0; i < Elementos.Count; i++)
            {
                if (Elementos[i].Telefono == c.Telefono) 
                { 
                    return i;
                }
            }

            return -1;
        }

        public void Borrar(Contacto contactoABorrar)
        {
            int posicion = BuscarContacto(contactoABorrar);

            if ( posicion != -1) 
            {
                Elementos.RemoveAt(posicion);
            }
            else
            {
                throw new Exception("Elemento no encontrado");
            }
        }

        public void Guardar()
        {
            StreamWriter fichero;

            try
            {
                fichero = new StreamWriter(_ruta, false,System.Text.Encoding.Default);

                foreach(Contacto c in Elementos)
                {
                    fichero.WriteLine(c.GenerarCSV());
                }

                fichero.Close();

            }
            catch { }

        }

        public void Modificar(Contacto contatoModificar, Contacto nuevo)
        {
            int posicion = BuscarContacto(contatoModificar);
            
            if (posicion != -1)
            {
                Elementos[posicion] = nuevo;
            }
            else
            {
                throw new Exception("Elemento no encontrado");
            }
        }
    }
}
