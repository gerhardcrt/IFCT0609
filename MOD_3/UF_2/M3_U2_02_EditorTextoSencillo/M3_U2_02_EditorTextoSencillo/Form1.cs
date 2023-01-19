using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_02_EditorTextoSencillo
{
    public partial class Form1 : Form
    {
        private int _tamanhoActualFuente;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
            labTamanhoFuente.Text = _tamanhoActualFuente.ToString();
        }

        private void btnAumentarFuente_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;

            if (_tamanhoActualFuente < 30)
            {
                _tamanhoActualFuente += 2;
                labTamanhoFuente.Text = _tamanhoActualFuente.ToString();
            }
            rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
            rtbContenido.Focus();

        }

        private void btnDisminuirFuente_Click(object sender, EventArgs e)
        {
            Font f = rtbContenido.SelectionFont;

            if (_tamanhoActualFuente >= 2)
            {
                _tamanhoActualFuente -= 2;
                labTamanhoFuente.Text = _tamanhoActualFuente.ToString();
            }
            rtbContenido.SelectionFont = new Font(f.FontFamily, _tamanhoActualFuente, f.Style);
            rtbContenido.Focus();
        }

        private void rtbContenido_SelectionChanged(object sender, EventArgs e)
        {
            _tamanhoActualFuente = (int)rtbContenido.SelectionFont.Size;
            labTamanhoFuente.Text = _tamanhoActualFuente.ToString();
        }
    }
}
