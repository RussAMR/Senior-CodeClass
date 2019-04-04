using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Something.MouseEnter += (o, e) => Changecolor(Color.Red);
            Something.MouseLeave += (o, e) => Changecolor(Color.DeepPink);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Checkbox_Failsafe.Checked && DateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Random rand = new Random();
                for (int X = 0; X < pictureBox1.Width; X++)
                {
                    for (int Y = 0; Y < pictureBox1.Height; Y++)
                    {
                        b.SetPixel(X, Y, rand.Next(0, 2) == 0 ? Color.Brown : Color.Magenta);
                    }
                }
                pictureBox1.Image = b;
            }

        }

        public void Changecolor(Color c)
        {
            Something.BackColor = c;
        }

        private void Checkbox_Failsafe_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
        }
    }
}
