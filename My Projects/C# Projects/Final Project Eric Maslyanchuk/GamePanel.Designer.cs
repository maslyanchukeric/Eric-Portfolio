namespace Final_Project
{
    partial class GamePanel
    {
        private System.ComponentModel.IContainer components = null;

        private Panel gameArea;
        private Label scoreLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gameArea = new Panel();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // gameArea
            // 
            gameArea.BackColor = Color.DarkSlateGray;
            gameArea.Location = new Point(0, 40);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(800, 410);
            gameArea.TabIndex = 0;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            scoreLabel.ForeColor = Color.Black;
            scoreLabel.Location = new Point(10, 10);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(131, 19);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Score: 0   Level: 1";
            // 
            // GamePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(gameArea);
            Name = "GamePanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamePanel";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}
