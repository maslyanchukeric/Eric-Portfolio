namespace maslyanchuk_E_Lab_5_Chapter_5
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
            startNumTxtBox = new TextBox();
            percentageTxtBox = new TextBox();
            daysNumTxtBox = new TextBox();
            populationListBox = new ListBox();
            label5 = new Label();
            calculateBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 24);
            label1.TabIndex = 0;
            label1.Text = "Population Growth Predictor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 1;
            label2.Text = "Starting Number of Orginisms:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(202, 15);
            label3.TabIndex = 2;
            label3.Text = "Average Daily Increase Percentage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Number of Days:";
            // 
            // startNumTxtBox
            // 
            startNumTxtBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            startNumTxtBox.Location = new Point(198, 50);
            startNumTxtBox.Name = "startNumTxtBox";
            startNumTxtBox.Size = new Size(100, 22);
            startNumTxtBox.TabIndex = 0;
            toolTip1.SetToolTip(startNumTxtBox, "Enter Starting amount of Orginisms");
            // 
            // percentageTxtBox
            // 
            percentageTxtBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            percentageTxtBox.Location = new Point(220, 105);
            percentageTxtBox.Name = "percentageTxtBox";
            percentageTxtBox.Size = new Size(100, 22);
            percentageTxtBox.TabIndex = 1;
            toolTip1.SetToolTip(percentageTxtBox, "Enter daily increase percentage");
            // 
            // daysNumTxtBox
            // 
            daysNumTxtBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            daysNumTxtBox.Location = new Point(116, 153);
            daysNumTxtBox.Name = "daysNumTxtBox";
            daysNumTxtBox.Size = new Size(100, 22);
            daysNumTxtBox.TabIndex = 2;
            toolTip1.SetToolTip(daysNumTxtBox, "Enter the number of days ");
            // 
            // populationListBox
            // 
            populationListBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            populationListBox.FormattingEnabled = true;
            populationListBox.ItemHeight = 15;
            populationListBox.Location = new Point(389, 68);
            populationListBox.Name = "populationListBox";
            populationListBox.Size = new Size(208, 124);
            populationListBox.TabIndex = 7;
            toolTip1.SetToolTip(populationListBox, "Population results");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label5.Location = new Point(389, 50);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 8;
            label5.Text = "Population Growth:";
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            calculateBtn.Location = new Point(13, 217);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(75, 23);
            calculateBtn.TabIndex = 3;
            calculateBtn.Text = "Ca&lculate";
            toolTip1.SetToolTip(calculateBtn, "Calculates the population");
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(273, 217);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(522, 217);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AcceptButton = calculateBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            CancelButton = exitBtn;
            ClientSize = new Size(614, 253);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(populationListBox);
            Controls.Add(percentageTxtBox);
            Controls.Add(label4);
            Controls.Add(startNumTxtBox);
            Controls.Add(daysNumTxtBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Lab-5-Chapter-5-CPT-185-A01- Population-Growth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox startNumTxtBox;
        private TextBox percentageTxtBox;
        private TextBox daysNumTxtBox;
        private ListBox populationListBox;
        private Label label5;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private ToolTip toolTip1;
    }
}
