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
    public partial class arustoki : Form
    {
        public arustoki()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            ddata();
        }
        public void ddata()
        {
            this.Hide();
            zeeshansayen d = new zeeshansayen();
            d.Show();
        }
    }
}
