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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            arustoki g = new arustoki();
            g.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            makingbar g = new makingbar();
            g.Show();
        }
    }
}
