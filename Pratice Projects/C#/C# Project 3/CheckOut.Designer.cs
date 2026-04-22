namespace maslyanchuk_E_Test_3
{
    partial class CheckOut
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
            checkOutBtn = new Button();
            booksComboBox = new ComboBox();
            patronComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            returnBtn = new Button();
            label3 = new Label();
            toolTipCheckOut = new ToolTip(components);
            exitBtn = new Button();
            SuspendLayout();
            // 
            // checkOutBtn
            // 
            checkOutBtn.Location = new Point(47, 147);
            checkOutBtn.Name = "checkOutBtn";
            checkOutBtn.Size = new Size(75, 23);
            checkOutBtn.TabIndex = 2;
            checkOutBtn.Text = "&Check Out";
            toolTipCheckOut.SetToolTip(checkOutBtn, "Check out book");
            checkOutBtn.UseVisualStyleBackColor = true;
            checkOutBtn.Click += checkOutBtn_Click;
            // 
            // booksComboBox
            // 
            booksComboBox.FormattingEnabled = true;
            booksComboBox.Location = new Point(47, 80);
            booksComboBox.Name = "booksComboBox";
            booksComboBox.Size = new Size(121, 23);
            booksComboBox.TabIndex = 0;
            toolTipCheckOut.SetToolTip(booksComboBox, "Select a book");
            // 
            // patronComboBox
            // 
            patronComboBox.FormattingEnabled = true;
            patronComboBox.Location = new Point(218, 80);
            patronComboBox.Name = "patronComboBox";
            patronComboBox.Size = new Size(121, 23);
            patronComboBox.TabIndex = 1;
            toolTipCheckOut.SetToolTip(patronComboBox, "Select a patron");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Select Patron";
            // 
            // returnBtn
            // 
            returnBtn.Location = new Point(264, 147);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(75, 23);
            returnBtn.TabIndex = 3;
            returnBtn.Text = "&Return ";
            toolTipCheckOut.SetToolTip(returnBtn, "Return the book");
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 9);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 0;
            label3.Text = "Checking Out";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(163, 169);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "&Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // CheckOut
            // 
            AcceptButton = checkOutBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(430, 204);
            Controls.Add(exitBtn);
            Controls.Add(label3);
            Controls.Add(returnBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(patronComboBox);
            Controls.Add(booksComboBox);
            Controls.Add(checkOutBtn);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut maslyanchuk-E-Test-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkOutBtn;
        private ComboBox booksComboBox;
        private ComboBox patronComboBox;
        private Label label1;
        private Label label2;
        private Button returnBtn;
        private Label label3;
        private ToolTip toolTipCheckOut;
        private Button exitBtn;
    }
}