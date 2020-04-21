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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 o = new Form13();
            o.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 s = new Form14();
            s.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            ansari y = new ansari();
            y.Show();
        }
    }
}
