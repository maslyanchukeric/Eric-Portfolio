namespace Student_Record
{
    partial class StudentFinderForm
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
            findStudentBtn = new Button();
            nameTextBox = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // findStudentBtn
            // 
            findStudentBtn.Location = new Point(158, 40);
            findStudentBtn.Name = "findStudentBtn";
            findStudentBtn.Size = new Size(121, 23);
            findStudentBtn.TabIndex = 0;
            findStudentBtn.Text = "Find Student Name";
            findStudentBtn.UseVisualStyleBackColor = true;
            findStudentBtn.Click += findStudentBtn_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 40);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(140, 23);
            nameTextBox.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 94);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Student Name to find";
            // 
            // StudentFinderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 203);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(nameTextBox);
            Controls.Add(findStudentBtn);
            Name = "StudentFinderForm";
            Text = "StudentFinderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button findStudentBtn;
        private TextBox nameTextBox;
        private ListBox listBox1;
        private Label label1;
    }
}