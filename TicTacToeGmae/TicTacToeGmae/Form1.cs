using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TicTacToeGmae
{
    public partial class Form1 :MetroForm
    {
        public Form1()
        {
           
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void MainForm()
        {
            this.Hide();
            Menuform g = new Menuform();
            g.Show();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            MainForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
