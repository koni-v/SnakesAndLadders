using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Ladders
{
    public partial class Form1 : Form
    {
        public SoundPlayer player2 { get; set; }
        int flag = 0; //yellow's turn -> flag == 0
        public bool Sound { get; set; }//true if the sound is enable
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

        public Form1(bool s)
        {
            InitializeComponent();
            Sound = s;
          
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
           
            // moving the yellow token
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

            // pop up message if the winner is player1 
            if (p == 100)
            {
                if (Sound)//enable the win sound only if the sound button is enabled
                {
                    player2 = new SoundPlayer();
                    player2.SoundLocation = @".\Resources\WinSound.wav";
                    player2.Play();
                }
                
                DialogResult dg = MessageBox.Show("CONGRATULATIONS PLAYER1 - YOU WON!  \n\n\n PLAY AGAIN?", "WINNER", MessageBoxButtons.YesNo);
                btnRoll.Enabled = false;
                
                if (dg == DialogResult.Yes)
                {
                    this.Close();
                    
                    Form1 fm1 = new Form1(Sound);
                    fm1.Show();
                    if (Sound)//continuing with the game sound
                    {
                        player2.SoundLocation = @".\Resources\GameSound.wav";
                        player2.PlayLooping();
                    }
                }
                else 
                {
                    this.Close();
                    if (Sound)//continuing with the game sound
                    {
                        player2.SoundLocation = @".\Resources\GameSound.wav";
                        player2.PlayLooping();
                    }
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

            // pop up message if the winner is player2
            if (p2 == 100)
            {
                if (Sound)//enable the win sound only if the sound button is enabled
                {
                    player2 = new SoundPlayer();
                    player2.SoundLocation = @".\Resources\WinSound.wav";
                    player2.Play();
                }
                
                DialogResult dg =MessageBox.Show("CONGRATULATIONS PLAYER2 - YOU WON! \n\n\n PLAY AGAIN?", "WINNER", MessageBoxButtons.YesNo);
                
                if (dg == DialogResult.Yes)
                { 
                    Form1 fm1 = new Form1(Sound);
                    this.Close();
                    fm1.Show();
                    if (Sound)//continuing with the game sound
                    {
                        player2.SoundLocation = @".\Resources\GameSound.wav";
                        player2.PlayLooping();
                    }
                }
                else
                {
                    this.Close();
                    if (Sound) //continuing with the game sound
                    {
                        player2.SoundLocation = @".\Resources\GameSound.wav";
                        player2.PlayLooping();
                    }
                    
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

        // Exit button implementation
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }//....end of class
}
