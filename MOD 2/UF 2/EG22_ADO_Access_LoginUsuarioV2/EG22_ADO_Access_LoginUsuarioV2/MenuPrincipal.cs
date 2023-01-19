using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG22_ADO_Access_LoginUsuarioV2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void CerrandoFormulario(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms[0].Show();
            Application.OpenForms[0].Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
