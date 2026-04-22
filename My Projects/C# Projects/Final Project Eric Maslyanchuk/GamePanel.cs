using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Final_Project
{
    public partial class GamePanel : Form
    {
        // snake head position
        private int snakeX, snakeY;

        // food position
        private int foodX, foodY;

        // movement speed (one grid = 20px)
        private int dx = 20, dy = 0;

        // snake body list
        private List<Point> snakeBody = new List<Point>();

        // random generator
        private Random rand = new Random();

        // game timer
        private Timer timer = new Timer();

        // game stats
        private int score = 0, level = 1, delay = 200;

        // colors
        private Color snakeColor = Color.Yellow;
        private Color backgroundColor = Color.Black;

        // game start flag
        private bool gameStarted = false;

        public GamePanel()
        {
            InitializeComponent();

            this.DoubleBuffered = true;      // smoother drawing
            this.KeyPreview = true;          // capture arrow keys
            this.KeyDown += GamePanel_KeyDown; // movement key handler

            timer.Interval = delay;          // timer speed
            timer.Tick += Timer_Tick;        // game loop

            gameArea.Paint += GameArea_Paint; // draw snake + food
            this.Load += GamePanel_Load;      // setup game on load
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            ResetGame();   // setup new game
            gameStarted = true;
            timer.Start(); // start movement
        }

        private void ResetGame()
        {
            dx = 20;       // start moving right
            dy = 0;

            score = 0;
            level = 1;

            // random colors each game
            snakeColor = RandomColor();
            backgroundColor = RandomColor();
            gameArea.BackColor = backgroundColor;

            snakeBody.Clear(); // clear old snake

            // center snake on grid
            snakeX = (gameArea.ClientSize.Width / 20 / 2) * 20;
            snakeY = (gameArea.ClientSize.Height / 20 / 2) * 20;

            snakeBody.Add(new Point(snakeX, snakeY)); // add head

            PlaceFood(); // put new food

            scoreLabel.Text = "Score: 0   Level: 1";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // move snake head
            snakeX += dx;
            snakeY += dy;

            // check wall collision
            if (snakeX < 0 || snakeY < 0 ||
                snakeX >= gameArea.ClientSize.Width ||
                snakeY >= gameArea.ClientSize.Height)
            {
                timer.Stop(); // stop movement

                DialogResult result = MessageBox.Show(
                    $"Game Over!\nScore: {score}\nPlay Again?",
                    "Snake Game", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ResetGame();
                    timer.Start();
                }
                else
                {
                    Close();
                }

                return;
            }

            // add new head to snake body
            snakeBody.Insert(0, new Point(snakeX, snakeY));

            // check if snake eats the food
            if (snakeX == foodX && snakeY == foodY)
            {
                score++;

                // level up
                if (score % 5 == 0)
                {
                    level++;
                    if (delay > 50)
                    {
                        delay -= 20; // speed up
                        timer.Interval = delay;
                    }
                }

                scoreLabel.Text = $"Score: {score}   Level: {level}";
                PlaceFood(); // move food
            }
            else
            {
                // remove tail (normal movement)
                snakeBody.RemoveAt(snakeBody.Count - 1);
            }

            gameArea.Invalidate(); // redraw screen
        }

        private void GameArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // draw each block of snake body
            foreach (Point p in snakeBody)
            {
                using (SolidBrush brush = new SolidBrush(snakeColor))
                {
                    g.FillRectangle(brush, p.X, p.Y, 20, 20);
                }
            }

            // draw food
            g.FillRectangle(Brushes.Red, foodX, foodY, 20, 20);

            // welcome screen
            if (!gameStarted)
            {
                g.DrawString("Welcome to Snake Game",
                    new Font("Times New Roman", 20, FontStyle.Bold),
                    Brushes.Green,
                    new PointF(180, 250));
            }
        }

        private void GamePanel_KeyDown(object sender, KeyEventArgs e)
        {
            // change direction (prevent reversing)
            if (e.KeyCode == Keys.Left && dx == 0) 
            { 
                dx = -20; dy = 0; 
            }
            else if (e.KeyCode == Keys.Right && dx == 0) 
            { 
                dx = 20; dy = 0; 
            }
            else if (e.KeyCode == Keys.Up && dy == 0) 
            { 
                dx = 0; dy = -20; 
            }
            else if (e.KeyCode == Keys.Down && dy == 0) 
            { 
                dx = 0; dy = 20; 
            }
        }

        private void PlaceFood()
        {
            int cell = 20;

            int cols = gameArea.ClientSize.Width / cell;
            int rows = gameArea.ClientSize.Height / cell;

            foodX = rand.Next(cols) * cell; // grid aligned
            foodY = rand.Next(rows) * cell;
        }

        private Color RandomColor()
        {
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}