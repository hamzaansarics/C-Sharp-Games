using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            End g = new End();
            g.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 g = new Form6();
            g.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            lood gg = new lood();
            gg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
