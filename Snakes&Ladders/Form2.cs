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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // New Game button implementation
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();   
        }

        // How to Play button implementation
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            //error
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //error
        }
    }
}
