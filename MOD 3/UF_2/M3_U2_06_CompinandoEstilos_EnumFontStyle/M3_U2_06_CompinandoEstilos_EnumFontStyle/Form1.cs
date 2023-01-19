using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_06_CompinandoEstilos_EnumFontStyle
{
    public partial class Form1 : Form
    {
        int estiloActual;
        Font fuenteActual = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Regular);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbTexto.Font = fuenteActual;
            rtbTexto.Text = "Hola Gabri, gracias por tu aportación !";

            btnNegrita.Text = "N";
            btnCursiva.Text = "K";
            btnSubrayado.Text = "S";

            btnNegrita.BackColor = Color.LightGray;
            btnCursiva.BackColor = Color.LightGray;
            btnSubrayado.BackColor = Color.LightGray;

            estiloActual = 0;
        }

        private void CambiarEstilo(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;

            //botonPulsado.BackColor = Color.LightGray;
            //botonPulsado.BackColor = Color.LightGreen;

            if (botonPulsado.Text == "N")
            {
                if (rtbTexto.SelectionFont.Bold)
                {
                    estiloActual -= 1;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGray;

                }
                else
                {
                    estiloActual += 1;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGreen;

                }
            }

            if (botonPulsado.Text == "K")
            {
                if (rtbTexto.SelectionFont.Italic)
                {
                    estiloActual -= 2;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGray;
                }
                else
                {
                    estiloActual += 2;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGreen;
                }
            }

            if (botonPulsado.Text == "S")
            {
                if (rtbTexto.SelectionFont.Underline)
                {
                    estiloActual -= 4;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGray;
                }
                else
                {
                    estiloActual += 4;
                    rtbTexto.SelectionFont = new Font(fuenteActual.FontFamily, fuenteActual.Size, (FontStyle)estiloActual);
                    botonPulsado.BackColor = Color.LightGreen;
                }
            }

            

            rtbTexto.Focus();
           
        }

    }
}
