namespace maslyanchuk_E_Chapter_8_Lab_8
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
            stringTextBox = new TextBox();
            convertBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            label3 = new Label();
            resultsLabel = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 22);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Morse Code Converter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(47, 56);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 1;
            label2.Text = "Please anything you would like:";
            // 
            // stringTextBox
            // 
            stringTextBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            stringTextBox.Location = new Point(47, 90);
            stringTextBox.Name = "stringTextBox";
            stringTextBox.Size = new Size(279, 22);
            stringTextBox.TabIndex = 2;
            toolTip1.SetToolTip(stringTextBox, "Enter want you want to convert to morse code");
            // 
            // convertBtn
            // 
            convertBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            convertBtn.Location = new Point(47, 143);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(75, 46);
            convertBtn.TabIndex = 3;
            convertBtn.Text = "C&onvert Code";
            toolTip1.SetToolTip(convertBtn, "Converts your entry");
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(145, 143);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 46);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "&Clear ";
            toolTip1.SetToolTip(clearBtn, "Clears the form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(251, 143);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 46);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Eixnts the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label3.Location = new Point(56, 218);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Mores Code:";
            // 
            // resultsLabel
            // 
            resultsLabel.BorderStyle = BorderStyle.FixedSingle;
            resultsLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            resultsLabel.Location = new Point(56, 244);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(270, 184);
            resultsLabel.TabIndex = 7;
            toolTip1.SetToolTip(resultsLabel, "Morse code results here");
            resultsLabel.UseWaitCursor = true;
            // 
            // Form1
            // 
            AcceptButton = convertBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitBtn;
            ClientSize = new Size(395, 450);
            Controls.Add(resultsLabel);
            Controls.Add(label3);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(convertBtn);
            Controls.Add(stringTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Chapter-8-Lab-8-Morse Code Converter ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox stringTextBox;
        private Button convertBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label3;
        private Label resultsLabel;
        private ToolTip toolTip1;
    }
}
