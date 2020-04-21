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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            lod g = new lod();
            g.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
