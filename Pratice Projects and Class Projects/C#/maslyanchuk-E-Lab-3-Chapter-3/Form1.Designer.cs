namespace maslyanchuk_E_Lab_3
{
    partial class stadiumSeating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stadiumSeating));
            groupBox1 = new GroupBox();
            classCTxtBox = new TextBox();
            classATxtBox = new TextBox();
            classBTxtBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            groupBox2 = new GroupBox();
            totalTxtBox = new TextBox();
            label8 = new Label();
            RevenueCTxtBox = new TextBox();
            RevenueATxtBox = new TextBox();
            RevenueBTxtBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            calculateRevenueBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            toolTip1 = new ToolTip(components);
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(classCTxtBox);
            groupBox1.Controls.Add(classATxtBox);
            groupBox1.Controls.Add(classBTxtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            // 
            // classCTxtBox
            // 
            classCTxtBox.Location = new Point(76, 123);
            classCTxtBox.Name = "classCTxtBox";
            classCTxtBox.Size = new Size(100, 22);
            classCTxtBox.TabIndex = 2;
            toolTip1.SetToolTip(classCTxtBox, "Enter Sold Tickets Here");
            // 
            // classATxtBox
            // 
            classATxtBox.BackColor = SystemColors.Window;
            classATxtBox.Location = new Point(76, 56);
            classATxtBox.Name = "classATxtBox";
            classATxtBox.Size = new Size(100, 22);
            classATxtBox.TabIndex = 0;
            toolTip1.SetToolTip(classATxtBox, "Enter Sold Tickets Here");
            // 
            // classBTxtBox
            // 
            classBTxtBox.Location = new Point(76, 88);
            classBTxtBox.Name = "classBTxtBox";
            classBTxtBox.Size = new Size(100, 22);
            classBTxtBox.TabIndex = 1;
            toolTip1.SetToolTip(classBTxtBox, "Enter Sold Tickets Here");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 123);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Class C:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 88);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Class B:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Class A:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold\r\n for each class of seats.\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(totalTxtBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(RevenueCTxtBox);
            groupBox2.Controls.Add(RevenueATxtBox);
            groupBox2.Controls.Add(RevenueBTxtBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(282, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 178);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // totalTxtBox
            // 
            totalTxtBox.Location = new Point(102, 131);
            totalTxtBox.Name = "totalTxtBox";
            totalTxtBox.ReadOnly = true;
            totalTxtBox.Size = new Size(100, 22);
            totalTxtBox.TabIndex = 8;
            toolTip1.SetToolTip(totalTxtBox, "Total Sold Tickets");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 131);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Total:";
            // 
            // RevenueCTxtBox
            // 
            RevenueCTxtBox.Location = new Point(102, 100);
            RevenueCTxtBox.Name = "RevenueCTxtBox";
            RevenueCTxtBox.ReadOnly = true;
            RevenueCTxtBox.Size = new Size(100, 22);
            RevenueCTxtBox.TabIndex = 6;
            toolTip1.SetToolTip(RevenueCTxtBox, "Revenue Of Sold Tickets Here");
            // 
            // RevenueATxtBox
            // 
            RevenueATxtBox.Location = new Point(102, 33);
            RevenueATxtBox.Name = "RevenueATxtBox";
            RevenueATxtBox.ReadOnly = true;
            RevenueATxtBox.Size = new Size(100, 22);
            RevenueATxtBox.TabIndex = 0;
            toolTip1.SetToolTip(RevenueATxtBox, "Revenue Of Sold Tickets Here");
            // 
            // RevenueBTxtBox
            // 
            RevenueBTxtBox.Location = new Point(102, 65);
            RevenueBTxtBox.Name = "RevenueBTxtBox";
            RevenueBTxtBox.ReadOnly = true;
            RevenueBTxtBox.Size = new Size(100, 22);
            RevenueBTxtBox.TabIndex = 5;
            toolTip1.SetToolTip(RevenueBTxtBox, "Revenue Of Sold Tickets Here");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 100);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Class C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 65);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 2;
            label6.Text = "Class B:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 35);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 1;
            label7.Text = "Class A:";
            // 
            // calculateRevenueBtn
            // 
            calculateRevenueBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            calculateRevenueBtn.Location = new Point(12, 238);
            calculateRevenueBtn.Name = "calculateRevenueBtn";
            calculateRevenueBtn.Size = new Size(75, 44);
            calculateRevenueBtn.TabIndex = 1;
            calculateRevenueBtn.Text = "Calculate &Revenue";
            toolTip1.SetToolTip(calculateRevenueBtn, "Calculates Revenue for the tickets \r\n");
            calculateRevenueBtn.UseVisualStyleBackColor = true;
            calculateRevenueBtn.Click += calculateRevenueBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(225, 238);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 44);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears the form ");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += button1_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(441, 238);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 44);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits Form ");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += button2_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(158, 11);
            label9.Name = "label9";
            label9.Size = new Size(202, 31);
            label9.TabIndex = 5;
            label9.Text = "Ticket Revenue ";
            // 
            // stadiumSeating
            // 
            AcceptButton = calculateRevenueBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(528, 314);
            Controls.Add(label9);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateRevenueBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "stadiumSeating";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stadium Seating ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox classCTxtBox;
        private TextBox classATxtBox;
        private TextBox classBTxtBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private HelpProvider helpProvider1;
        private GroupBox groupBox2;
        private TextBox totalTxtBox;
        private Label label8;
        private TextBox RevenueCTxtBox;
        private TextBox RevenueATxtBox;
        private TextBox RevenueBTxtBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button calculateRevenueBtn;
        private Button clearBtn;
        private Button exitBtn;
        private ToolTip toolTip1;
        private Label label9;
    }
}
