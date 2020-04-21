using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGmae
{
    public partial class SinglepLayer11 : Form
    {
        bool gamestart ;
        int increment;
        public SinglepLayer11()
        {
            InitializeComponent();
        }

       
        public void chcekwiner()
        {
            bool winer = false;

            if (button1.Text == button2.Text && button2.Text == button3.Text && (!button1.Enabled))
                winer = true;
            if (button1.Text == button4.Text && button4.Text == button7.Text && (!button1.Enabled))
                winer = true;

            else if (button1.Text == button5.Text && button5.Text == button9.Text && (!button1.Enabled))
                winer = true;
            else if (button3.Text == button6.Text && button6.Text == button9.Text && (!button6.Enabled))
                winer = true;
            else if (button2.Text == button5.Text && button5.Text == button8.Text && (!button8.Enabled))
                winer = true;
            else if (button3.Text == button5.Text && button5.Text == button7.Text && (!button7.Enabled))
                winer = true;
            else if (button4.Text == button5.Text && button5.Text == button6.Text && (!button4.Enabled))
                winer = true;
            else if (button7.Text == button8.Text && button8.Text == button9.Text && (!button8.Enabled))
                winer = true;
            else if (button7.Text == button5.Text && button5.Text == button3.Text && (!button5.Enabled))
                winer = true;

            if (winer == true)
            {
                if (gamestart == false)
                {

                    loserorwiner gg = new loserorwiner();
                    gg.ShowDialog();

                    disablebuttons(false);

                }

                else
                {
                    loserorwiner gg = new loserorwiner();
                    gg.ShowDialog();
                    disablebuttons(false);
                }





            }


        }
        public void data()
        {
            if (increment == 5)
            {
                Gamedraw gg = new Gamedraw();
                gg.ShowDialog();
                disablebuttons(false);
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button2.Text == button5.Text && button5.Text == button8.Text && (!button5.Enabled || !button1.Enabled))
            {
                Gamedraw gg = new Gamedraw();
                gg.ShowDialog();
                disablebuttons(false);
            }

        }
        public void disablebuttons(bool enable)
        {
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button9.Enabled = enable;

        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamestart = true;
            increment = 0;
            startNewGameToolStripMenuItem.Enabled = false;
            resetGameToolStripMenuItem.Enabled = true;
            disablebuttons(true);
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGameToolStripMenuItem.Enabled = false;
            startNewGameToolStripMenuItem.Enabled = true;
            disablebuttons(false);
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void SinglepLayer11_Load(object sender, EventArgs e)
        {
            disablebuttons(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            increment++;

            if (button1.Enabled && button7.Enabled)
            {
                if (gamestart == true)
                {
                    button1.Text = "X";
                    gamestart = false;
                    button1.Enabled = false;
                }
                button7.Text = "O";
                button7.Enabled = false;
                gamestart = true;




            }
            else if (button1.Enabled && button9.Enabled)
            {
                if (gamestart == true)
                {
                    button1.Text = "X";
                    gamestart = false;
                    button1.Enabled = false;
                }
                button9.Text = "O";
                button9.Enabled = false;
                gamestart = true;




            }

            else if (button1.Enabled && button2.Enabled)

            {
                if (gamestart == true)
                {
                    button1.Text = "X";
                    gamestart = false;
                    button1.Enabled = false;
                }
                button2.Text = "O";
                button2.Enabled = false;
                gamestart = true;



            }
            else if (button1.Enabled && button4.Enabled)

            {
                if (gamestart == true)
                {
                    button1.Text = "X";
                    gamestart = false;
                    button1.Enabled = false;
                }
                button4.Text = "O";
                gamestart = true;
                button4.Enabled = false;



            }
            else if (button1.Enabled && button5.Enabled)

            {
                if (gamestart == true)
                {
                    button1.Text = "X";
                    gamestart = false;
                    button1.Enabled = false;
                }
                button5.Text = "O";
                gamestart = true;
                button5.Enabled = false;


            }
            data();
            chcekwiner();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            increment++;
            if (button2.Enabled && button3.Enabled)
            {
                if (gamestart == true)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                    gamestart = false;
                }
                button3.Text = "O";
                gamestart = true;
                button3.Enabled = false;



            }
            else if (button2.Enabled && button1.Enabled)
            {
                if (gamestart == true)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                    gamestart = false;
                }

                button1.Text = "O";
                gamestart = true;
                button1.Enabled = false;


            }
            else if (button2.Enabled && button5.Enabled)
            {
                if (gamestart == true)
                {

                    button2.Text = "X";
                    gamestart = false;
                    button2.Enabled = false;
                }
                button5.Text = "O";
                gamestart = true;
                button5.Enabled = false;


            }


            data();
            chcekwiner();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            increment++;
            if (button3.Enabled && button7.Enabled)
            {
                if (gamestart == true)
                {

                    button3.Text = "X";
                    button3.Enabled = false;
                    gamestart = false;
                }
                button7.Text = "O";
                gamestart = true;
                button7.Enabled = false;
            }

            else if (button3.Enabled && button6.Enabled)
            {
                if (gamestart == true)
                {

                    button3.Text = "X";
                    button3.Enabled = false;
                    gamestart = false;
                }
                button6.Text = "O";
                gamestart = true;
                button6.Enabled = false;


            }
            else if (button3.Enabled && button2.Enabled)
            {
                if (gamestart == true)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                    gamestart = false;
                }
                button2.Text = "O";
                gamestart = true;
                button2.Enabled = false;


            }
            else if (button3.Enabled && button5.Enabled)
            {
                if (gamestart == true)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                    gamestart = false;
                }
                button5.Text = "O";
                gamestart = true;
                button5.Enabled = false;

            }


            data();
            chcekwiner();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            increment++;

            if (button4.Enabled && button5.Enabled)
            {
                if (gamestart == true)
                {
                    button4.Text = "X";
                    button4.Enabled = false;
                    gamestart = false;

                }
                button5.Text = "O";
                button5.Enabled = false;
                gamestart = true;



            }
            else if (button4.Enabled && button1.Enabled)
            {
                if (gamestart == true)
                {
                    button4.Text = "X";
                    gamestart = false;
                    button4.Enabled = false;
                }
                button1.Text = "O";
                gamestart = true;

                button1.Enabled = false;


            }
            else if (button4.Enabled && button7.Enabled)
            {
                if (gamestart == true)
                {
                    button4.Text = "X";
                    button4.Enabled = false;
                    gamestart = false;
                }
                button7.Text = "O";
                gamestart = true;
                button7.Enabled = false;


            }
            else if (button4.Enabled && button8.Enabled)
            {
                if (gamestart == true)
                {
                    button4.Text = "X";
                    gamestart = false;
                    button4.Enabled = false;
                }
                button8.Text = "O";
                gamestart = true;
                button8.Enabled = false;


            }


            data();
            chcekwiner();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            increment++;

            if (button5.Enabled && button9.Enabled)
            {
                if (gamestart == true)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                    gamestart = false;
                }
                button9.Text = "O";
                button9.Enabled = false;
                gamestart = true;


            }
            else if (button5.Enabled && button4.Enabled)
            {
                if (gamestart == true)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                    gamestart = false;
                }
                button4.Text = "O";
                button4.Enabled = false;
                gamestart = true;


            }
            else if (button5.Enabled && button8.Enabled)
            {
                if (gamestart == true)
                {

                    button5.Text = "X";
                    button5.Enabled = false;
                    gamestart = false;
                }
                button8.Text = "O";
                button8.Enabled = false;
                gamestart = true;


            }
            else if (button5.Enabled && button6.Enabled)
            {
                if (gamestart == true)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                    gamestart = false;
                }
                button6.Text = "O";
                button6.Enabled = false;
                gamestart = true;


            }
            else if (button5.Enabled && button2.Enabled)
            {
                if (gamestart == true)
                {
                    button5.Text = "X";
                    button5.Enabled = false;
                    gamestart = false;
                }
                button2.Text = "O";
                button2.Enabled = false;
                gamestart = true;


            }


            data();
            chcekwiner();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            increment++;
            if (button6.Enabled && button8.Enabled)
            {
                if (gamestart == true)
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                    gamestart = false;
                }
                button8.Text = "O";
                gamestart = true;
                button8.Enabled = false;



            }
            else if (button6.Enabled && button9.Enabled)
            {
                if (gamestart == true)
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                    gamestart = false;
                }
                button9.Text = "O";
                gamestart = true;
                button9.Enabled = false;



            }
            else if (button6.Enabled && button3.Enabled)
            {
                if (gamestart == true)
                {
                    button6.Text = "X";
                    button6.Enabled = false;
                    gamestart = false;
                }
                button3.Text = "O";
                button3.Enabled = false;
                gamestart = true;


            }


            data();
            chcekwiner();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            increment++;

            if (button7.Enabled && button8.Enabled)
            {
                if (gamestart == true)
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                    gamestart = false;
                }
                button8.Text = "O";
                gamestart = true;
                button8.Enabled = false;


            }
            else if (button7.Enabled && button4.Enabled)
            {
                if (gamestart == true)
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                    gamestart = false;
                }
                button4.Text = "O";
                gamestart = true;
                button4.Enabled = false;

            }
            else if (button7.Enabled && button5.Enabled)
            {
                if (gamestart == true)
                {
                    button7.Text = "X";
                    button7.Enabled = false;
                    gamestart = false;
                }
                button5.Text = "O";
                gamestart = true;
                button5.Enabled = false;

            }


            data();
            chcekwiner();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            increment++;

            if (button8.Enabled && button7.Enabled)
            {
                if (gamestart == true)
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                    gamestart = false;
                }
                button7.Text = "O";
                button7.Enabled = false;
                gamestart = true;


            }
            else if (button8.Enabled && button9.Enabled)
            {
                if (gamestart == true)
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                    gamestart = false;
                }
                button9.Text = "O";
                button9.Enabled = false;
                gamestart = true;


            }
            else if (button8.Enabled && button6.Enabled)
            {
                if (gamestart == true)
                {
                    button8.Text = "X";
                    button8.Enabled = false;
                    gamestart = false;
                }
                button6.Text = "O";
                button6.Enabled = false;
                gamestart = true;


            }



            data();
            chcekwiner();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            increment++;
            if (button9.Enabled && button6.Enabled)
            {
                if (gamestart == true)
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                    gamestart = false;
                }
                button6.Text = "O";
                gamestart = true;
                button6.Enabled = false;



            }
            else if (button9.Enabled && button8.Enabled)
            {
                if (gamestart == true)
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                    gamestart = false;
                }
                button8.Text = "O";
                gamestart = true;
                button8.Enabled = false;



            }
            else if (button9.Enabled && button5.Enabled)
            {
                if (gamestart == true)
                {
                    button9.Text = "X";
                    button9.Enabled = false;
                    gamestart = false;
                }
                button5.Text = "O";
                gamestart = true;
                button5.Enabled = false;



            }



            data();
            chcekwiner();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options gg = new Options();
            gg.Show();
        }

        private void aboutTicTacToe2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About gg = new About();
            gg.ShowDialog();
        }
    }
}
