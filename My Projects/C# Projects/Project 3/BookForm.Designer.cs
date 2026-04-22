namespace maslyanchuk_E_Test_3
{
    partial class BookForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            titleTextBox = new TextBox();
            autorTextBox = new TextBox();
            isbnTextBox = new TextBox();
            addBookBtn = new Button();
            listBoxBooks = new ListBox();
            removeBookBtn = new Button();
            editBookBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            toolTipBook = new ToolTip(components);
            exitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 132);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "ISBN";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(59, 55);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 22);
            titleTextBox.TabIndex = 3;
            toolTipBook.SetToolTip(titleTextBox, "Title ");
            // 
            // autorTextBox
            // 
            autorTextBox.Location = new Point(66, 91);
            autorTextBox.Name = "autorTextBox";
            autorTextBox.Size = new Size(100, 22);
            autorTextBox.TabIndex = 4;
            toolTipBook.SetToolTip(autorTextBox, "Author");
            // 
            // isbnTextBox
            // 
            isbnTextBox.Location = new Point(61, 124);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(100, 22);
            isbnTextBox.TabIndex = 5;
            toolTipBook.SetToolTip(isbnTextBox, "ISBN");
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(23, 167);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.RightToLeft = RightToLeft.No;
            addBookBtn.Size = new Size(75, 23);
            addBookBtn.TabIndex = 0;
            addBookBtn.Text = "Add &Book";
            toolTipBook.SetToolTip(addBookBtn, "Adds the book to library");
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(217, 53);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(420, 94);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged_1;
            // 
            // removeBookBtn
            // 
            removeBookBtn.Location = new Point(217, 167);
            removeBookBtn.Name = "removeBookBtn";
            removeBookBtn.Size = new Size(106, 23);
            removeBookBtn.TabIndex = 1;
            removeBookBtn.Text = "&Remove Book";
            toolTipBook.SetToolTip(removeBookBtn, "removes book from library");
            removeBookBtn.UseVisualStyleBackColor = true;
            removeBookBtn.Click += removeBookBtn_Click;
            // 
            // editBookBtn
            // 
            editBookBtn.Location = new Point(562, 167);
            editBookBtn.Name = "editBookBtn";
            editBookBtn.RightToLeft = RightToLeft.No;
            editBookBtn.Size = new Size(75, 23);
            editBookBtn.TabIndex = 2;
            editBookBtn.Text = "&Edit Book";
            toolTipBook.SetToolTip(editBookBtn, "Edits book from library");
            editBookBtn.UseVisualStyleBackColor = true;
            editBookBtn.Click += editBookBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 22);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 0;
            label4.Text = "Add a Book";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(397, 22);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 22;
            label5.Text = "List of Books";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(23, 207);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 23;
            exitBtn.Text = "&Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // BookForm
            // 
            AcceptButton = addBookBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = editBookBtn;
            ClientSize = new Size(671, 242);
            Controls.Add(exitBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(editBookBtn);
            Controls.Add(removeBookBtn);
            Controls.Add(listBoxBooks);
            Controls.Add(addBookBtn);
            Controls.Add(isbnTextBox);
            Controls.Add(autorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Form maslyanchuk-E-Test-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox titleTextBox;
        private TextBox autorTextBox;
        private TextBox isbnTextBox;
        private Button addBookBtn;
        private ListBox listBoxBooks;
        private Button removeBookBtn;
        private Button editBookBtn;
        private Label label4;
        private Label label5;
        private ToolTip toolTipBook;
        private Button exitBtn;
    }
}