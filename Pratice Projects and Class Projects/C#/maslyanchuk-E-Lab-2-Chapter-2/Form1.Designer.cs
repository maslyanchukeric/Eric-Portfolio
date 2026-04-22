namespace maslyanchuk_E_Lab_2
{
    partial class Cardidentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardidentifier));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            cardAnswerLbl = new Label();
            exitBtn = new Button();
            toolTip1 = new ToolTip(components);
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Click to reveal card");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 26);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Card Identifier";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(197, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, "Click to reveal card");
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(398, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 182);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            toolTip1.SetToolTip(pictureBox3, "Click to reveal card");
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(593, 54);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 182);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            toolTip1.SetToolTip(pictureBox4, "Click to reveal card");
            pictureBox4.Click += pictureBox4_Click;
            // 
            // cardAnswerLbl
            // 
            cardAnswerLbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardAnswerLbl.ForeColor = SystemColors.ControlText;
            cardAnswerLbl.ImageAlign = ContentAlignment.TopCenter;
            cardAnswerLbl.Location = new Point(324, 251);
            cardAnswerLbl.Name = "cardAnswerLbl";
            cardAnswerLbl.Size = new Size(293, 42);
            cardAnswerLbl.TabIndex = 5;
            cardAnswerLbl.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(cardAnswerLbl, "Shows card name ");
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(863, 284);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "&Exit\r\n";
            toolTip1.SetToolTip(exitBtn, "Close the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(801, 54);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(137, 182);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            toolTip1.SetToolTip(pictureBox5, "Click to reveal card");
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Cardidentifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(950, 319);
            Controls.Add(pictureBox5);
            Controls.Add(exitBtn);
            Controls.Add(cardAnswerLbl);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Cardidentifier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label cardAnswerLbl;
        private Button exitBtn;
        private ToolTip toolTip1;
        private PictureBox pictureBox5;
    }
}
