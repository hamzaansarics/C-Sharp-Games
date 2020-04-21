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
        public playgame()
        {
            InitializeComponent();
        }

        private void playgame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            dicevalue = logics.rolldice(pictureBox4);

            label2.Text = dicevalue.ToString();

            if (label2.Text == "6" && gold == false)
            {
                pictureBox2.Visible = false;
                pictureBox5.Visible = true;
                gold = true;
                pictureBox5.Location = new Point(x, y);
                label3.Text = x.ToString();
                label5.Text = y.ToString();
                pos[p] = 1;

            }

            if (gold == true)
            {

                pictureBox5.Location = new Point(x, y);

                label3.Text = x.ToString();
                label5.Text = y.ToString();
                logics a = new logics();
                a.move(ref x, ref y, ref p, dicevalue, pictureBox5, label7, ref pos);
                p = logics.back(ref x, ref y, p, pictureBox5);
                p = logics.forward(ref x, ref y, p, pictureBox5);
            }
            if (p == 100)
            {
                MessageBox.Show("Player one win the game");
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
                pictureBox6.Visible = true;
                blue = true;
                pictureBox6.Location = new Point(s, n);
                label14.Text = s.ToString();
                label12.Text = n.ToString();
                pos2[r] = 1;

            }

            if (blue == true)
            {

                pictureBox6.Location = new Point(s, n);

                label14.Text = s.ToString();
                label12.Text = n.ToString();
                logics a = new logics();
                a.move(ref s, ref n, ref r, dicevaluesnewisap, pictureBox6, label10, ref pos2);
                r = logics.back(ref s, ref n, r, pictureBox6);
                r = logics.forward(ref s, ref n, r, pictureBox6);
            }
            if (r == 100)
            {
                MessageBox.Show("Player two win the game");
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
