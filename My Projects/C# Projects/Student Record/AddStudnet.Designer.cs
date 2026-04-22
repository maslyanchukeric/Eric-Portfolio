namespace Student_Record
{
    partial class AddStudnet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            gpaTextBox = new TextBox();
            addStudentBtn = new Button();
            exitBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            listBoxAddedName = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the Student Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(169, 23);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(133, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 100);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter Student GPA";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(169, 62);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(133, 23);
            idTextBox.TabIndex = 4;
            // 
            // gpaTextBox
            // 
            gpaTextBox.Location = new Point(169, 100);
            gpaTextBox.Name = "gpaTextBox";
            gpaTextBox.Size = new Size(133, 23);
            gpaTextBox.TabIndex = 5;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Location = new Point(26, 148);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(103, 23);
            addStudentBtn.TabIndex = 6;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(227, 148);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // listBoxAddedName
            // 
            listBoxAddedName.FormattingEnabled = true;
            listBoxAddedName.ItemHeight = 15;
            listBoxAddedName.Location = new Point(26, 188);
            listBoxAddedName.Name = "listBoxAddedName";
            listBoxAddedName.Size = new Size(276, 94);
            listBoxAddedName.TabIndex = 8;
            // 
            // AddStudnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 363);
            Controls.Add(listBoxAddedName);
            Controls.Add(exitBtn);
            Controls.Add(addStudentBtn);
            Controls.Add(gpaTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "AddStudnet";
            Text = "AddStudnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private TextBox idTextBox;
        private TextBox gpaTextBox;
        private Button addStudentBtn;
        private Button exitBtn;
        private SaveFileDialog saveFileDialog1;
        private ListBox listBoxAddedName;
    }
}