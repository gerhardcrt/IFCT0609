using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_U2_18_Resize
{
    public partial class Form1 : Form
    {
        decimal proporcion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 400;

            proporcion = this.Height / this.Width;

            button5.Width = 100;
            button5.Height = 50;

            button6.Width = 100;
            button6.Height = 50;

            button7.Width = 100;
            button7.Height = 50;

            textBox1.Top = 80;
            textBox1.Left = 20;

            textBox1.Width = 700;
            textBox1.Height = 250;

            button5.Text = this.Height.ToString() + " | " + this.Width.ToString();

        }

        private void textBox1_Move(object sender, EventArgs e)
        {
            label1.Text = textBox1.Top.ToString();
            label2.Text = textBox1.Left.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Top -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Top += 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Left += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Left -= 10;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            //MessageBox.Show("Ay");
            button6.Text = this.Height.ToString() + " | " + this.Width.ToString();
            this.Width = this.Height * 2;

            textBox1.Width = (int)((float)this.Width * 0.875f);
            textBox1.Height = (int)((float)this.Width * 0.3125f);
            textBox1.Top = (int)((float)this.Width * 0.1f);

            button5.Width = (int)((float)this.Width * 0.125f);
            button5.Height = (int)((float)this.Width * 0.0625f);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);


            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);

            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;


        }

    }
}
