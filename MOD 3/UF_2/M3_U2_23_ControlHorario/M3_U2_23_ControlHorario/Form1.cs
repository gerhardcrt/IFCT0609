using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_23_ControlHorario
{
    public partial class Form1 : Form
    {
        DateTime horaCero = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            dtpInicio.Value = horaCero;
            dtpFin.Value = horaCero;
        }

        private void dtps_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diferenciaHora;
            TimeSpan inicio, fin;
            string diferenciaMinutos;

            inicio = new TimeSpan(dtpInicio.Value.Ticks);
            fin = new TimeSpan(dtpFin.Value.Ticks);

            diferenciaHora = fin.Subtract(inicio);


            if (diferenciaHora.Ticks < 0 && !ckbDiaMas.Checked)
            {
               label1.Text = "Error";
            }
            else if (diferenciaHora.Ticks < 0 && ckbDiaMas.Checked)
            {
                fin = new TimeSpan(dtpFin.Value.AddDays(1).Ticks);
                diferenciaHora = fin.Subtract(inicio);
                label1.Text = diferenciaHora.ToString();
            }
            else if (diferenciaHora.Ticks > 0 && ckbDiaMas.Checked)
            {
                fin = new TimeSpan(dtpFin.Value.AddDays(1).Ticks);
                diferenciaHora = fin.Subtract(inicio);
                diferenciaMinutos = (diferenciaHora.TotalMinutes % 60).ToString();
                if (diferenciaMinutos.Length == 1) { diferenciaMinutos = "0" + diferenciaMinutos; }

                label1.Text = Math.Truncate(diferenciaHora.TotalHours).ToString() + ":" + diferenciaMinutos + ":00";

            }
            else
            {
                label1.Text = diferenciaHora.ToString();
            }

            

        }


    }
}
