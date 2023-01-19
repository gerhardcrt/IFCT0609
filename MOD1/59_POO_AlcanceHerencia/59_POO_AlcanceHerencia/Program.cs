using System;

namespace _59_POO_AlcanceHerencia
{
    class Padre
    {
        private string _dni;

        public string atributoPublicoPadre;
        private string atributoPrivadoPadre;
        protected string atributoProtegidoPadre;

        //atributoPublicoPadre = "Hola"; --> Esto tendría que estar en un método. Aquí no funciona !!!

        public void AsignarDNI(string numero)
        {
            //if dni es valido{
            _dni = numero;
            //}
            //else _dni = null;
        }


        public void metodoPublicoPadre()
        {
            atributoPublicoPadre = "Hola";
            atributoPrivadoPadre = "Adios";
            atributoProtegidoPadre = "Hasta Luego Lucas";

            //UnPadre.metodoPrivadoPadre(); --> UnPadre no EXISTE (Ni tiene sentido) aquí !!!
            //UnPadre.metodoProtegidoPadre();

            metodoPrivadoPadre();
            metodoProtegidoPadre();

        }

        private void metodoPrivadoPadre()
        {

        }

        protected void metodoProtegidoPadre()
        {

        }

    }

    class Hijo: Padre
    {
        public string atributoPublicoHijo;
        private string atributoPrivadoHijo;
        protected string atributoProtegidoHijo;

        //atributoPublicoPadre = "Hola"; --> no puedo escribir donde quiera
        //atributoPublicoHijo = "Hola"; --> aquí tampoco LEÑE !!!

        public void MetodoPublicoHijo() {

            atributoPublicoHijo = "Hola";
            atributoPrivadoHijo = "Hola";
            atributoProtegidoHijo = "Hola";

            //atributoPrivadoHijo++; --> Por favor PENSAD !!! Es un STRING !!!

            atributoPublicoPadre = "Ojo ojo ojo";
            //atributoPrivadoPadre = "Ojo ojo ojo"; --> no estoy dentro de esa clase
            atributoProtegidoPadre = "Ojo ojo ojo";

            MetodoPrivadoHijo();
            MetodoProtegidoHijo();

            metodoPublicoPadre();
            metodoProtegidoPadre();
            //metodoPrivadoPadre();
        }
        public void MetodoPrivadoHijo() { }
        public void MetodoProtegidoHijo() { }

    } 

    class Nieto : Hijo
    {
        public string atributoPublicoNieto;
        private string atributoPrivadoNieto;
        protected string atributoProtegidoNieto;

        //atributoPublicoHijo = "Hola";
        //atributoPublicoPadre = "Hola";

        public void MetodoPublicoNieto() {

            atributoPublicoNieto="Hola";
            atributoPrivadoNieto="Hola";
            atributoProtegidoNieto="Hola";

            atributoPublicoHijo="Hola";
            //atributoPrivadoHijo="Hola";
            atributoProtegidoHijo="Hola";

            atributoPublicoPadre="Hola";
            //atributoPrivadoPadre="Hola";
            atributoProtegidoPadre="Hola";

        }
        public void MetodoPrivadoNieto() { }
        public void MetodoProtegidoNieto() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Padre UnPadre;
            //UnPadre = new Padre();

            Padre UnPadre = new Padre();

            UnPadre.AsignarDNI("12345678Z");

            UnPadre.atributoPublicoPadre = "Hola";
            //atributoPublicoPadre = "Hola"; --> Esto no existe fuera de un objeto padre

            //UnPadre.atributoPrivadoPadre = "Adios"; --> No es accesible. Estoy fuera de la clase padre
            //UnPadre.atributoProtegidoPadre = "Hasta Luego Lucas"; --> No es accesible. Estoy fuera de la clase padre y fuera de un heredero

            UnPadre.metodoPublicoPadre();
            //UnPadre.metodoPrivadoPadre();
            //UnPadre.metodoProtegidoPadre();
            
            Hijo UnHijo = new Hijo();

            UnHijo.atributoPublicoHijo="Hola";
            //UnHijo.atributoPrivadoHijo="Hola";
            //UnHijo.atributoProtegidoHijo = "Hola";

            UnHijo.atributoPublicoPadre = "Fijaros bien porfa !";
            //UnHijo.atributoProtegidoPadre = "Esta tiene miga ! ";
            //UnHijo.atributoPrivadoPadre = "Esta tiene miga ! ";

            Nieto UnNieto = new Nieto();
            UnNieto.atributoPublicoPadre = "Seguiros fijando, vais bien !!!";
            //UnNieto.atributoProtegidoPadre = "Seguiros fijando, vais bien !!!";
        }
    }
}
