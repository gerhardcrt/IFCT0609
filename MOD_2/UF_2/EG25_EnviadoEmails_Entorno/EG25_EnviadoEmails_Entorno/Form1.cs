using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG25_EnviadoEmails_Entorno
{
    public partial class btnAgregar : Form
    {
        private decimal tamanhoAdjuntos = 0.0m;

        public btnAgregar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Class1 datosConf = new Class1();

            System.Net.Mail.SmtpClient smtpGmail = new System.Net.Mail.SmtpClient();
            System.Net.Mail.MailMessage miCorreo = new System.Net.Mail.MailMessage();
            System.Net.NetworkCredential misDatos = new System.Net.NetworkCredential(datosConf.email, datosConf.pass);

            //smtpGmail.Host = "smtp.gmail.com";
            smtpGmail.Host = "smtp-mail.outlook.com";
            smtpGmail.Port = 587;
            smtpGmail.Timeout = 20000;
            smtpGmail.EnableSsl = true;
            smtpGmail.Credentials = misDatos;

            //En el para recorre el listbox
            foreach (string correo in lbDestinatarios.Items)
            {
                miCorreo.To.Add(correo);
            }
           
            //miCorreo.bcc
            //miCorreo.cc
            miCorreo.Subject = txtTitulo.Text;
            miCorreo.Body = txtCuerpo.Text;
            miCorreo.From = new System.Net.Mail.MailAddress(datosConf.email, "Profesor");
            miCorreo.IsBodyHtml = true;
            
            if (lbAdjuntos.Items.Count > 0)
            {
                foreach (string ruta in lbAdjuntos.Items)
                {
                    miCorreo.Attachments.Add(new System.Net.Mail.Attachment(ruta));
                }
            }
            
            


            try
            {
                smtpGmail.Send(miCorreo);
                lbDestinatarios.Items.Clear();
                txtCuerpo.Clear();
                txtPara.Clear();
                txtTitulo.Clear();
            }
            catch { MessageBox.Show("Algo ha fallado... pole una vela a San Pancracio..."); }


        }

        private bool ValidarEmail(string email)
        {
            //int posicionArroba1, posicionArroba2, posicionPunto;
            //string[] caracteresNoValidos = new string[] { "!", "#", "?", "¿", "[" };

            //posicionArroba1 = email.IndexOf('@');
            //posicionArroba2 = email.LastIndexOf('@');
            //posicionPunto = email.LastIndexOf('.');

            ////Como mínimo la longuitud tiene que ser 7
            //// x @ xx . xx
            //if (email.Length<7) { return false; }

            ////Comprobamos si tiene caracteres no válidos
            //foreach (string caracter in caracteresNoValidos)
            //{
            //    if (email.Contains(caracter)) { return false; }
            //}

            ////Si no hay arrobas o puntos la dirección es incorrecta
            //if (posicionArroba1==-1 || posicionPunto == -1) { return false; }

            ////Si hay más de una arroba (las posiciones son distintas) y sería incorrecto el email
            //if (posicionArroba1!=posicionArroba2) { return false; }

            ////Si la arroba no está a la izquierda del punto la dirección es incorrecta
            //if (posicionArroba1 >= posicionPunto) { return false; }

            ////para asumir que hay 3 trozos, la arroba no puede ser la primera letra
            ////el punto no puede ser el último, ni el penúltimo
            ////entre la arroba y el punto tiene que haber por lo menos 2 caracteres
            //if (posicionArroba1==0 || posicionPunto>email.Length-3 || posicionPunto-posicionArroba1<3) { return false; } 

            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)) { return false; }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txtPara.Text))
            {
                lbDestinatarios.Items.Add(txtPara.Text);
                txtPara.Clear();
            }
        }

        private void btnAgregarAdjunto_Click(object sender, EventArgs e)
        {
            //Abro el openfileDialog
            //  Si la selección de un archivo es correcta
            //     Agrego el nombre y la ruta del fichero al listbox de adjuntos
            //     Creo un objeto file Info con dicha ruta
            //     Obtengo el tamaño del fichero del objeto file info
            //     Actualizo el label de tamaño con ese nuevo tamaño
            System.IO.FileInfo infoAdjunto;
            long tamanhoAdjuntoActualBytes;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                infoAdjunto = new System.IO.FileInfo(openFileDialog1.FileName);
                lbAdjuntos.Items.Add(infoAdjunto.FullName);
                tamanhoAdjuntoActualBytes = infoAdjunto.Length;

                tamanhoAdjuntos += tamanhoAdjuntoActualBytes / (decimal)1024 / (decimal)1024;
                lTamanhoAdjuntos.Text = Math.Round(tamanhoAdjuntos, 2).ToString();

            }

        }
    }
}
