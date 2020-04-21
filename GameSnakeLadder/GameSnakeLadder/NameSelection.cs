using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSnakeLadder
{
    public partial class NameSelection : Form
    {
        public NameSelection()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Your Name then NEXT","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

             else
            {

                this.Hide();
                playgame k = new playgame(textBox1.Text,textBox2.Text);
                k.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options g = new Options();
            g.Show();
        }
    }
}
