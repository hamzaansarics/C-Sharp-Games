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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            lldd s = new lldd();
            s.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loadingis g = new Loadingis();
            g.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            laoding g = new laoding();
            g.Show();
        }
    }
}
