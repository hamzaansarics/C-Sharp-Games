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
    public partial class Lodingkas : Form
    {
        public Lodingkas()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Lodingkas_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FormBorderStyle.None.Equals(true);
            timer1.Enabled = false;
            timer1.Stop();
            khan();
        }
        public void khan()
        {
            this.Hide();
            hamzalover a = new hamzalover();
            a.Show();
        }
    }
}
