using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_27_ControlFecha
{
    public partial class CuadroFecha: UserControl, INotifyPropertyChanged
    {
        public event EventHandler CambioFecha;
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime fecha;
        public DateTime Fecha
        {
            get
            { return fecha; }
            set
            {
                fecha = value;
                OnPropertyChanged();
            }
        }

        public CuadroFecha()
        {
            InitializeComponent();
        }

        protected void OnPropertyChanged()
        {
            textBox1.Text = Fecha.Day.ToString();
            textBox2.Text = Fecha.Month.ToString();
            textBox3.Text = Fecha.Year.ToString();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fecha"));
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = DateTime.Today.Day.ToString();
            //textBox2.Text = DateTime.Today.Month.ToString();
            //textBox3.Text = DateTime.Today.Year.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            DateTime f;

            try
            {
                f = new DateTime(int.Parse(textBox3.Text), int.Parse(textBox2.Text), int.Parse(textBox1.Text));
                fecha = f;
            }
            catch { }

            CambioFecha?.Invoke(this, EventArgs.Empty);
 
        }

 
    }
}
