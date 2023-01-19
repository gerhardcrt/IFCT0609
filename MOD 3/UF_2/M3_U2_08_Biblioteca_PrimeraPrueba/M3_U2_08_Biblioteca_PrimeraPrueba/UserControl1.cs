using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M3_U2_08_Biblioteca_PrimeraPrueba
{
    public partial class CaluladoraBasicaVerde: UserControl
    {
        [Browsable(false)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        
        [Browsable(false)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        [Browsable(false)]
        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }

        
        private readonly Color colorFondo = Color.FromArgb(192, 255, 192);

        [
            Category("Chorradas"),
            Description("Un colorcillo para colorear"),
        ]
        public Color ColorFondo { 
            set
            {
                this.BackColor = value;
                Invalidate();
            }
            //get => colorFondo;
            get
            {
                return colorFondo;
            }
            
        }
        

        public CaluladoraBasicaVerde()
        {
            InitializeComponent();
        }

        private void CaluladoraBasica_Load(object sender, EventArgs e)
        {

            labResultado.Text = "";
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";

            this.BackColor = colorFondo;
        }


        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            int numero;
            TextBox s = (TextBox)sender;

            if (!int.TryParse(s.Text, out numero))
            {
                s.Text = "0";
                s.Select(0, 1);
                s.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbSumar.Checked)
            {
                labResultado.Text = (int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text)).ToString();
            }
            else
            {
                labResultado.Text = (int.Parse(txtNumero1.Text) - int.Parse(txtNumero2.Text)).ToString();
            }
        }

        //private void txtNumero1_Validating(object sender, CancelEventArgs e)
        //{
        //    int numero;

        //    if (!int.TryParse(txtNumero1.Text, out numero))
        //    {
        //        txtNumero1.Text = "0";
        //        txtNumero1.Select(0, 1);
        //        txtNumero1.Focus();
        //    }
        //}
    }
}
