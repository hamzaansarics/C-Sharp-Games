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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
           
        }

        private void Options_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinglepLayer11 gg = new SinglepLayer11();
            gg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Menuform f = new Menuform();
          
            
            this.Hide();
            Setting g = new Setting();
            g.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
