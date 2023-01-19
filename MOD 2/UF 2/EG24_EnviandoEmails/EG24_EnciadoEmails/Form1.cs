using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG24_EnciadoEmails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.SmtpClient smtpGmail = new System.Net.Mail.SmtpClient();
            System.Net.Mail.MailMessage miCorreo = new System.Net.Mail.MailMessage();
            System.Net.NetworkCredential misDatos = new System.Net.NetworkCredential("gerardoc538g", "OC.c2658av");

            smtpGmail.Host = "smtp.gmail.com";
            smtpGmail.Port = 465;
            smtpGmail.Timeout = 20000;
            smtpGmail.EnableSsl = true;
            smtpGmail.Credentials = misDatos;
            

            miCorreo.To.Add("xerardocg@gmail.com");
            //miCorreo.bcc
            //miCorreo.cc
            miCorreo.Subject = "Voy a suspender a Gabri, no se lo digas";
            miCorreo.Body = "Mantenlo en secreto, que nadie lo sepa, de momento.";
            miCorreo.From = new System.Net.Mail.MailAddress("yo@yo.com", "El primer ministro de Reino Unido");

            smtpGmail.Send(miCorreo);

        }
    }
}
