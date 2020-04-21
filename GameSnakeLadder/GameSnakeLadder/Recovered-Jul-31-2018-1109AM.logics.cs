using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameSnakeLadder
{
   public  class logics
    {

        public static int rolldice(PictureBox px)
        {
            int dice;
            Random g = new Random();
            dice = g.Next(1, 7);
            px.Image = Image.FromFile(@"c:\users\hamza\source\repos\SnakeLader\SnakeLader\Resources\" + dice + ".png");
            return dice;
        }

        public void move(ref int x, ref int y, ref int p, int dice, PictureBox ss, Label pp, ref int[] pos)
        {
            if (dice + p > 100)
            {
                pp.Text = "Can't Move";
                pp.ForeColor = System.Drawing.Color.Red;
                return;
            }


            for (int i = 0; i < dice; i++)
            {
                if (p == 10)
                {
                    x = 25;
                    y = 607;
                }

                else if (p == 10)
                {
                    x = 25;
                    y = 538;
                }
                else if (p == 20)
                {
                    x = 25;
                    y = 472;
                }
                else if (p == 30)
                {
                    x = 25;
                    y = 411;
                }
                else if (p == 40)
                {
                    x = 25;
                    y = 344;
                }
                else if (p == 50)
                {
                    x = 25;
                    y = 280;
                }
                else if (p == 60)
                {
                    x = 25;
                    y = 212;
                }
                else if (p == 70)
                {
                    x = 25;
                    y = 149;
                }
                else if (p == 80)
                {
                    x = 25;
                    y = 81;
                }
                else if (p == 90)
                {
                    x = 25;
                    y = 12;
                }
                //.....................Ladders.........................




                else
                {
                    x += 90;
                }

                p++;
                pp.Text = p.ToString();
                ss.Location = new Point(x, y);

            }

        }
        public static int forward(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 3)
            {
                x = 25;
                y = 280;
                p = 51;
                px.Location = new Point(x, y);
            }
            else if (p == 6)
            {
                x = 566;
                y = 472;
                p = 27;
                px.Location = new Point(x, y);
            }
            else if (p == 20)
            {
                x = 830;
                y = 580;
                p = 20;
                px.Location = new Point(x, y);
            }
            else if (p == 36)
            {
                x = 386;
                y = 280;
                p = 55;
                px.Location = new Point(x, y);
            }
            else if (p == 63)
            {
                x = 385;
                y = 12;
                p = 95;
                px.Location = new Point(x, y);
            }
            else if (p == 68)
            {
                x = 654;
                y = 12;
                p = 98;
                px.Location = new Point(x, y);
            }

            return p;




        }
        public static int back(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 25)
            {
                x = 385;
                y = 607;
                p = 5;
                px.Location = new Point(x, y);
            }
            else if (p == 34)
            {
                x = 25;
                y = 607;
                p = 1;
                px.Location = new Point(x, y);
            }
            else if (p == 47)
            {
                x = 743;
                y = 547;
                p = 19;
                px.Location = new Point(x, y);
            }
            else if (p == 65)
            {
                x = 117;
                y = 280;
                p = 52;
                px.Location = new Point(x, y);
            }
            else if (p == 87)
            {
                x = 561;
                y = 280;
                p = 57;
                px.Location = new Point(x, y);
            }
            else if (p == 91)
            {
                x = 25;
                y = 212;
                p = 61;
                px.Location = new Point(x, y);
            }
            else if (p == 99)
            {
                x = 741;
                y = 212;
                p = 69;
                px.Location = new Point(x, y);
            }


            return p;
        }







        //...................................................Player Two...........................................////










        public void moveage(ref int s, ref int n, ref int r, int dice, PictureBox ss, Label pp, ref int[] pos)
        {
            if (dice + r > 100)
            {
                pp.Text = "Can't Move";
                pp.ForeColor = System.Drawing.Color.Red;
                return;
            }


            for (int i = 0; i < dice; i++)
            {
                if (r == 10)
                {
                    s = 25;
                    n = 607;
                }

                else if (r == 10)
                {
                    s = 25;
                    n = 538;
                }
                else if (r == 20)
                {
                    s = 25;
                    n = 472;
                }
                else if (r == 30)
                {
                    s = 25;
                    n = 411;
                }
                else if (r == 40)
                {
                    s = 25;
                    n = 344;
                }
                else if (r == 50)
                {
                    s = 25;
                    n = 280;
                }
                else if (r == 60)
                {
                    s = 25;
                    n = 212;
                }
                else if (r == 70)
                {
                    s = 25;
                    n = 149;
                }
                else if (r == 80)
                {
                    s = 25;
                    n = 81;
                }
                else if (r == 90)
                {
                    s = 25;
                    n = 12;
                }
                //.....................Ladders.........................




                else
                {
                    s += 90;
                }

                r++;
                pp.Text = r.ToString();
                ss.Location = new Point(s, n);

            }

        }
        public static int forwardaage(ref int s, ref int n, int r, PictureBox px)
        {
            if (r == 3)
            {
                s = 25;
                n = 280;
                r = 51;
                px.Location = new Point(s, n);
            }
            else if (r == 6)
            {
                s = 566;
                n = 472;
                r = 27;
                px.Location = new Point(s, n);
            }
            else if (r == 20)
            {
                s = 830;
                n = 580;
                r = 20;
                px.Location = new Point(s, n);
            }
            else if (r == 36)
            {
                s = 386;
                n = 280;
                r = 55;
                px.Location = new Point(s, n);
            }
            else if (r == 63)
            {
                s = 385;
                n = 12;
                r = 95;
                px.Location = new Point(s, n);
            }
            else if (r == 68)
            {
                s = 654;
                n = 12;
                r = 98;
                px.Location = new Point(s, n);
            }

            return r;




        }
        public static int backpeeche(ref int s, ref int n, int r, PictureBox px)
        {
            if (r == 25)
            {
                s = 385;
                n = 607;
                r = 5;
                px.Location = new Point(s, n);
            }
            else if (r == 34)
            {
                s = 25;
                n = 607;
                r = 1;
                px.Location = new Point(s, n);
            }
            else if (r == 47)
            {
                s = 743;
                n = 547;
                r = 19;
                px.Location = new Point(s, n);
            }
            else if (r == 65)
            {
                s = 117;
                n = 280;
                r = 52;
                px.Location = new Point(s, r);
            }
            else if (r == 87)
            {
                s = 561;
                n = 280;
                r = 57;
                px.Location = new Point(s, n);
            }
            else if (r == 91)
            {
                s = 25;
                n = 212;
                r = 61;
                px.Location = new Point(s, n);
            }
            else if (r == 99)
            {
                s = 741;
                n = 212;
                r = 69;
                px.Location = new Point(s, n);
            }


            return r;
        }



    }
}
