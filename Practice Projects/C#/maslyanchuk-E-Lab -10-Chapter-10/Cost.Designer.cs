namespace maslyanchuk_E_Lab__10_Chapter_10
{
    partial class Cost
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
            label4 = new Label();
            dormCostLabel = new Label();
            mealCostLabel = new Label();
            totalCostLabel = new Label();
            aboutBtn = new Button();
            closeBtn = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Dorm and Meal Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(36, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "Dorm Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label3.Location = new Point(36, 80);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Meal Cost:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label4.Location = new Point(36, 118);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Total Cost:";
            // 
            // dormCostLabel
            // 
            dormCostLabel.BorderStyle = BorderStyle.FixedSingle;
            dormCostLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            dormCostLabel.Location = new Point(106, 33);
            dormCostLabel.Name = "dormCostLabel";
            dormCostLabel.Size = new Size(100, 23);
            dormCostLabel.TabIndex = 0;
            dormCostLabel.Text = "dormCostLabel";
            dormCostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mealCostLabel
            // 
            mealCostLabel.BorderStyle = BorderStyle.FixedSingle;
            mealCostLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            mealCostLabel.Location = new Point(106, 72);
            mealCostLabel.Name = "mealCostLabel";
            mealCostLabel.Size = new Size(100, 23);
            mealCostLabel.TabIndex = 0;
            mealCostLabel.Text = "mealCostLabel";
            mealCostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            totalCostLabel.BorderStyle = BorderStyle.FixedSingle;
            totalCostLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            totalCostLabel.Location = new Point(106, 110);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(100, 23);
            totalCostLabel.TabIndex = 0;
            totalCostLabel.Text = "totalCostLabel";
            totalCostLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aboutBtn
            // 
            aboutBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            aboutBtn.Location = new Point(36, 141);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(89, 23);
            aboutBtn.TabIndex = 1;
            aboutBtn.Text = "&Go to About";
            toolTip1.SetToolTip(aboutBtn, "Opens the about form");
            aboutBtn.UseVisualStyleBackColor = true;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            closeBtn.Location = new Point(131, 141);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "&Close";
            toolTip1.SetToolTip(closeBtn, "closes the form");
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Cost
            // 
            AcceptButton = aboutBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = closeBtn;
            ClientSize = new Size(242, 176);
            Controls.Add(closeBtn);
            Controls.Add(aboutBtn);
            Controls.Add(totalCostLabel);
            Controls.Add(mealCostLabel);
            Controls.Add(dormCostLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dorm and Meal Cost";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label dormCostLabel;
        private Label mealCostLabel;
        private Label totalCostLabel;
        private Button aboutBtn;
        private Button closeBtn;
        private ToolTip toolTip1;
    }
}