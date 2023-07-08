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
using System.Media;

namespace Snakes_Ladders
{
    public partial class Form2 : Form
    {
        public SoundPlayer player;
        public Form form;
        public bool SoundOn { get; set; }
        public Form2()
        {
            InitializeComponent();
            player = new SoundPlayer();
            player.SoundLocation = @".\resources\gamesound.wav";
            player.PlayLooping();
            SoundOn = true;



        }

        // New Game button implementation
        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form1(SoundOn);
            form.Show();   
            
        }

        // How to Play button implementation
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(SoundOn);
            form.ShowDialog();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            //error
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //to remove the sound of game
            
            if (btnSound.Text == "Sound ON")
            {
                btnSound.Text = "Sound OFF";
                player.Stop();
                SoundOn = false;
                
                
            }
            else if (btnSound.Text == "Sound OFF")
            {
                btnSound.Text = "Sound ON";
                player.PlayLooping();
                SoundOn = true;
            }
        }
    }
}
