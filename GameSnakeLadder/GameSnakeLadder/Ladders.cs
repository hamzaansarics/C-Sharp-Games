using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSnakeLadder
{
    public partial class Ladders : Form
    {
        public Ladders()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            playgame();
        }
        public void playgame()
        {
            this.Hide();
            Options g = new Options();
            g.Show();

        }
    }
}
