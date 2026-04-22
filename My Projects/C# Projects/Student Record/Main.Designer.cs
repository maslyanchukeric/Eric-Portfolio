namespace Student_Record
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
            label1 = new Label();
            findStudnetBtn = new Button();
            addStudentBtnd = new Button();
            removeStudentBtn = new Button();
            button3 = new Button();
            listBoxNames = new ListBox();
            eixtBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 31);
            label1.Name = "label1";
            label1.Size = new Size(370, 32);
            label1.TabIndex = 0;
            label1.Text = "Weclome To Student Records";
            // 
            // findStudnetBtn
            // 
            findStudnetBtn.Location = new Point(39, 167);
            findStudnetBtn.Name = "findStudnetBtn";
            findStudnetBtn.Size = new Size(113, 23);
            findStudnetBtn.TabIndex = 1;
            findStudnetBtn.Text = "Find Student ";
            findStudnetBtn.UseVisualStyleBackColor = true;
            findStudnetBtn.Click += findStudnetBtn_Click;
            // 
            // addStudentBtnd
            // 
            addStudentBtnd.Location = new Point(226, 167);
            addStudentBtnd.Name = "addStudentBtnd";
            addStudentBtnd.Size = new Size(113, 23);
            addStudentBtnd.TabIndex = 2;
            addStudentBtnd.Text = "Add Student ";
            addStudentBtnd.UseVisualStyleBackColor = true;
            addStudentBtnd.Click += addStudentBtnd_Click;
            // 
            // removeStudentBtn
            // 
            removeStudentBtn.Location = new Point(410, 167);
            removeStudentBtn.Name = "removeStudentBtn";
            removeStudentBtn.Size = new Size(113, 23);
            removeStudentBtn.TabIndex = 3;
            removeStudentBtn.Text = "Remove Student";
            removeStudentBtn.UseVisualStyleBackColor = true;
            removeStudentBtn.Click += removeStudentBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(629, 167);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 4;
            button3.Text = "Student Info";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBoxNames
            // 
            listBoxNames.FormattingEnabled = true;
            listBoxNames.ItemHeight = 15;
            listBoxNames.Location = new Point(39, 229);
            listBoxNames.Name = "listBoxNames";
            listBoxNames.Size = new Size(703, 139);
            listBoxNames.TabIndex = 5;
            // 
            // eixtBtn
            // 
            eixtBtn.Location = new Point(667, 402);
            eixtBtn.Name = "eixtBtn";
            eixtBtn.Size = new Size(75, 23);
            eixtBtn.TabIndex = 7;
            eixtBtn.Text = "Exit";
            eixtBtn.UseVisualStyleBackColor = true;
            eixtBtn.Click += eixtBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eixtBtn);
            Controls.Add(listBoxNames);
            Controls.Add(button3);
            Controls.Add(removeStudentBtn);
            Controls.Add(addStudentBtnd);
            Controls.Add(findStudnetBtn);
            Controls.Add(label1);
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button findStudnetBtn;
        private Button addStudentBtnd;
        private Button removeStudentBtn;
        private Button button3;
        private ListBox listBoxNames;
        private Button eixtBtn;
        private SaveFileDialog saveFileDialog1;
    }
}
