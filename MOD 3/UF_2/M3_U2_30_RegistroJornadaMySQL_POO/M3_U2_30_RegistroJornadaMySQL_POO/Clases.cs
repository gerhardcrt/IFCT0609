using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clases
{
    class Trabajador
    {
        private int id;
        private string nombre;

        public int Id { get { return id; } }
        public String Nombre { get { return nombre; } }

        public Trabajador(int i, string nom)
        {
            id = i;
            nombre = nom;
        }

        public override string ToString()
        {
            return nombre;
        }


    }

    class BD
    {
        private string host;
        private string baseDatos;
        private string usuario;
        private string pass;

        private string cadenaConexion;
        public MySqlConnection conn;

        public BD(string h, string bd, string user, string p)
        {
            host = h;
            baseDatos = bd;
            usuario = user;
            pass = p;

            cadenaConexion = $"server={host};uid={user};password={pass};database={baseDatos}";
        }

        public void AbrirConexion()
        {
            conn = new MySqlConnection(cadenaConexion);
            conn.Open();
        }

        public void CerraConexion()
        {
            conn.Close();
        }
    }

    class Jornada
    {
        private DateTime fecha;
        private DateTime horaInicio;
        private DateTime horaFin;
        private Trabajador t;

        public Jornada(DateTime fechaJornada, DateTime horaInicioJornada, DateTime horaFinJornada, Trabajador trabajadorJornada)
        {
            fecha = fechaJornada;
            horaInicio = horaInicioJornada;
            horaFin = horaFinJornada;
            t = trabajadorJornada;
        }

        public static List<Trabajador> ObtenerTrabajadores(BD baseDatos)
        {
            string cadenaComando;
            List<Trabajador> datos = new List<Trabajador>();
            System.Data.DataSet ds;
            MySqlCommand comando;
            MySqlDataAdapter adaptador;
            Trabajador t;

            baseDatos.AbrirConexion();
            cadenaComando = "SELECT * FROM `trabajadores`";
            comando = new MySqlCommand(cadenaComando, baseDatos.conn);
            adaptador = new MySqlDataAdapter(comando);
            ds = new System.Data.DataSet();

            try
            {
                adaptador.Fill(ds);
                baseDatos.CerraConexion();
            }
            catch { Exception ex; }
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    t = new Trabajador(int.Parse(fila.ItemArray[0].ToString()), fila.ItemArray[1].ToString());
                    datos.Add(t);
                }

            }
            return datos;
        }

        public int AgregarJornada(BD baseDatos)
        {
            string fechaTexto, horaInicioTexto, horaFinTexto;
            string cadenaComando;
            MySql.Data.MySqlClient.MySqlCommand comando;

            fechaTexto = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" +  fecha.Day.ToString();
            horaInicioTexto = horaInicio.ToShortTimeString() + ":00";
            horaFinTexto = horaFin.ToShortTimeString() + ":00";

            cadenaComando = $"INSERT INTO `registro` (`idRegistro`, `trabajador`, `fecha`, `horaEntrada`, `horaSalida`) VALUES (NULL, '{t.Id.ToString()}', '{fechaTexto}', '{horaInicioTexto}', '{horaFinTexto}')";
            comando = new MySqlCommand(cadenaComando, baseDatos.conn);

            try
            {
                baseDatos.conn.Open();
                comando.ExecuteNonQuery();
                baseDatos.conn.Close();
                return 0;
            }
            catch (Exception ex) { return 1; }
            

        }
    }
}
