namespace maslyanchuk_E_Test_2
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
            processBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            yearComboBox = new ComboBox();
            toolTip1 = new ToolTip(components);
            resultLabel = new Label();
            openFileDialogSalary = new OpenFileDialog();
            SuspendLayout();
            // 
            // processBtn
            // 
            processBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            processBtn.Location = new Point(42, 36);
            processBtn.Name = "processBtn";
            processBtn.Size = new Size(121, 40);
            processBtn.TabIndex = 1;
            processBtn.Text = "&Process File";
            toolTip1.SetToolTip(processBtn, "Process the file to find Salaries");
            processBtn.UseVisualStyleBackColor = true;
            processBtn.Click += processBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(42, 107);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(121, 40);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears the form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(42, 182);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(121, 40);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label1.Location = new Point(250, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 3;
            label1.Text = "Select Year";
            // 
            // yearComboBox
            // 
            yearComboBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(319, 36);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 25);
            yearComboBox.TabIndex = 0;
            toolTip1.SetToolTip(yearComboBox, "Select a Year");
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BorderStyle = BorderStyle.FixedSingle;
            resultLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(243, 88);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(49, 19);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "label2";
            toolTip1.SetToolTip(resultLabel, "Shows the results");
            // 
            // openFileDialogSalary
            // 
            openFileDialogSalary.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AcceptButton = processBtn;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            CancelButton = exitBtn;
            ClientSize = new Size(520, 269);
            Controls.Add(resultLabel);
            Controls.Add(yearComboBox);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(processBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Test-2-CPT-185-A01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button processBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label1;
        private ComboBox yearComboBox;
        private ToolTip toolTip1;
        private Label resultLabel;
        private OpenFileDialog openFileDialogSalary;
    }
}
