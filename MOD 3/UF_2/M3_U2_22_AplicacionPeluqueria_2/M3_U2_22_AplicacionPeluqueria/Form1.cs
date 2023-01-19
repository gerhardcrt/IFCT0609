using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clases;
using MySql.Data.MySqlClient;

namespace M3_U2_22_AplicacionPeluqueria
{
    public partial class frmGestionPeluqueria : Form
    {
        public frmGestionPeluqueria()
        {
            InitializeComponent();
        }

        private void frmGestionPeluqueria_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            CargarTrabajadores();
            CargarTickets();
        }

        private void CargarClientes() 
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = "SELECT * FROM `clientes`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            Cliente c;

            try
            {
                adaptador.Fill(ds);
                conexion.Close();

                lbClientes.Items.Clear();
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    c = new Cliente(dr.ItemArray[1].ToString(), int.Parse(dr.ItemArray[0].ToString()));
                    lbClientes.Items.Add(c);
                }


            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }


        }

        private void CargarProductos() 
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = "SELECT * FROM `productos`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            Producto p;

            try
            {
                adaptador.Fill(ds);
                conexion.Close();

                lbProductos.Items.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    p = new Producto(dr.ItemArray[1].ToString(), int.Parse(dr.ItemArray[0].ToString()), decimal.Parse(dr.ItemArray[2].ToString()), int.Parse(dr.ItemArray[3].ToString()));
                    lbProductos.Items.Add(p);
                }


            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }
        }

        private void CargarTrabajadores()
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = "SELECT * FROM `trabajadores`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            Trabajador t;

            try
            {
                adaptador.Fill(ds);
                conexion.Close();

                lbTrabajadores.Items.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    t = new Trabajador(dr.ItemArray[1].ToString(), int.Parse(dr.ItemArray[0].ToString()));
                    lbTrabajadores.Items.Add(t);
                }


            }
            catch
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }


        }

        private void CargarTickets()
        {

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            string cadenaComando, cadenaConexion;

            cadenaConexion = "server=localhost;uid=root;password=1234;database=peluqueria";
            cadenaComando = "SELECT `ticketproductos`.`numeroTicket`, `ticketproductos`.`fecha`, `clientes`.`nombre`, `clientes`.`codigo`, `trabajadores`.`codigo`, `trabajadores`.`nombre` FROM `ticketproductos`, `clientes`, `trabajadores` WHERE `ticketproductos`.`cliente` = `clientes`.`codigo`  and `ticketproductos`.`trabajador`= `trabajadores`.`codigo`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();
            
            TicketProducto t;
            Cliente c;
            Trabajador trab;

            string cadenaFecha;
            string[] cadenaFechaTrozos;

            try
            {
                adaptador.Fill(ds);
                conexion.Close();

                lbTicketsPRoductos.Items.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cadenaFecha = dr.ItemArray[1].ToString().Substring(0,10);
                    cadenaFechaTrozos = cadenaFecha.Split('/');
                    c = new Cliente(dr.ItemArray[2].ToString(), int.Parse(dr.ItemArray[3].ToString()));
                    trab = new Trabajador(dr.ItemArray[5].ToString(), int.Parse(dr.ItemArray[4].ToString()));
                    t = new TicketProducto(dr.ItemArray[0].ToString(),new DateTime(int.Parse(cadenaFechaTrozos[2])), c,trab);
                    lbTicketsPRoductos.Items.Add(t);
                }
 
            }
            catch (Exception ex)
            {
                return; //Si no soy capaz de rellenar el DS, pues salgo del procedmiento 
            }


        }




        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c;

            if (lbClientes.SelectedIndex != -1)
            {
                c = (Cliente)lbClientes.SelectedItem;
                txtClienteId.Text = c.Id.ToString();
                txtClienteNombre.Text = c.Nombre;
            }

            

        }

        private void lbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto p;

            if (lbProductos.SelectedIndex != -1)
            {
                p = (Producto)lbProductos.SelectedItem;
                txtProductoId.Text = p.Id.ToString();
                txtProductoNombre.Text = p.Nombre;
                txtProductoPrecio.Text = p.Precio.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
                txtProductoStock.Text = p.Stock.ToString();

            }
        }

        private void lbTrabajadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trabajador t;

            if (lbTrabajadores.SelectedIndex != -1)
            {
                t = (Trabajador)lbTrabajadores.SelectedItem;
                txtTrabajadoresId.Text = t.Id.ToString();
                txtTrabajadoresNombre.Text = t.Nombre;
            }

        }

        private void lbTicketsPRoductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TicketProducto t;

            if (lbTicketsPRoductos.SelectedIndex != -1)
            {
                t = (TicketProducto)lbTicketsPRoductos.SelectedItem;
                txtTicketProductoNumero.Text = t.Numero.ToString();
                txtTicketProductoFecha.Text = t.Fecha.ToShortDateString();
                txtTicketProductoCliente.Text = t.ClienteP.Nombre;
                txtTicketProductoTrabajador.Text = t.TrabajadorP.Nombre;

                lbDetalleTicketsProductos.Items.Clear();
                foreach(DetalleTicketProducto detalle in t.ProductosComprados)
                {
                    lbDetalleTicketsProductos.Items.Add(detalle);
                }

                txtTicketProductoTotal.Text = t.Total.ToString("c");
            }
        }
    }
}
