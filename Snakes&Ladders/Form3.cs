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
    public partial class Form3 : Form
    {
        public bool sound { get; set; }
        public Form3(bool SoundOn)
        {
            InitializeComponent();
            sound = SoundOn; 
        }

        // Start button implementation
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(sound);
            this.Close();
            form.ShowDialog();
            
        }
    }
}
