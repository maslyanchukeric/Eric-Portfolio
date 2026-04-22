namespace maslyanchuk_E_Lab_7_Chapter_7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            studentListBox = new ListBox();
            correctListBox = new ListBox();
            wrongListBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            correctAnswerLabel = new Label();
            incorrectAnswerLabel = new Label();
            calculateBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            label9 = new Label();
            gradeLabel = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 26);
            label1.TabIndex = 0;
            label1.Text = "Driver License Exam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Student Answers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 101);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 0;
            label3.Text = "Correct Answers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 101);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 0;
            label4.Text = "Wrong Answers";
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(22, 119);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(120, 94);
            studentListBox.TabIndex = 0;
            toolTip1.SetToolTip(studentListBox, "Student Answers ");
            // 
            // correctListBox
            // 
            correctListBox.FormattingEnabled = true;
            correctListBox.ItemHeight = 15;
            correctListBox.Location = new Point(231, 119);
            correctListBox.Name = "correctListBox";
            correctListBox.Size = new Size(120, 94);
            correctListBox.TabIndex = 0;
            toolTip1.SetToolTip(correctListBox, "Correct Answers");
            // 
            // wrongListBox
            // 
            wrongListBox.FormattingEnabled = true;
            wrongListBox.ItemHeight = 15;
            wrongListBox.Location = new Point(430, 119);
            wrongListBox.Name = "wrongListBox";
            wrongListBox.Size = new Size(120, 94);
            wrongListBox.TabIndex = 0;
            toolTip1.SetToolTip(wrongListBox, "Wrong Answers");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 260);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 0;
            label5.Text = "Correct Answers:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 294);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 0;
            label6.Text = "Incorrect Answers:\r\n";
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.BorderStyle = BorderStyle.FixedSingle;
            correctAnswerLabel.Location = new Point(131, 252);
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new Size(100, 23);
            correctAnswerLabel.TabIndex = 0;
            toolTip1.SetToolTip(correctAnswerLabel, "Shows students correct answers on exam");
            // 
            // incorrectAnswerLabel
            // 
            incorrectAnswerLabel.BorderStyle = BorderStyle.FixedSingle;
            incorrectAnswerLabel.Location = new Point(139, 286);
            incorrectAnswerLabel.Name = "incorrectAnswerLabel";
            incorrectAnswerLabel.Size = new Size(100, 23);
            incorrectAnswerLabel.TabIndex = 0;
            toolTip1.SetToolTip(incorrectAnswerLabel, "Shows students incorrect answers on exam\r\n");
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(38, 360);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(75, 43);
            calculateBtn.TabIndex = 1;
            calculateBtn.Text = "Ca&lculate Grade";
            toolTip1.SetToolTip(calculateBtn, "Calculates grade");
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(231, 360);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 43);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(430, 360);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 43);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 329);
            label9.Name = "label9";
            label9.Size = new Size(109, 15);
            label9.TabIndex = 0;
            label9.Text = "Grade Percentage:";
            // 
            // gradeLabel
            // 
            gradeLabel.BorderStyle = BorderStyle.FixedSingle;
            gradeLabel.Location = new Point(131, 321);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(100, 23);
            gradeLabel.TabIndex = 0;
            toolTip1.SetToolTip(gradeLabel, "Grade on Exam");
            // 
            // Form1
            // 
            AcceptButton = calculateBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            CancelButton = exitBtn;
            ClientSize = new Size(571, 450);
            Controls.Add(gradeLabel);
            Controls.Add(label9);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(incorrectAnswerLabel);
            Controls.Add(correctAnswerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(wrongListBox);
            Controls.Add(correctListBox);
            Controls.Add(studentListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Lab-7-Chapter-7-CPT-185-A01 Driver License Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox studentListBox;
        private ListBox correctListBox;
        private ListBox wrongListBox;
        private Label label5;
        private Label label6;
        private Label correctAnswerLabel;
        private Label incorrectAnswerLabel;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label9;
        private Label gradeLabel;
        private ToolTip toolTip1;
    }
}
