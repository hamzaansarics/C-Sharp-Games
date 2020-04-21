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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            looding gg = new looding();
            gg.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            lodingbar g = new lodingbar();
            g.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            looddinng i = new looddinng();
            i.Show();
        }
    }
}
