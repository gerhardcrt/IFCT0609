using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U_24_ControlTiempo
{
    public partial class ControlHorario: UserControl
    {
        private TimeSpan diferencia;
        /// <summary>
        /// Obtiene el valor de la diferencia entre los 2 selectores horarios. Si el segundo es menor que el primero devuelve -1
        /// </summary>
        public TimeSpan Diferencia { get { return diferencia; } }
        private DateTime horaCero = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
        public ControlHorario()
        {
            InitializeComponent();
        }

        private void ControlHorario_Load(object sender, EventArgs e)
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
               diferencia = new TimeSpan(-1);
            }
            else if (diferenciaHora.Ticks < 0 && ckbDiaMas.Checked)
            {
                fin = new TimeSpan(dtpFin.Value.AddDays(1).Ticks);
                diferenciaHora = fin.Subtract(inicio);
                diferencia = diferenciaHora;
            }
            else if (diferenciaHora.Ticks >= 0 && ckbDiaMas.Checked)
            {
                fin = new TimeSpan(dtpFin.Value.AddDays(1).Ticks);
                diferenciaHora = fin.Subtract(inicio);
                diferenciaMinutos = (diferenciaHora.TotalMinutes % 60).ToString();
                
                diferencia = new TimeSpan((int)Math.Truncate(diferenciaHora.TotalHours), int.Parse(diferenciaMinutos), 0);
                
            }
            else
            {
                diferencia = diferenciaHora;
            }
        }

    }
}
