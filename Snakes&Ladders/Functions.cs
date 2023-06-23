using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Ladders
{
    public class Functions
    {
        // rolling the dice method
        public static int RollDice(PictureBox pb)
        {
            int dice = 0;
            Random random = new Random();
            dice = random.Next(1, 7);

            // changing the dice image
            pb.Image = Image.FromFile(@"C:\Users\Administrator\source\repos\Snakes&Ladders\Snakes&Ladders\Resources\" + dice + ".png");
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            return dice;
        }

        // moving the tokens logics (right, left, up)
        public static int Move(ref int x, ref int y, int p, int dice, PictureBox pb, Label l)
        {
            // condition for when the dice number is bigger than positions left
            if (dice + p > 100)
            {
                l.Visible = true;
                l.Text = $"CLOSE ENOUGH. \nBETTER LUCK NEXT TIME!";
                l.ForeColor = Color.Red;
            }
            else
            {

                // hide the label when the token gets to 100 or the dice is smaller than the positions left
                if (dice+p <= 100)
                {
                    l.Visible = false;
                }

                // moving the token based on the dice number
                for (int i = 0; i < dice; i++)
                {
                    switch (p)
                    {
                        case 10:
                            x = 492;
                            y = 423;
                            break;
                        case 20:
                            x = 24;
                            y = 371;
                            break;
                        case 30:
                            x = 492;
                            y = 319;
                            break;
                        case 40:
                            x = 24;
                            y = 267;
                            break;
                        case 50:
                            x = 492;
                            y = 215;
                            break;
                        case 60:
                            x = 24;
                            y = 163;
                            break;
                        case 70:
                            x = 492;
                            y = 111;
                            break;
                        case 80:
                            x = 24;
                            y = 59;
                            break;
                        case 90:
                            x = 492;
                            y = 7;
                            break;
                        default:
                            if (p / 10 % 2 != 0)
                            {
                                x -= 52;
                            }
                            else
                            {
                                x += 52;
                            }
                            break;
                    }//..end of switch

                    p++;
                    pb.Location = new Point(x, y);
                }//...end of loop   
            }

            return p;
        }


        // moving the tokens down the snakes
        public static int Snake(ref int x, ref int y, int p, PictureBox pb)
        {
            switch (p)
            {
                case 17:
                    x = 336;
                    y = 475;
                    p = 7;
                    break;
                case 54:
                    x = 336;
                    y = 319;
                    p = 34;
                    break;
                case 62:
                    x = 76;
                    y = 423;
                    p = 19;
                    break;
                case 64:
                    x = 24;
                    y = 215;
                    p = 60;
                    break;
                case 87:
                    x = 180;
                    y = 371;
                    p = 24;
                    break;
                case 93:
                    x = 388;
                    y = 111;
                    p = 73;
                    break;
                case 95:
                    x = 284;
                    y = 111;
                    p = 75;
                    break;
                case 98:
                    x = 76;
                    y = 111;
                    p = 79;
                    break;
            }//...end of switch

            pb.Location = new Point(x, y);
            return p;
        }


        // moving the tokens up the ladders
        public static int Ladder(ref int x, ref int y, int p, PictureBox pb)
        {
            switch (p)
            {
                case 1:
                    x = 128;
                    y = 319;
                    p = 38;
                    break;
                case 4:
                    x = 336;
                    y = 423;
                    p = 14;
                    break;
                case 9:
                    x = 492;
                    y = 319;
                    p = 31;
                    break;
                case 21:
                    x = 76;
                    y = 267;
                    p = 42;
                    break;
                case 28:
                    x = 180;
                    y = 59;
                    p = 84;
                    break;
                case 51:
                    x = 336;
                    y = 163;
                    p = 67;
                    break;
                case 71:
                    x = 492;
                    y = 7;
                    p = 91;
                    break;
                case 80:
                    x = 24;
                    y = 7;
                    p = 100;
                    break;
            }//... end of switch

            pb.Location = new Point(x, y);
            return p;
        }

    }//...end of class
}
