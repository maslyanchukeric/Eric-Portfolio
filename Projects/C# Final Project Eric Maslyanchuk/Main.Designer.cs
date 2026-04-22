namespace Final_Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            startBtn = new Button();
            exitBtn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 40);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Snake Game";
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(23, 56);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(166, 42);
            startBtn.TabIndex = 1;
            startBtn.Text = "Start Game";
            toolTip1.SetToolTip(startBtn, "Starts Snake Game");
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(245, 56);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(166, 42);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Exit";
            toolTip1.SetToolTip(exitBtn, "Exits Snake Game");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Main
            // 
            AcceptButton = startBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(434, 128);
            Controls.Add(exitBtn);
            Controls.Add(startBtn);
            Controls.Add(label1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startBtn;
        private Button exitBtn;
        private ToolTip toolTip1;
    }
}
