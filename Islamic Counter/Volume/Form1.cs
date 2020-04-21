using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (i <= 999999)
            {



               
                i++;
                Thread.Sleep(1000);
                textBox1.Text = Convert.ToString(i);
                


            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            i = 0;
            textBox1.Text = "0";
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                textBox1.Text = Convert.ToString(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //i = 0;
            textBox1.Text = "";
        }
    }
}
