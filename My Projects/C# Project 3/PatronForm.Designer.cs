namespace maslyanchuk_E_Test_3
{
    partial class PatronForm
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
            editPatronBtn = new Button();
            removePatronBtn = new Button();
            addParton = new Button();
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            iDTextBox = new TextBox();
            listBoxPatron = new ListBox();
            label3 = new Label();
            label4 = new Label();
            exitBtn = new Button();
            toolTipPatron = new ToolTip(components);
            SuspendLayout();
            // 
            // editPatronBtn
            // 
            editPatronBtn.Location = new Point(556, 142);
            editPatronBtn.Name = "editPatronBtn";
            editPatronBtn.Size = new Size(101, 23);
            editPatronBtn.TabIndex = 4;
            editPatronBtn.Text = "&Edit Patron";
            toolTipPatron.SetToolTip(editPatronBtn, "Edit patron");
            editPatronBtn.UseVisualStyleBackColor = true;
            editPatronBtn.Click += editPatronBtn_Click;
            // 
            // removePatronBtn
            // 
            removePatronBtn.Location = new Point(230, 142);
            removePatronBtn.Name = "removePatronBtn";
            removePatronBtn.Size = new Size(101, 23);
            removePatronBtn.TabIndex = 3;
            removePatronBtn.Text = "&Remove Patron\r\n";
            toolTipPatron.SetToolTip(removePatronBtn, "Remove patron");
            removePatronBtn.UseVisualStyleBackColor = true;
            removePatronBtn.Click += removePatronBtn_Click;
            // 
            // addParton
            // 
            addParton.Location = new Point(17, 133);
            addParton.Name = "addParton";
            addParton.Size = new Size(101, 23);
            addParton.TabIndex = 2;
            addParton.Text = "&Add Patrons\r\n";
            toolTipPatron.SetToolTip(addParton, "Add parton");
            addParton.UseVisualStyleBackColor = true;
            addParton.Click += addParton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 85);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "Id";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(61, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 22);
            nameTextBox.TabIndex = 0;
            toolTipPatron.SetToolTip(nameTextBox, "Enter Name");
            // 
            // iDTextBox
            // 
            iDTextBox.Location = new Point(40, 78);
            iDTextBox.Name = "iDTextBox";
            iDTextBox.Size = new Size(100, 22);
            iDTextBox.TabIndex = 1;
            toolTipPatron.SetToolTip(iDTextBox, "Enter ID");
            // 
            // listBoxPatron
            // 
            listBoxPatron.FormattingEnabled = true;
            listBoxPatron.ItemHeight = 15;
            listBoxPatron.Location = new Point(230, 42);
            listBoxPatron.Name = "listBoxPatron";
            listBoxPatron.Size = new Size(427, 94);
            listBoxPatron.TabIndex = 0;
            listBoxPatron.SelectedIndexChanged += listBoxPatron_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 9);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 0;
            label3.Text = "Add a Patron";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(407, 9);
            label4.Name = "label4";
            label4.Size = new Size(100, 19);
            label4.TabIndex = 0;
            label4.Text = "List of Parton";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(17, 162);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(101, 23);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // PatronForm
            // 
            AcceptButton = addParton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(669, 194);
            Controls.Add(exitBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxPatron);
            Controls.Add(iDTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(editPatronBtn);
            Controls.Add(removePatronBtn);
            Controls.Add(addParton);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "PatronForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatronForm Maslyanchuk-Test-3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editPatronBtn;
        private Button removePatronBtn;
        private Button addParton;
        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox iDTextBox;
        private ListBox listBoxPatron;
        private Label label3;
        private Label label4;
        private Button exitBtn;
        private ToolTip toolTipPatron;
    }
}