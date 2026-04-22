using System.Drawing.Imaging;
using System.Drawing.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace Final_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Create and show the game window
            GamePanel game = new GamePanel();
            game.ShowDialog(); // Opens the game form
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Exit the entire application
            Application.Exit();
        }
    }
}

