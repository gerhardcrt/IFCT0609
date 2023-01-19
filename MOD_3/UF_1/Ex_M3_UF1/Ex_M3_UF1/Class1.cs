using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_M3_UF1
{
    public class Clientes
    {
        private string _CodigoCliente;
        private string _DenominacionCliente;

        public string CodigoCliente 
        { 
            get{ return _CodigoCliente; } 
        }
        public string DenominacionCliente {
            set 
            {
                if (value == "") { _DenominacionCliente = "Cliente Xenerico"; }
                else { _DenominacionCliente = value; }
            }        
            
            get { return _DenominacionCliente; } 
        
        }

        public int InsertarCliente(string nombreBD)
        {
            return 0;
        }

        public override string ToString()
        {
            return _DenominacionCliente + " (" + _CodigoCliente + ")";
        }
    }
}
