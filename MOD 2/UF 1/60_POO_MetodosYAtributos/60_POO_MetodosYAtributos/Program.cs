using System;

namespace _60_POO_MetodosYAtributos
{
    class Documento  {   }

    class Alumno
    {
        private string _nombre;
        private string _dni;
        private DateTime _fechaNacimiento;
        private float _beca;
        private Documento _DeclaracionRenta;

        public Alumno() { }

        public Alumno(string dni, string nom)
        {
            _dni = dni;
            _nombre = nom;
        }

        public String Nombre
        {
            get{ return _nombre; }
            set { if (value.Length <2) { _nombre = null; }
                else { _nombre = value; }
            }

        }

        //public float Beca{set;get;} es lo mismo que lo de abajo

        public float Beca
        {
            set;
            get;
        }

        public string DevolverNombre()
        {
            return _nombre;
        }

        public void AsignarNombre(string n)
        {
            if (n.Length < 2) { _nombre = null; }
            else { _nombre = n; }
        }

        public void AsignarDNI(string dni)
        {
            if (isNifNumValid(dni)) { _dni = dni; }
            else { _dni = null; }
        }
        // los tres van a hacer lo mismo: asignar fecha de nacimiento
        // 1
        public void AsignarFechNacimiento(int dia, int mes, int anho)
        {
            DateTime miFechaNacimiento;

            try
            {
                miFechaNacimiento = new DateTime(anho, mes, dia);
                _fechaNacimiento = miFechaNacimiento;
            }
            catch { }

        }
        // 2
        public void AsignarFechNacimiento()
        {
            DateTime miFechaNacimiento;
            int anho = DateTime.Now.Year;
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;

            miFechaNacimiento = new DateTime(anho, mes, dia);
             _fechaNacimiento = miFechaNacimiento;

        }
        // 3
        public void AsignarFechNacimiento(int dia, int mes)
        {
            DateTime miFechaNacimiento;
            int anho = DateTime.Now.Year;

            try
            {
                miFechaNacimiento = new DateTime(anho, mes, dia);
                _fechaNacimiento = miFechaNacimiento;
            }
            catch { }

        }

        private bool isNifNumValid(String nif)
        {
            String secuenciaLetrasNIF = "TRWAGMYFPDXBNJZSQVHLCKE";
            String numeroNIF;
            String letraNIF;
            String letraObtenida;

            int resto;

            if (nif.Length != 9)
            {
                return false;
            }

            nif = nif.ToUpper(); //convierto a mayusculas porque no sé como me lo va a poner el usuario
            numeroNIF = nif.Substring(0, 8); //cojo 8 char desde la posición 0

            //Los NIe empiezan por X, Y o Z, y hay que substituirlo por 0, 1 o 2
            numeroNIF = numeroNIF.Replace('X', '0').Replace('Y', '1').Replace('Z', '2');

            //Obtengo la letra del NIF
            letraNIF = nif.Substring(8, 1);

            //Calculo el resto entre 23
            try
            {
                resto = int.Parse(numeroNIF) % 23;
            }
            catch { return false; }


            //Obtengo la letra que saldría por el resto
            letraObtenida = secuenciaLetrasNIF.Substring(resto, 1);

            if (letraObtenida == letraNIF) { return true; }
            return false;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Alumno a = new Alumno();

            a.AsignarFechNacimiento(23, 11, 2021);
            a.AsignarFechNacimiento();

            //Console.Write("Dime tu nombre: ");
            //a.AsignarNombre(Console.ReadLine());

            //Console.WriteLine($"Me has dicho que te llamas: {a.DevolverNombre()}");

            a.Nombre = "Gervasio";
            Console.WriteLine($"Me has dicho que te llamas: {a.Nombre}");

            a.Beca = 300f;
            Console.WriteLine($"Tu beca es de : {a.Beca} €");

            Console.ReadKey();

        }

        

    }
}
