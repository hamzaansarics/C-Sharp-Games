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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 hh = new Form9();
            hh.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 g = new Form10();
            g.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 g = new Form11();
            g.Show();
        }
    }
}
