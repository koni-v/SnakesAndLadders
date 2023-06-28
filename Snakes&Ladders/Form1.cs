using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Ladders
{
    public partial class Form1 : Form
    {
        int flag = 0; //yellow's turn -> flag == 0
        public bool YellowToken { get; set; } = false;
        public bool PurpleToken { get; set; } = false;

        // player1 (yellow) - properties (x, y, position)
        public int x = 24;
        public int y = 475;
        public int p = 0;

        // player2 (purple) - properties (x, y, position)
        public int x2 = 24;
        public int y2 = 475;
        public int p2 = 0;

        public int DiceValue { get; set; }
        int seconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //error
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            // hide all the controling labels
            labelsHide();

            // first turn - player1
            if (flag == 0)
            {
                btnRoll2.Enabled = false;
                lblTurn.BackColor = Color.Yellow;
                lblTurn.Text = "PLAYER 1";
            }

            // make the pions initially invisible 
            pbYellowToken.Visible = false;
            pbPurpleToken.Visible = false;

            // setting up "roll the dice" image
            string picturePath = "./Resources/rollthediceF.png";
            pbdice.ImageLocation = picturePath;
            pbdice.SizeMode = PictureBoxSizeMode.Zoom;
        }


        // rolling the dice - player1
        private void btnRoll_Click(object sender, EventArgs e)
        {
            
            DiceValue = Functions.RollDice(pbdice);
            lbdice.Text = DiceValue.ToString();
           
            // moving the yellow pion
            if (YellowToken)
            {
                p = Functions.Move(ref x, ref y, p, DiceValue, pbYellowToken, lbMessage);
                lbp.Text = p.ToString();
            }

            // first time starting the game and every time the dice is "6"
            if (lbdice.Text == "6" && YellowToken == false)
            {
                pbYellowStart.Visible = false;
                pbYellowToken.Visible = true;
                YellowToken = true;

                p = 1;
                pbYellowToken.Location = new Point(x, y);

                lbp.Text = p.ToString();
                lbx.Text = x.ToString();
                lby.Text = y.ToString();
            }

            // pop up message if the winner is player1 (100th position)
            if (p == 100)
            {
                DialogResult dg = MessageBox.Show("CONGRATULATIONS PLAYER1 - YOU WON!  \n\n\n PLAY AGAIN?", "WINNER", MessageBoxButtons.YesNo);
                btnRoll.Enabled = false;
                if (dg == DialogResult.Yes)
                {
                    this.Close();
                    Form1 fm1 = new Form1();
                    fm1.Show();
                }
                else 
                {
                    this.Close();
                }
            }

            // calling the functions for the snakes and ladders implementation
            p = Functions.Snake(ref x, ref y, p, pbYellowToken);
            p = Functions.Ladder(ref x, ref y, p, pbYellowToken);

            lbp.Text = p.ToString();

            // changing the players turn
            if (DiceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                btnRoll.Enabled = false;
                btnRoll2.Enabled = true;
                lblTurn.BackColor = Color.MediumVioletRed;
                lblTurn.Text = "PLAYER 2";
            }
        }

        // rolling the dice - player2
        private void btnRoll2_Click(object sender, EventArgs e)
        {  
            DiceValue = Functions.RollDice(pbdice);
            lbdice.Text = DiceValue.ToString();
           
            // moving the purple pion
            if (PurpleToken)
            {
                p2 = Functions.Move(ref x2, ref y2, p2, DiceValue, pbPurpleToken, lbMessage2);
                lbp2.Text = p2.ToString();
            }

            // first time starting the game and every time the dice is "6"
            if (lbdice.Text == "6" && PurpleToken == false)
            {
                pbPurpleStart.Visible = false;
                pbPurpleToken.Visible = true;
                PurpleToken = true;

                p2 = 1;
                pbPurpleToken.Location = new Point(x2, y2);

                lbp2.Text = p2.ToString();
                lbx2.Text = x2.ToString();
                lby2.Text = y2.ToString();

            }

            // pop up message if the winner is player2 (100th position)
            if (p2 == 100)
            {
                DialogResult dg =MessageBox.Show("CONGRATULATIONS PLAYER2 - YOU WON! \n\n\n PLAY AGAIN?", "WINNER", MessageBoxButtons.YesNo);
                
                if (dg == DialogResult.Yes)
                { 
                    Form1 fm1 = new Form1();
                    this.Close();
                    fm1.Show();
                }
                else
                {
                    this.Close();
                }
             }

            // calling the functions for the snakes and ladders implementation
            p2 = Functions.Snake(ref x2, ref y2, p2, pbPurpleToken);
            p2 = Functions.Ladder(ref x2, ref y2, p2, pbPurpleToken);

            lbp2.Text = p2.ToString();

            // changing the players turn
            if (DiceValue == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                btnRoll2.Enabled = false;
                btnRoll.Enabled = true;
                lblTurn.BackColor = Color.Yellow;
                lblTurn.Text = "PLAYER 1";
            }
        }

        // hidding the labels method
        public void labelsHide()
        {
            label5.Visible = false;
            label10.Visible = false;
            lbp.Visible = false;
            lbp2.Visible = false;
            lbxText.Visible = false;
            lbyText.Visible = false;
            lbx.Visible = false;
            lby.Visible = false;
            lbx2.Visible = false;
            lby2.Visible = false;
            lbMessage.Visible = false;
            lbMessage2.Visible = false;

        }

        // button exit
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // timer event for rolling dice
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    int pic;
        //    seconds++;
        //    Random r = new Random();
        //    if (seconds <= 10)
        //    {
        //        pic = r.Next(1, 7);
        //        string picturePath2 = "./Resources/" + pic + ".png";
        //        pbdice.ImageLocation = picturePath2;
        //        pbdice.SizeMode = PictureBoxSizeMode.Zoom;
        //        pbdice.Visible = true;
        //    }
        //    else
        //    {
        //        timer1.Stop();
        //        Functions.RollDice(pbdice);
        //    }
        //}

        //// timer function
        //private void timergame(object sender, EventArgs e)
        //{
        //    second = 0;
        //    timer1.Interval = 100;
        //    timer1.Start();
        //    Form1 f = new Form1();
        //    f.timer1_Tick(sender,e);
        //    {
        //        int pic;
        //        second++;
        //        Random r = new Random();
        //        if (second <= 10)
        //        {
        //            pic = r.Next(1, 7);
        //            string picturePath2 = "./Resources/" + pic + ".png";
        //            pbdice.ImageLocation = picturePath2;
        //            pbdice.SizeMode = PictureBoxSizeMode.Zoom;

        //        }
        //        else
        //        {
        //            timer1.Stop();
        //            Functions.RollDice(pbdice);
        //        }
        //    };
        //}
    }//....end of class
}
