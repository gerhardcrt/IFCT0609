using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG15_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image logoClub;
            try
            {
                logoClub = Image.FromFile("logos\\1.jpg");
            }
            catch
            {
                logoClub = Image.FromFile("logos\\NoImage.jpg");
            }
            
            pictureBox1.Image = logoClub;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            logoClub = Image.FromFile("logos\\2.jpg");
            pictureBox2.Image = logoClub;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BorderStyle != BorderStyle.None)
            {
                pictureBox2.BorderStyle = BorderStyle.None;
            }
            else
            {
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            }

            pictureBox2.Mouseleave = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button.MouseUp;
             
            if(Button.mouseup == 0)
            {
                Button.Mouseup = false;
            }else(Button.mouseup = 0){

                Button.Mouseup = true;
            }

            int resultadoSorteo;
            Random aleatorio= New Random();

            resultadoSorteo = aleatorio.Next(2);

            timer1.Start();

            if (resultadoSorteo==0)
            { 
            int resultadosorteo;
            Random al = new Random();
            resultadosorteo = al.Next(2);

            Button.mouseleave = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.moversealaderecha = true;

            if (pictureBox1.moversealaderecha == false)
            {
                pictureBox1.moversealaderecha = true;
            }else
            {
                pictureBox1.moversealaderecha = false;
            }
        }
    }
}
