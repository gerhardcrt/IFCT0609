using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorSencillo
{
    public partial class Form1 : Form
    {
        private int _tamanhoActualFuente;
        private bool _protegerSeleccion;
        private bool _negrita;

        private Color _colorBotonesOriginal;
        private Color _colorBotonesPulsado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font f = rtbContenido.Font;

            //Cojo el tamaño de la fuente a partir del que hay en el NUD
            _tamanhoActualFuente = (int)nudTamanhoFuente.Value;
            rtbContenido.Font = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);

            _colorBotonesOriginal = btnNegrita.BackColor;
            _colorBotonesPulsado = Color.DarkGray;

            _negrita = false;
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
            if (!_protegerSeleccion)
            {
                _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
                nudTamanhoFuente.Value = _tamanhoActualFuente;

                if (rtbContenido.SelectionFont.Bold)
                {
                    btnNegrita.BackColor = _colorBotonesPulsado;
                }
                else
                {
                    btnNegrita.BackColor = _colorBotonesOriginal;
                }


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
                rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
                rtbContenido.Focus();
            }
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;
            FontStyle estilo = new FontStyle();
            int posicionActual;
            int inicioPalabra, finalPalabra, longitudPalabra;

            //cambio el bold o no (pongo lo contrario)
            _negrita = !_negrita;
            if (_negrita) { estilo = FontStyle.Bold; btnNegrita.BackColor = _colorBotonesPulsado; }
            else { estilo = FontStyle.Regular; btnNegrita.BackColor = _colorBotonesOriginal; }

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
                    rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, estilo); //aumento la fuente
                    rtbContenido.Select(posicionActual, 0); //Dejo el cursor donde estaba
                    _protegerSeleccion = false; //desactivo la protección del select
                    rtbContenido.Focus(); //devuelvo el foco al rtb porque estará en el botón al haberlo pulsado
                }
            }
            else
            {
                //Si hay algo selecionado: Cambio la fuente y recuepero el foco que está en el botón
                rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, estilo);
                rtbContenido.Focus();
            }
        }
    }
}
