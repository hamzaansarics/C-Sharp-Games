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
    public partial class PlayBox : Form
    {
        bool playinggame ;
        int increment;
        public PlayBox()
        {
          
           
            
            InitializeComponent();
        }
        
        

        public void newfun(bool enable)
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

        private void PlayBox_Load(object sender, EventArgs e)
        {
            newfun(false);
        }

        private void newStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

       

        private void Allclick(object sender, EventArgs e)
        {
            
            Button h = (Button)sender;

            if(playinggame==true)
            {
               
                    h.Text = "X";
                    h.Enabled = false;
                    playinggame = false;
                    Console.Beep();

                

            }
            else
            {
                 h.Text = "O";
                h.Enabled = false;
                playinggame = true;
                Console.Beep();
            }
            increment++;
            checkwiner();
        }
        private void checkwiner()
        {
            bool winer = false;

            if (increment == 9)
            {
                Gamedraw gg = new Gamedraw();
                gg.ShowDialog();
            }
            else
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text && (!button1.Enabled))
                    winer = true;
                else if (button4.Text == button5.Text && button5.Text == button6.Text && (!button5.Enabled))
                    winer = true;
                else if (button7.Text == button8.Text && button8.Text == button9.Text && (!button8.Enabled))
                    winer = true;
                else if (button1.Text == button4.Text && button4.Text == button7.Text && (!button4.Enabled))
                    winer = true;
                else if (button2.Text == button5.Text && button5.Text == button8.Text && (!button8.Enabled))
                    winer = true;
                else if (button3.Text == button6.Text && button6.Text == button9.Text && (!button9.Enabled))
                    winer = true;
                else if (button1.Text == button5.Text && button5.Text == button9.Text && (!button5.Enabled))
                    winer = true;
                else if (button3.Text == button5.Text && button5.Text == button7.Text && (!button7.Enabled))
                    winer = true;
                if (winer == true)
                {
                    if (playinggame == false)
                    {

                        Winer gg = new Winer(metroTextBox1.Text);
                        gg.ShowDialog();
                        newfun(false);
                       
                    }
                    else
                    {
                        Winer gg = new Winer( metroTextBox2.Text);
                        gg.ShowDialog();
                        newfun(false);
                       
                    }
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetToolStripMenuItem.Enabled = false;
            metroTextBox1.Enabled = true;
            metroTextBox2.Enabled = true;
            button11.Enabled = true;
           
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuform gg = new Menuform();
            gg.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(metroTextBox1.Text) || string.IsNullOrEmpty(metroTextBox2.Text))
            {
                MessageBox.Show("Both Text Boxes Empty are Please, First Fill them", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            }
            else
            {
                playinggame = true;
                newfun(true);
                resetToolStripMenuItem.Enabled = true;
                button11.Enabled = false;
                metroTextBox1.Enabled = false;
                metroTextBox2.Enabled = false;
            }

          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutTicTacToe2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About g = new About();
            g.ShowDialog();
        }
    }
}
