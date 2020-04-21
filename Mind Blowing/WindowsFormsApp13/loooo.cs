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
    public partial class loooo : Form
    {
        public loooo()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            gameover();
        }
        public void gameover()
        {
            this.Hide();
            farhan g = new farhan();
            g.Show();
        }
    }
}
