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
        // int second = 0;
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
            // first turn - player1
            if (flag == 0)
            {
                btnRoll2.Enabled = false;
            }

            // make the pions initially invisible 
            pbYellowToken.Visible = false;
            pbPurpleToken.Visible = false;

            // setting up "roll the dice" image
            pbdice.Image = Image.FromFile(@"C:\Users\Administrator\source\repos\Snakes&Ladders\Snakes&Ladders\Resources\rollthediceF.png");
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
                MessageBox.Show("CONGRATULATIONS PLAYER1 - YOU WON!", "WINNER", MessageBoxButtons.OK);
                btnRoll.Enabled = false;

                // closing the form
                this.Close();
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
                MessageBox.Show("CONGRATULATIONS PLAYER2 - YOU WON!", "WINNER", MessageBoxButtons.OK);
                btnRoll2.Enabled = false;

                // closing the form
                this.Close();
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
            }
        }
    }//....end of class
}
