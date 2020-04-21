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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            ldi gg = new ldi();
            gg.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            nld g = new nld();
            g.Show();
        }
    }
}
