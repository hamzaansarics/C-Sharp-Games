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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 gg = new Form2();
            gg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 g = new Form8();
            g.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 a = new Form12();
            a.Show();
        }

        private void playNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            FormBorderStyle.None.Equals(true);
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About g = new About();
            g.ShowDialog();
        }

        private void instrunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowPlay g = new HowPlay();
            g.ShowDialog();
        }

        private void exittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
