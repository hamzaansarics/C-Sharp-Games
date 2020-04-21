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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            lodding gg = new lodding();
            gg.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            loooo i = new loooo();
            i.Show();
        }
    }
}
