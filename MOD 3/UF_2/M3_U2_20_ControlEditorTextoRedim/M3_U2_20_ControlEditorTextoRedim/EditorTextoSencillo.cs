using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_20_ControlEditorTextoRedim
{
    public partial class EditorTextoSencillo: UserControl
    {
        private int _tamanhoActualFuente;
        private bool _protegerSeleccion;
        private int estiloNCS;

        private Color _colorBotonesOriginal;
        private Color _colorBotonesPulsado;

        public EditorTextoSencillo()
        {
            InitializeComponent();
        }

        private void EditorTextoSencillo_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(1200,600);
            this.MinimumSize = new Size(600, 300);

            Font f = rtbContenido.Font;

            nudTamanhoFuente.Value = 20;

            //Cojo el tamaño de la fuente a partir del que hay en el NUD
            _tamanhoActualFuente = (int)nudTamanhoFuente.Value;
            rtbContenido.Font = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);

            _colorBotonesOriginal = Color.LightGray;
            _colorBotonesPulsado = Color.LightBlue;

            estiloNCS = 0;

            btnColorFuente.BackColor = Color.Black;

        }

        private void btnAumentarFuente_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;

            //Solo permito aumentar la fuente si es menor de 30
            if (_tamanhoActualFuente < 30)
            {
                _tamanhoActualFuente += 2;
                nudTamanhoFuente.Value = _tamanhoActualFuente;
            }

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
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style); //aumento la fuente
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
                rtbContenido.Focus();
            }
        }

        private void btnDisminuirFuente_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;

            //Solo permito disminuir la fuente si es mayor o igual a 6
            if (_tamanhoActualFuente >= 6)
            {
                _tamanhoActualFuente -= 2;
                nudTamanhoFuente.Value = _tamanhoActualFuente;
            }

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
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style); //aumento la fuente
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al rtb porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
                rtbContenido.Focus();
            }


        }

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
                    nudTamanhoFuente.Value = _tamanhoActualFuente;
                }


                _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
                nudTamanhoFuente.Value = _tamanhoActualFuente;

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

                if (rtbContenido.SelectionFont.Italic)
                {
                    btnCursiva.BackColor = _colorBotonesPulsado;
                    estiloNCS += 2;
                }
                else
                {
                    btnCursiva.BackColor = _colorBotonesOriginal;
                }

                if (rtbContenido.SelectionFont.Underline)
                {
                    btnSubrayado.BackColor = _colorBotonesPulsado;
                    estiloNCS += 4;
                }
                else
                {
                    btnSubrayado.BackColor = _colorBotonesOriginal;
                }


            }

        }

        private void nudTamanhoFuente_ValueChanged(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;

            _tamanhoActualFuente = (int)nudTamanhoFuente.Value;

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
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style); //aumento la fuente
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al rtb porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                if (rtbContenido.SelectedRtf.IndexOf("\\fs", rtbContenido.SelectedRtf.IndexOf("\\fs") + 1) == -1)
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
                rtbContenido.Focus();
            }
        }

        private void btnNegrita_Cursiva_Subrayado_Click(object sender, EventArgs e)
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
            else if (botonPulsado == btnCursiva)
            {
                if (botonPulsado.BackColor == _colorBotonesPulsado)
                {
                    estiloNCS -= 2;
                    botonPulsado.BackColor = _colorBotonesOriginal;
                }
                else
                {
                    estiloNCS += 2;
                    botonPulsado.BackColor = _colorBotonesPulsado;
                }
            }
            else if (botonPulsado == btnSubrayado)
            {
                if (botonPulsado.BackColor == _colorBotonesPulsado)
                {
                    estiloNCS -= 4;
                    botonPulsado.BackColor = _colorBotonesOriginal;
                }
                else
                {
                    estiloNCS += 4;
                    botonPulsado.BackColor = _colorBotonesPulsado;
                }
            }


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

        private void btnColorFuente_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;

            if (cdColorFuente.ShowDialog() == DialogResult.OK)
            {
                btnColorFuente.BackColor = cdColorFuente.Color;
            }

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
                    rtbContenido.SelectionColor = btnColorFuente.BackColor;
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al rtb porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                rtbContenido.SelectionColor = btnColorFuente.BackColor;
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

    }
}
