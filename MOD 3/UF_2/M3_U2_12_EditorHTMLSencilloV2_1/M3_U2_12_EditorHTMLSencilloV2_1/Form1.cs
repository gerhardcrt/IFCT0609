using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_12_EditorHTMLSencilloV2_1
{
    public partial class Form1 : Form
    {
        private string titulo = "Mi primera prueba";
        public string textoHTML { get; set; }

        private int _tamanhoActualFuente = 12;
        private bool _protegerSeleccion;
        private int estiloNCS = 0;

        private Color _colorBotonesOriginal = Color.LightGray;
        private Color _colorBotonesPulsado = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarHTML_Click(object sender, EventArgs e)
        {
            string contenidoEditado = "";
            int inicioTextoReal = rtbContenido.Rtf.IndexOf("\\pard");

            contenidoEditado = rtbContenido.Rtf;
            contenidoEditado = contenidoEditado.Substring(inicioTextoReal+5);
            contenidoEditado = contenidoEditado.TrimEnd(new Char[] { '\r', '\n', '}' });

            //Esto hace los saltos de línea
            contenidoEditado = contenidoEditado.Replace("\\par", "<br/>");
            //Esto marca la negrita
            contenidoEditado = contenidoEditado.Replace("\\b0", "</b>");
            contenidoEditado = contenidoEditado.Replace("\\b", "<b>");

            //Arreglo las vocales con tilde
            //contenidoEditado = contenidoEditado.Replace("\\'e1", "á");
            //contenidoEditado = contenidoEditado.Replace("\\'e9", "é");
            //contenidoEditado = contenidoEditado.Replace("\\'ed", "í");
            //contenidoEditado = contenidoEditado.Replace("\\'f3", "ó");
            //contenidoEditado = contenidoEditado.Replace("\\'fa", "ú");
            //contenidoEditado = contenidoEditado.Replace("\\'c1", "Á");
            //contenidoEditado = contenidoEditado.Replace("\\'c9", "É");
            //contenidoEditado = contenidoEditado.Replace("\\'cd", "Í");
            //contenidoEditado = contenidoEditado.Replace("\\'d3", "Ó");
            //contenidoEditado = contenidoEditado.Replace("\\'da", "Ú");
            //contenidoEditado = contenidoEditado.Replace("\\'f1", "ñ");
            //contenidoEditado = contenidoEditado.Replace("\\'d1", "Ñ");
            
            contenidoEditado = SubstituirCaracteres(contenidoEditado);
            Auxiliares.ReemplazarPalabra(ref contenidoEditado, "\\f", "");
            Auxiliares.ReemplazarPalabra(ref contenidoEditado, "\\f", "");

            textoHTML += contenidoEditado;
            textoHTML += "</BODY></HTML>";

            webBrowser1.DocumentText = textoHTML;

        }

        private string SubstituirCaracteres(string cadenaOriginal)
        {
            string cadenaEditada=cadenaOriginal;
            string[] datosViejos = new string[] { "\\'e1", "\\'e9", "\\'ed", "\\'f3", "\\'fa", "\\'c1", "\\'c9", "\\'cd", "\\'d3", "\\'da", "\\'f1", "\\'d1" };
            string[] datosNuevos = new string[] { "á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú", "ñ", "Ñ" };

            for(int i=0;i<datosViejos.Length;i++)
            {
                cadenaEditada = cadenaEditada.Replace(datosViejos[i], datosNuevos[i]);
            }

            return cadenaEditada;
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;
            Button botonPulsado = (Button)sender;

            //Compruebo que botón ha pulsado, si está ya activado, le quito el estilo, y si no se lo añado
            //Modifico el color del botón
            if (botonPulsado == btnNegrita)
            {
                if (botonPulsado.BackColor == _colorBotonesPulsado)
                {
                    estiloNCS -= 1;
                    botonPulsado.BackColor = _colorBotonesOriginal;
                }
                else
                {
                    estiloNCS += 1;
                    botonPulsado.BackColor = _colorBotonesPulsado;
                }
            }
            //else if (botonPulsado == btnCursiva)
            //{
            //    if (botonPulsado.BackColor == _colorBotonesPulsado)
            //    {
            //        estiloNCS -= 2;
            //        botonPulsado.BackColor = _colorBotonesOriginal;
            //    }
            //    else
            //    {
            //        estiloNCS += 2;
            //        botonPulsado.BackColor = _colorBotonesPulsado;
            //    }
            //}
            //else if (botonPulsado == btnSubrayado)
            //{
            //    if (botonPulsado.BackColor == _colorBotonesPulsado)
            //    {
            //        estiloNCS -= 4;
            //        botonPulsado.BackColor = _colorBotonesOriginal;
            //    }
            //    else
            //    {
            //        estiloNCS += 4;
            //        botonPulsado.BackColor = _colorBotonesPulsado;
            //    }
            //}


            //Si no tienes un fragmento de texto seleccionado, aumento toda la palabra (salvo que esté al final o al principio de la misma)
            if (rtbContenido.SelectedText.Length == 0)
            {
                //Si estoy en medio de una palabra
                //  Aumento toda la palabra 

                //Cojo la posición actual del cursor para ver si estamos en la parte "media" de una palabra
                posicionActual = rtbContenido.SelectionStart;

                //Que no esté al final del texto, ni al principio, ni al final de una palabra, ni al principio de una palabra
                if (posicionActual + 1 <= rtbContenido.Text.Length && char.IsLetter(rtbContenido.Text[posicionActual]) && posicionActual > 0 && char.IsLetter(rtbContenido.Text[posicionActual - 1]))
                {
                    //utilizo las funciones auxiliares para calcular la posición inicial y la longitud de la palabra para seleccionarla
                    inicioPalabra = CalcularInicioPalabra(rtbContenido.Text, posicionActual);
                    finalPalabra = CalcularFinalPalabra(rtbContenido.Text, posicionActual);
                    longitudPalabra = finalPalabra - inicioPalabra;

                    //utilizo el boolean Para que no salte el evento selected change que deja fuente como está
                    _protegerSeleccion = true;
                    rtbContenido.Select(inicioPalabra, longitudPalabra); //Selecciono la palabra
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, (FontStyle)estiloNCS); //aumento la fuente
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al rtb porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, (FontStyle)estiloNCS);
                rtbContenido.Focus();
            }
        }

        #region "FuncionesAuxiliares"

        private int CalcularFinalPalabra(string frase, int posicion)
        {

            //mientras no encuentre algo que no sea un caracter
            //o no llegue al final de la frase
            //aumento una posicion
            do
            {
                posicion++;
            } while (posicion < frase.Length && char.IsLetter(frase[posicion]));

            return posicion;
        }

        private int CalcularInicioPalabra(string frase, int posicion)
        {

            //mientras no encuentre algo que no sea un caracter
            //o no llegue al final de la frase
            //aumento una posicion
            do
            {
                posicion--;
            } while (posicion > 0 && char.IsLetter(frase[posicion]));

            if (posicion != 0) { return posicion + 1; }
            else { return 0; }

        }

        #endregion

        private void rtbContenido_SelectionChanged(object sender, EventArgs e)
        {
            string textoRtf;
            bool textoMezclado = false;

            if (!_protegerSeleccion)
            {
                //si el tamaño de la fuente es un "tuttifruti", bloquear el numericUpDown
                //  Recorro toda la seleccion y miro la fuente de la primera letra
                //  Si hay un tamaño distinto en el resto de seleccion significa que hay mezcla
                textoRtf = rtbContenido.SelectedRtf;

                if (textoRtf.Contains("\\f1\\")) { textoMezclado = true; }

                if (!textoMezclado)
                {
                    _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
                    //nudTamanhoFuente.Value = _tamanhoActualFuente;
                }


                _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
                //nudTamanhoFuente.Value = _tamanhoActualFuente;

                estiloNCS = 0;

                if (rtbContenido.SelectionFont.Bold)
                {
                    btnNegrita.BackColor = _colorBotonesPulsado;
                    estiloNCS += 1;
                }
                else
                {
                    btnNegrita.BackColor = _colorBotonesOriginal;
                }

                //if (rtbContenido.SelectionFont.Italic)
                //{
                //    btnCursiva.BackColor = _colorBotonesPulsado;
                //    estiloNCS += 2;
                //}
                //else
                //{
                //    btnCursiva.BackColor = _colorBotonesOriginal;
                //}

                //if (rtbContenido.SelectionFont.Underline)
                //{
                //    btnSubrayado.BackColor = _colorBotonesPulsado;
                //    estiloNCS += 4;
                //}
                //else
                //{
                //    btnSubrayado.BackColor = _colorBotonesOriginal;
                //}


            }
        }
    }
}
