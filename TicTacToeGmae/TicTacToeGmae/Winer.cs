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
    public partial class Winer : Form
    {
        public Winer(string v1)
        {
           

            InitializeComponent();
            label2.Text = v1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayBox gg = new PlayBox();
            gg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
