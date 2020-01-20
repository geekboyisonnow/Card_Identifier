using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoOfHearts_Click(object sender, EventArgs e)
        {
            nameOfCardChoosen.Text = "Two of Hearts";
        }

        private void twoOfSpades_Click(object sender, EventArgs e)
        {
            nameOfCardChoosen.Text = "Two of Spades";
        }

        private void fourOfSpades_Click(object sender, EventArgs e)
        {
            nameOfCardChoosen.Text = "Four of Spades";
        }

        private void fiveOfHearts_Click(object sender, EventArgs e)
        {
            nameOfCardChoosen.Text = "Five of Hearts";
        }

        private void eightOfClubs_Click(object sender, EventArgs e)
        {
            nameOfCardChoosen.Text = "Eight of Clubs";
        }
    }
}
