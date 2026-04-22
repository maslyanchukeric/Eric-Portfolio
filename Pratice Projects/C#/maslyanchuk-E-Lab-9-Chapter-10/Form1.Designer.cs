namespace maslyanchuk_E_Lab_9_Chapter_10
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
            getBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            nameListBox = new ListBox();
            idListBox = new ListBox();
            departmentListBox = new ListBox();
            positionListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.Location = new Point(20, 184);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(100, 23);
            getBtn.TabIndex = 0;
            getBtn.Text = "G&et Employee";
            toolTip1.SetToolTip(getBtn, "Gets the Employee infor");
            getBtn.UseVisualStyleBackColor = true;
            getBtn.Click += getBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(225, 184);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears the form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(446, 184);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // nameListBox
            // 
            nameListBox.FormattingEnabled = true;
            nameListBox.ItemHeight = 15;
            nameListBox.Location = new Point(20, 63);
            nameListBox.Name = "nameListBox";
            nameListBox.Size = new Size(120, 94);
            nameListBox.TabIndex = 0;
            toolTip1.SetToolTip(nameListBox, "Employee Name will appear");
            // 
            // idListBox
            // 
            idListBox.FormattingEnabled = true;
            idListBox.ItemHeight = 15;
            idListBox.Location = new Point(146, 63);
            idListBox.Name = "idListBox";
            idListBox.Size = new Size(120, 94);
            idListBox.TabIndex = 0;
            toolTip1.SetToolTip(idListBox, "Employee ID will appear");
            // 
            // departmentListBox
            // 
            departmentListBox.FormattingEnabled = true;
            departmentListBox.ItemHeight = 15;
            departmentListBox.Location = new Point(272, 63);
            departmentListBox.Name = "departmentListBox";
            departmentListBox.Size = new Size(120, 94);
            departmentListBox.TabIndex = 0;
            toolTip1.SetToolTip(departmentListBox, "Employee Department will appear");
            // 
            // positionListBox
            // 
            positionListBox.FormattingEnabled = true;
            positionListBox.ItemHeight = 15;
            positionListBox.Location = new Point(398, 63);
            positionListBox.Name = "positionListBox";
            positionListBox.Size = new Size(120, 94);
            positionListBox.TabIndex = 0;
            toolTip1.SetToolTip(positionListBox, "Employee Position will appear");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 45);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 45);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 0;
            label3.Text = "Employee Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 45);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 0;
            label4.Text = "Employee Position";
            // 
            // Form1
            // 
            AcceptButton = getBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(540, 240);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(positionListBox);
            Controls.Add(departmentListBox);
            Controls.Add(idListBox);
            Controls.Add(nameListBox);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(getBtn);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Lab-9-Chpater-10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button getBtn;
        private Button clearBtn;
        private Button exitBtn;
        private ListBox nameListBox;
        private ListBox idListBox;
        private ListBox departmentListBox;
        private ListBox positionListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolTip toolTip1;
    }
}
