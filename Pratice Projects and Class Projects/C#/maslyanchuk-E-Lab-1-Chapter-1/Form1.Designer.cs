namespace maslyanchukELab1
{
    partial class Form1
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
            labBtn = new Button();
            quizBtn = new Button();
            toolTip1 = new ToolTip(components);
            examBtn = new Button();
            finalBtn = new Button();
            clearBtn = new Button();
            closeBtn = new Button();
            examTextBox1 = new TextBox();
            examTextBox2 = new TextBox();
            examTextBox3 = new TextBox();
            examTextBox4 = new TextBox();
            labTextBox4 = new TextBox();
            labTextBox3 = new TextBox();
            labTextBox2 = new TextBox();
            labTextBox1 = new TextBox();
            labTextBox5 = new TextBox();
            quizTextBox5 = new TextBox();
            quizTextBox4 = new TextBox();
            quizTextBox3 = new TextBox();
            quizTextBox2 = new TextBox();
            quizTextBox1 = new TextBox();
            finalReusltLbl = new Label();
            letterGradeLbl = new Label();
            examAverageLbl = new Label();
            labAverageLbl = new Label();
            quizAverageLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labBtn
            // 
            labBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labBtn.Location = new Point(203, 258);
            labBtn.Name = "labBtn";
            labBtn.Size = new Size(120, 23);
            labBtn.TabIndex = 10;
            labBtn.Text = "Submit &Lab Grade";
            toolTip1.SetToolTip(labBtn, "Gets average of lab grades");
            labBtn.UseVisualStyleBackColor = true;
            labBtn.Click += labBtn_Click;
            // 
            // quizBtn
            // 
            quizBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizBtn.Location = new Point(365, 258);
            quizBtn.Name = "quizBtn";
            quizBtn.Size = new Size(134, 23);
            quizBtn.TabIndex = 16;
            quizBtn.Text = "Submit &Quiz Grade";
            toolTip1.SetToolTip(quizBtn, "Gets average of quiz grades");
            quizBtn.UseVisualStyleBackColor = true;
            quizBtn.Click += quizBtn_Click;
            // 
            // examBtn
            // 
            examBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examBtn.Location = new Point(34, 229);
            examBtn.Name = "examBtn";
            examBtn.Size = new Size(128, 23);
            examBtn.TabIndex = 4;
            examBtn.Text = "Submit &Exam Grade";
            toolTip1.SetToolTip(examBtn, "Gets average of exam grades");
            examBtn.UseVisualStyleBackColor = true;
            examBtn.Click += examBtn_Click;
            // 
            // finalBtn
            // 
            finalBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalBtn.Location = new Point(36, 359);
            finalBtn.Name = "finalBtn";
            finalBtn.Size = new Size(120, 23);
            finalBtn.TabIndex = 17;
            finalBtn.Text = "&Final Grade";
            toolTip1.SetToolTip(finalBtn, "Gets Final Grade");
            finalBtn.UseVisualStyleBackColor = true;
            finalBtn.Click += finalBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(41, 488);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(120, 23);
            clearBtn.TabIndex = 18;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears Form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(344, 488);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(120, 23);
            closeBtn.TabIndex = 19;
            closeBtn.Text = "&Close";
            toolTip1.SetToolTip(closeBtn, "Exit");
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // examTextBox1
            // 
            examTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTextBox1.Location = new Point(34, 98);
            examTextBox1.Name = "examTextBox1";
            examTextBox1.Size = new Size(100, 26);
            examTextBox1.TabIndex = 0;
            toolTip1.SetToolTip(examTextBox1, "Enter Exam Grade 1");
            // 
            // examTextBox2
            // 
            examTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTextBox2.Location = new Point(34, 130);
            examTextBox2.Name = "examTextBox2";
            examTextBox2.Size = new Size(100, 26);
            examTextBox2.TabIndex = 1;
            toolTip1.SetToolTip(examTextBox2, "Enter Exam Grade 2");
            // 
            // examTextBox3
            // 
            examTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTextBox3.Location = new Point(34, 162);
            examTextBox3.Name = "examTextBox3";
            examTextBox3.Size = new Size(100, 26);
            examTextBox3.TabIndex = 2;
            toolTip1.SetToolTip(examTextBox3, "Enter Exam Grade 3");
            // 
            // examTextBox4
            // 
            examTextBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTextBox4.Location = new Point(34, 194);
            examTextBox4.Name = "examTextBox4";
            examTextBox4.Size = new Size(100, 26);
            examTextBox4.TabIndex = 3;
            toolTip1.SetToolTip(examTextBox4, "Enter Exam Grade 4");
            // 
            // labTextBox4
            // 
            labTextBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTextBox4.Location = new Point(203, 194);
            labTextBox4.Name = "labTextBox4";
            labTextBox4.Size = new Size(100, 26);
            labTextBox4.TabIndex = 8;
            toolTip1.SetToolTip(labTextBox4, "Enter Lab Grade 4");
            // 
            // labTextBox3
            // 
            labTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTextBox3.Location = new Point(203, 162);
            labTextBox3.Name = "labTextBox3";
            labTextBox3.Size = new Size(100, 26);
            labTextBox3.TabIndex = 7;
            toolTip1.SetToolTip(labTextBox3, "Enter Lab Grade 3");
            // 
            // labTextBox2
            // 
            labTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTextBox2.Location = new Point(203, 130);
            labTextBox2.Name = "labTextBox2";
            labTextBox2.Size = new Size(100, 26);
            labTextBox2.TabIndex = 6;
            toolTip1.SetToolTip(labTextBox2, "Enter Lab Grade 2");
            // 
            // labTextBox1
            // 
            labTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTextBox1.Location = new Point(203, 98);
            labTextBox1.Name = "labTextBox1";
            labTextBox1.Size = new Size(100, 26);
            labTextBox1.TabIndex = 5;
            toolTip1.SetToolTip(labTextBox1, "Enter Lab Grade 1");
            // 
            // labTextBox5
            // 
            labTextBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTextBox5.Location = new Point(203, 226);
            labTextBox5.Name = "labTextBox5";
            labTextBox5.Size = new Size(100, 26);
            labTextBox5.TabIndex = 9;
            toolTip1.SetToolTip(labTextBox5, "Enter Lab Grade 5");
            // 
            // quizTextBox5
            // 
            quizTextBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizTextBox5.Location = new Point(365, 226);
            quizTextBox5.Name = "quizTextBox5";
            quizTextBox5.Size = new Size(100, 26);
            quizTextBox5.TabIndex = 15;
            toolTip1.SetToolTip(quizTextBox5, "Enter Quiz Grade 5");
            // 
            // quizTextBox4
            // 
            quizTextBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizTextBox4.Location = new Point(365, 194);
            quizTextBox4.Name = "quizTextBox4";
            quizTextBox4.Size = new Size(100, 26);
            quizTextBox4.TabIndex = 14;
            toolTip1.SetToolTip(quizTextBox4, "Enter Quiz Grade 4");
            // 
            // quizTextBox3
            // 
            quizTextBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizTextBox3.Location = new Point(365, 162);
            quizTextBox3.Name = "quizTextBox3";
            quizTextBox3.Size = new Size(100, 26);
            quizTextBox3.TabIndex = 13;
            toolTip1.SetToolTip(quizTextBox3, "Enter Quiz Grade 3");
            // 
            // quizTextBox2
            // 
            quizTextBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizTextBox2.Location = new Point(365, 130);
            quizTextBox2.Name = "quizTextBox2";
            quizTextBox2.Size = new Size(100, 26);
            quizTextBox2.TabIndex = 12;
            toolTip1.SetToolTip(quizTextBox2, "Enter Quiz Grade 2");
            // 
            // quizTextBox1
            // 
            quizTextBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizTextBox1.Location = new Point(365, 98);
            quizTextBox1.Name = "quizTextBox1";
            quizTextBox1.Size = new Size(100, 26);
            quizTextBox1.TabIndex = 11;
            toolTip1.SetToolTip(quizTextBox1, "Enter Quiz Grade 1");
            // 
            // finalReusltLbl
            // 
            finalReusltLbl.AutoSize = true;
            finalReusltLbl.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finalReusltLbl.Location = new Point(36, 405);
            finalReusltLbl.Name = "finalReusltLbl";
            finalReusltLbl.Size = new Size(97, 15);
            finalReusltLbl.TabIndex = 40;
            finalReusltLbl.Text = "Final grade here";
            toolTip1.SetToolTip(finalReusltLbl, "Final Grade Result");
            // 
            // letterGradeLbl
            // 
            letterGradeLbl.AutoSize = true;
            letterGradeLbl.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            letterGradeLbl.Location = new Point(36, 445);
            letterGradeLbl.Name = "letterGradeLbl";
            letterGradeLbl.Size = new Size(105, 15);
            letterGradeLbl.TabIndex = 41;
            letterGradeLbl.Text = "Letter Grade here";
            toolTip1.SetToolTip(letterGradeLbl, "Letter Grade Result");
            // 
            // examAverageLbl
            // 
            examAverageLbl.AutoSize = true;
            examAverageLbl.BorderStyle = BorderStyle.FixedSingle;
            examAverageLbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examAverageLbl.Location = new Point(34, 304);
            examAverageLbl.Name = "examAverageLbl";
            examAverageLbl.Size = new Size(113, 21);
            examAverageLbl.TabIndex = 32;
            examAverageLbl.Text = "Exam Average:";
            examAverageLbl.TextAlign = ContentAlignment.TopCenter;
            toolTip1.SetToolTip(examAverageLbl, "Shows average for Exam Grade");
            // 
            // labAverageLbl
            // 
            labAverageLbl.AutoSize = true;
            labAverageLbl.BorderStyle = BorderStyle.FixedSingle;
            labAverageLbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAverageLbl.Location = new Point(202, 304);
            labAverageLbl.Name = "labAverageLbl";
            labAverageLbl.Size = new Size(101, 21);
            labAverageLbl.TabIndex = 33;
            labAverageLbl.Text = "Lab Average:";
            labAverageLbl.TextAlign = ContentAlignment.TopCenter;
            toolTip1.SetToolTip(labAverageLbl, "Shows average for Lab Grade");
            // 
            // quizAverageLbl
            // 
            quizAverageLbl.AutoSize = true;
            quizAverageLbl.BorderStyle = BorderStyle.FixedSingle;
            quizAverageLbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizAverageLbl.Location = new Point(357, 304);
            quizAverageLbl.Name = "quizAverageLbl";
            quizAverageLbl.Size = new Size(105, 21);
            quizAverageLbl.TabIndex = 34;
            quizAverageLbl.Text = "Quiz Average:";
            quizAverageLbl.TextAlign = ContentAlignment.TopCenter;
            toolTip1.SetToolTip(quizAverageLbl, "Shows average for Quiz Grade");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 76);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 3;
            label1.Text = "Exam Grades:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 8;
            label2.Text = "Lab Grades:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(365, 76);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 17;
            label3.Text = "Quiz Grades";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 330);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(132, 19);
            label4.Name = "label4";
            label4.Size = new Size(246, 31);
            label4.TabIndex = 42;
            label4.Text = "Final Grade Report";
            // 
            // Form1
            // 
            AcceptButton = finalBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            CancelButton = closeBtn;
            ClientSize = new Size(528, 569);
            Controls.Add(label4);
            Controls.Add(closeBtn);
            Controls.Add(clearBtn);
            Controls.Add(letterGradeLbl);
            Controls.Add(finalReusltLbl);
            Controls.Add(label9);
            Controls.Add(finalBtn);
            Controls.Add(quizAverageLbl);
            Controls.Add(labAverageLbl);
            Controls.Add(examAverageLbl);
            Controls.Add(examBtn);
            Controls.Add(quizTextBox5);
            Controls.Add(quizTextBox4);
            Controls.Add(quizTextBox3);
            Controls.Add(quizTextBox2);
            Controls.Add(quizTextBox1);
            Controls.Add(labTextBox5);
            Controls.Add(labTextBox4);
            Controls.Add(labTextBox3);
            Controls.Add(labTextBox2);
            Controls.Add(labTextBox1);
            Controls.Add(examTextBox4);
            Controls.Add(examTextBox3);
            Controls.Add(examTextBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(examTextBox1);
            Controls.Add(label1);
            Controls.Add(quizBtn);
            Controls.Add(labBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Final Grade Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button labBtn;
        private Button quizBtn;
        private ToolTip toolTip1;
        private Label label1;
        private TextBox examTextBox1;
        private Label label2;
        private Label label3;
        private TextBox examTextBox2;
        private TextBox examTextBox3;
        private TextBox examTextBox4;
        private TextBox labTextBox4;
        private TextBox labTextBox3;
        private TextBox labTextBox2;
        private TextBox labTextBox1;
        private TextBox labTextBox5;
        private TextBox quizTextBox5;
        private TextBox quizTextBox4;
        private TextBox quizTextBox3;
        private TextBox quizTextBox2;
        private TextBox quizTextBox1;
        private Button examBtn;
        private Label examAverageLbl;
        private Label labAverageLbl;
        private Label quizAverageLbl;
        private Button finalBtn;
        private Label label9;
        private Label label10;
        private Label finalReusltLbl;
        private Label letterGradeLbl;
        private Button clearBtn;
        private Button closeBtn;
        private Label label4;
    }
}
