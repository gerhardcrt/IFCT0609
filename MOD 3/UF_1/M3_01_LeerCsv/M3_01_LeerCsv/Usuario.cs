using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Clases
{
    //Previo: definir una clase Usuario
    //con Atributos y Propiedades

    class Usuario
    {

        //Atributos
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _localidad;

        public Usuario(string nombre, string apellido, int edad, string localidad)
        {
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _localidad = localidad;
        }

        //Propiedades       
        public string nombre { get { return _nombre; } }
        public string apellido { get { return _apellido; } }
        public int edad { get { return _edad; } }
        public string localidad { get { return _localidad; } }


        //Método que recorre línea a línea el CSV para cargar los datos
        public static Usuario[] CargarDatos(string nombreArchivo)
        {
            Usuario[] datos;
            
            StreamReader st = new StreamReader(nombreArchivo, System.Text.Encoding.UTF8);
            string linea;
            string[] trozosLinea;
            int posicionEnArray = 0;

            Usuario uActual;

            while (!st.EndOfStream)
            {
                _ = st.ReadLine();
                posicionEnArray++;
            }
            st.Close();
              
            //Creo los Constructores: datos, st y uActual
            datos = new Usuario[posicionEnArray];

            st = new StreamReader(nombreArchivo, System.Text.Encoding.Default);
            posicionEnArray = 0;
            while (!st.EndOfStream)
            {
                linea = st.ReadLine();
                trozosLinea = linea.Split(';');

                uActual = new Usuario(trozosLinea[0], trozosLinea[1], int.Parse(trozosLinea[2]), trozosLinea[3]);

                datos[posicionEnArray] = uActual;
                posicionEnArray++;
                
            }

            st.Close();


            return datos;
        }

    }
}
