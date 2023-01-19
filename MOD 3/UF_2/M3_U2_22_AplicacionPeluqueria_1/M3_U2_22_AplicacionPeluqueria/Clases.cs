using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Cliente
    {
        public int Id {  get; }
        public String  Nombre { get; }

        public Cliente(string n, int i)
        {
            Id = i;
            Nombre = n;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    class Producto
    {
        public int Id { get; }
        public String Nombre { get; }

        public decimal Precio { get; }

        public int Stock { get; }

        public Producto (string n, int i, decimal p, int s)
        {
            Id = i;
            Nombre = n;
            Precio = p;
            Stock = s;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
    class Trabajador
    {
        public int Id { get; }
        public String Nombre { get; }

        public Trabajador(string n, int i)
        {
            Id = i;
            Nombre = n;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    class TicketProducto 
    {
        public string Numero { get; }
        public DateTime Fecha { get; }
        public Cliente ClienteP { get; }
        public  Trabajador TrabajadorP { get; }

        public List<DetalleTicketProducto> ProductosComprados { get; }

        public TicketProducto(string n, DateTime f, Cliente c, Trabajador p)
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;
            DetalleTicketProducto detalle;

            Numero = n;
            Fecha = f;
            ClienteP = c;
            TrabajadorP = p;

            ProductosComprados = new List<DetalleTicketProducto>();

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = $"SELECT * FROM `detalleticketproductos` where `codigoTicket`='{Numero}'";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new System.Data.DataSet();

            try
            {
                adaptador.Fill(ds);
                conexion.Close();
                
                foreach(System.Data.DataRow dr in ds.Tables[0].Rows)
                {
                    detalle = new DetalleTicketProducto(int.Parse(dr.ItemArray[1].ToString()), decimal.Parse(dr.ItemArray[2].ToString()), int.Parse(dr.ItemArray[3].ToString()));
                    ProductosComprados.Add(detalle);
                }
            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }



        }

        public override string ToString()
        {
            return Numero + " (" + Fecha.ToShortDateString() + ")"; 
        }

    }

    class DetalleTicketProducto
    {
        public int CodigoProducto { get; }
        public int CantidadProducto { get; }
        public decimal PrecioProducto { get; }

        public string NombreProducto { get; }

        public DetalleTicketProducto(int codigo, decimal precio, int cantidad)
        {
            CodigoProducto = codigo;
            CantidadProducto = cantidad;
            PrecioProducto = precio;


            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = $"SELECT `nombre` FROM `productos` WHERE `codigo` = {codigo}";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new System.Data.DataSet();

            try
            {
                adaptador.Fill(ds);
                conexion.Close();
                NombreProducto = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }


        }

        public override string ToString()
        {
            return NombreProducto + " (" + CantidadProducto + ") :" + PrecioProducto.ToString("c") + " /ud."; 
        }

    }

}
