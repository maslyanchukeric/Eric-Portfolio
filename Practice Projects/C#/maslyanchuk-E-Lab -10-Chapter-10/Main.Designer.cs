namespace maslyanchuk_E_Lab__10_Chapter_10
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
            groupBox1 = new GroupBox();
            universitySuitesRadioButton = new RadioButton();
            farthingHallRadioButton = new RadioButton();
            pikeHallRadioButton = new RadioButton();
            allenHallRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            unlimitedRadioButton = new RadioButton();
            meal14RadioButton = new RadioButton();
            meal7RadioButton = new RadioButton();
            displayBtn = new Button();
            ClearBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(universitySuitesRadioButton);
            groupBox1.Controls.Add(farthingHallRadioButton);
            groupBox1.Controls.Add(pikeHallRadioButton);
            groupBox1.Controls.Add(allenHallRadioButton);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(57, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a Dorm:";
            toolTip1.SetToolTip(groupBox1, "Choose a dorm plan");
            // 
            // universitySuitesRadioButton
            // 
            universitySuitesRadioButton.AutoSize = true;
            universitySuitesRadioButton.Location = new Point(6, 97);
            universitySuitesRadioButton.Name = "universitySuitesRadioButton";
            universitySuitesRadioButton.Size = new Size(119, 19);
            universitySuitesRadioButton.TabIndex = 0;
            universitySuitesRadioButton.TabStop = true;
            universitySuitesRadioButton.Text = "University Suties";
            universitySuitesRadioButton.UseVisualStyleBackColor = true;
            // 
            // farthingHallRadioButton
            // 
            farthingHallRadioButton.AutoSize = true;
            farthingHallRadioButton.Location = new Point(6, 72);
            farthingHallRadioButton.Name = "farthingHallRadioButton";
            farthingHallRadioButton.Size = new Size(99, 19);
            farthingHallRadioButton.TabIndex = 3;
            farthingHallRadioButton.TabStop = true;
            farthingHallRadioButton.Text = "Farthing Hall";
            farthingHallRadioButton.UseVisualStyleBackColor = true;
            // 
            // pikeHallRadioButton
            // 
            pikeHallRadioButton.AutoSize = true;
            pikeHallRadioButton.Location = new Point(6, 47);
            pikeHallRadioButton.Name = "pikeHallRadioButton";
            pikeHallRadioButton.Size = new Size(77, 19);
            pikeHallRadioButton.TabIndex = 2;
            pikeHallRadioButton.TabStop = true;
            pikeHallRadioButton.Text = "Pike Hall";
            pikeHallRadioButton.UseVisualStyleBackColor = true;
            // 
            // allenHallRadioButton
            // 
            allenHallRadioButton.AutoSize = true;
            allenHallRadioButton.Location = new Point(6, 22);
            allenHallRadioButton.Name = "allenHallRadioButton";
            allenHallRadioButton.Size = new Size(81, 19);
            allenHallRadioButton.TabIndex = 1;
            allenHallRadioButton.TabStop = true;
            allenHallRadioButton.Text = "Allen Hall";
            allenHallRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(unlimitedRadioButton);
            groupBox2.Controls.Add(meal14RadioButton);
            groupBox2.Controls.Add(meal7RadioButton);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(263, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select a Meal Plan:";
            toolTip1.SetToolTip(groupBox2, "Choose a meal plan");
            // 
            // unlimitedRadioButton
            // 
            unlimitedRadioButton.AutoSize = true;
            unlimitedRadioButton.Location = new Point(6, 72);
            unlimitedRadioButton.Name = "unlimitedRadioButton";
            unlimitedRadioButton.Size = new Size(113, 19);
            unlimitedRadioButton.TabIndex = 2;
            unlimitedRadioButton.TabStop = true;
            unlimitedRadioButton.Text = "Unlimited meals";
            unlimitedRadioButton.UseVisualStyleBackColor = true;
            // 
            // meal14RadioButton
            // 
            meal14RadioButton.AutoSize = true;
            meal14RadioButton.Location = new Point(6, 47);
            meal14RadioButton.Name = "meal14RadioButton";
            meal14RadioButton.Size = new Size(126, 19);
            meal14RadioButton.TabIndex = 1;
            meal14RadioButton.TabStop = true;
            meal14RadioButton.Text = "14 meals per week";
            meal14RadioButton.UseVisualStyleBackColor = true;
            // 
            // meal7RadioButton
            // 
            meal7RadioButton.AutoSize = true;
            meal7RadioButton.Location = new Point(6, 22);
            meal7RadioButton.Name = "meal7RadioButton";
            meal7RadioButton.Size = new Size(119, 19);
            meal7RadioButton.TabIndex = 0;
            meal7RadioButton.TabStop = true;
            meal7RadioButton.Text = "7 meals per week";
            meal7RadioButton.UseVisualStyleBackColor = true;
            // 
            // displayBtn
            // 
            displayBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            displayBtn.Location = new Point(57, 182);
            displayBtn.Name = "displayBtn";
            displayBtn.Size = new Size(99, 23);
            displayBtn.TabIndex = 2;
            displayBtn.Text = "&Display Total";
            toolTip1.SetToolTip(displayBtn, "Opens the cost form to show the cost");
            displayBtn.UseVisualStyleBackColor = true;
            displayBtn.Click += displayBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            ClearBtn.Location = new Point(209, 182);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(99, 23);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "&Clear";
            toolTip1.SetToolTip(ClearBtn, "clears the form ");
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(364, 182);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(99, 23);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "close the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 24);
            label1.TabIndex = 5;
            label1.Text = "Welcome to Dorm and Meal Panl Calculator";
            // 
            // Main
            // 
            AcceptButton = displayBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(520, 239);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Controls.Add(ClearBtn);
            Controls.Add(displayBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Lab-10-Chapter-10-Dorm-Meal-Plan-Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton farthingHallRadioButton;
        private RadioButton pikeHallRadioButton;
        private RadioButton allenHallRadioButton;
        private RadioButton universitySuitesRadioButton;
        private GroupBox groupBox2;
        private RadioButton unlimitedRadioButton;
        private RadioButton meal14RadioButton;
        private RadioButton meal7RadioButton;
        private Button displayBtn;
        private Button ClearBtn;
        private Button exitBtn;
        private Label label1;
        private ToolTip toolTip1;
    }
}
