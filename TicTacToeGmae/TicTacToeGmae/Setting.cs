using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGmae
{
    public partial class Setting : Form
    {
        
        public Setting()
        {
           
            InitializeComponent();
            timer1.Start();
        }

     public void playbox()
        {
            this.Hide();
            PlayBox g = new PlayBox();
            g.Show();


        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            playbox();
        }
    }
}
