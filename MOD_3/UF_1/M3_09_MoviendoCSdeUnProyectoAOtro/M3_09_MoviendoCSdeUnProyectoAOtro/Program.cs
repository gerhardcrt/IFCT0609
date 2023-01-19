using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using M3_06_InformaticosRiquinhos;

namespace M3_09_MoviendoCSdeUnProyectoAOtro
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new M3_08_InformaticoRiquinhos_POO_ListBox.frmPrincipal());
        }
    }
}
