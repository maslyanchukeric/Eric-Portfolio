namespace maslyanchuk_E_Test_3
{
    partial class LibraryManagment
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
            managePatronBtn = new Button();
            manageBookBtn = new Button();
            label1 = new Label();
            checkOut = new Button();
            exitBtn = new Button();
            toolTipLibManagementSystem = new ToolTip(components);
            SuspendLayout();
            // 
            // managePatronBtn
            // 
            managePatronBtn.Location = new Point(145, 99);
            managePatronBtn.Name = "managePatronBtn";
            managePatronBtn.Size = new Size(128, 23);
            managePatronBtn.TabIndex = 1;
            managePatronBtn.Text = "Manage &Patrons";
            toolTipLibManagementSystem.SetToolTip(managePatronBtn, "Manage Patron");
            managePatronBtn.UseVisualStyleBackColor = true;
            managePatronBtn.Click += managePatronBtn_Click;
            // 
            // manageBookBtn
            // 
            manageBookBtn.Location = new Point(145, 70);
            manageBookBtn.Name = "manageBookBtn";
            manageBookBtn.Size = new Size(128, 23);
            manageBookBtn.TabIndex = 2;
            manageBookBtn.Text = "Manage &Books";
            toolTipLibManagementSystem.SetToolTip(manageBookBtn, "Manage Books");
            manageBookBtn.UseVisualStyleBackColor = true;
            manageBookBtn.Click += manageBookBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 19);
            label1.TabIndex = 3;
            label1.Text = "Library Management System";
            // 
            // checkOut
            // 
            checkOut.Location = new Point(145, 128);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(128, 23);
            checkOut.TabIndex = 4;
            checkOut.Text = "&Check Out";
            toolTipLibManagementSystem.SetToolTip(checkOut, "Check Out books");
            checkOut.UseVisualStyleBackColor = true;
            checkOut.Click += checkOut_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(172, 157);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            toolTipLibManagementSystem.SetToolTip(exitBtn, "Close the System");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // LibraryManagment
            // 
            AcceptButton = manageBookBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(416, 191);
            Controls.Add(exitBtn);
            Controls.Add(checkOut);
            Controls.Add(label1);
            Controls.Add(manageBookBtn);
            Controls.Add(managePatronBtn);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "LibraryManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System Maslyanchuk-Test-3";
            FormClosing += LibraryManagment_FormClosing;
            Load += LibraryManagment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button managePatronBtn;
        private Button manageBookBtn;
        private Label label1;
        private Button checkOut;
        private Button exitBtn;
        private ToolTip toolTipLibManagementSystem;
    }
}
