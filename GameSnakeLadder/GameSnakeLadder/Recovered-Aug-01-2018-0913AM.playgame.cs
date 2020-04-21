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
    public partial class playgame : Form
    {
        //.......Player 1..........//


        int[] pos = new int[100];
        int p = 0;
        int dicevalue, x = 25, y = 607;

        //.......Player 2......//



        int[] pos2 = new int[100];
        int r = 0;
        int dicevaluesnewisap, s = 25, n = 607;
        bool gold = false, blue = false;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        public playgame(string k,string t)
        {
            InitializeComponent();
            label18.Text = k;
            label19.Text= t;
          
          
        }
        
        private void playgame_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox4.Image = Image.FromFile(@"C:\Users\Hamza\source\repos\GameSnakeLadder\GameSnakeLadder\Resources\Roolthedice.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            dicevalue = logics.rolldice(pictureBox9);

            label2.Text = dicevalue.ToString();

            if (label2.Text == "6" && gold == false)
            {
                pictureBox2.Visible = false;
                pictureBox7.Visible = true;
                gold = true;
                pictureBox7.Location = new Point(x, y);
                label1.Text = x.ToString();
                label4.Text = y.ToString();
                pos[p] = 1;

            }

            if (gold == true)
            {

                pictureBox7.Location = new Point(x, y);

                label4.Text = x.ToString();
                label5.Text = y.ToString();
                logics a = new logics();
                a.move(ref x, ref y, ref p, dicevalue,  pictureBox7, label1, ref pos,label1);
                p = logics.back(ref x, ref y, p, pictureBox7);
                p = logics.forward(ref x, ref y, p, pictureBox7);
            }
            if (p == 100)
            {
                MessageBox.Show(label18.Text+" win the game","Winner",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            dicevaluesnewisap = logics.rolldice(pictureBox4);

            label16.Text = dicevaluesnewisap.ToString();

            if (label16.Text == "6" && blue == false)
            {
                pictureBox3.Visible = false;
                pictureBox8.Visible = true;
                blue = true;
                pictureBox8.Location = new Point(s, n);
                label1.Text = s.ToString();
                label1.Text = n.ToString();
                pos2[r] = 1;

            }

            if (blue == true)
            {

                pictureBox8.Location = new Point(s, n);

                label14.Text = s.ToString();
                label12.Text = n.ToString();
                logics a = new logics();
                a.move(ref s, ref n, ref r, dicevaluesnewisap, pictureBox8, label10, ref pos2, label10);
                r = logics.back(ref s, ref n, r, pictureBox8);
                r = logics.forward(ref s, ref n, r, pictureBox8);
            }
            if (r == 100)
            {
                MessageBox.Show(label19.Text+ " win the game", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Enabled = false;
                button1.Enabled = false;
            }

        }
    }
}
