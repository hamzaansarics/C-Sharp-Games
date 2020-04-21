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
    public partial class makingbar : Form
    {
        public makingbar()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
            timer1.Stop();
            dataa();
        }
        public void dataa()
        {
            this.Hide();
            rizwanbhai b = new rizwanbhai();
            b.Show();
        }

        private void makingbar_Load(object sender, EventArgs e)
        {

        }
    }
}
