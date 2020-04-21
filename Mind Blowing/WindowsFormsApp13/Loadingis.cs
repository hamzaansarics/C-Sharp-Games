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
    public partial class Loadingis : Form
    {
        public Loadingis()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            daata();
        }
        public void daata()
        {
            this.Hide();
            hamzawiner e = new hamzawiner();
            e.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
