namespace maslyanchuk_E_Test_1
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
            carListBox = new ListBox();
            transmissionListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calculatePriceBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            taxRateLabel = new Label();
            salesTaxTextBox = new TextBox();
            label5 = new Label();
            priceLabel = new Label();
            transLabel = new Label();
            subTotalLabel = new Label();
            taxLabel = new Label();
            Total = new Label();
            priceOutputLabel = new Label();
            transOutputLabel = new Label();
            subTotalOutputLabel = new Label();
            taxOutputLabel = new Label();
            totalOutputLabel = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // carListBox
            // 
            carListBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 15;
            carListBox.Items.AddRange(new object[] { "Lamborghini", "Ferrari", "Corvette", "Tesla", "Bentley" });
            carListBox.Location = new Point(12, 66);
            carListBox.Name = "carListBox";
            carListBox.Size = new Size(120, 94);
            carListBox.TabIndex = 0;
            toolTip1.SetToolTip(carListBox, "Select a Car");
            // 
            // transmissionListBox
            // 
            transmissionListBox.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            transmissionListBox.FormattingEnabled = true;
            transmissionListBox.ItemHeight = 15;
            transmissionListBox.Items.AddRange(new object[] { "Manual Transmission", "Automatic Transmission", "Hybird Transmission" });
            transmissionListBox.Location = new Point(12, 185);
            transmissionListBox.Name = "transmissionListBox";
            transmissionListBox.Size = new Size(151, 94);
            transmissionListBox.TabIndex = 1;
            toolTip1.SetToolTip(transmissionListBox, "Select a Transmission");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 24);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Car Dealership Pricing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Select Car";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            label3.Location = new Point(13, 167);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Select Transmission";
            // 
            // calculatePriceBtn
            // 
            calculatePriceBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            calculatePriceBtn.Location = new Point(12, 338);
            calculatePriceBtn.Name = "calculatePriceBtn";
            calculatePriceBtn.Size = new Size(75, 43);
            calculatePriceBtn.TabIndex = 3;
            calculatePriceBtn.Text = "Calculate &Price";
            toolTip1.SetToolTip(calculatePriceBtn, "Calculates the full price of car  ");
            calculatePriceBtn.UseVisualStyleBackColor = true;
            calculatePriceBtn.Click += calculatePriceBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(166, 338);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 43);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clears the form");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(299, 338);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 43);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exits the form");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // taxRateLabel
            // 
            taxRateLabel.AutoSize = true;
            taxRateLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            taxRateLabel.Location = new Point(12, 297);
            taxRateLabel.Name = "taxRateLabel";
            taxRateLabel.Size = new Size(58, 15);
            taxRateLabel.TabIndex = 8;
            taxRateLabel.Text = "Tax Rate:";
            // 
            // salesTaxTextBox
            // 
            salesTaxTextBox.Location = new Point(81, 289);
            salesTaxTextBox.Name = "salesTaxTextBox";
            salesTaxTextBox.Size = new Size(100, 23);
            salesTaxTextBox.TabIndex = 2;
            toolTip1.SetToolTip(salesTaxTextBox, "Enter a tax rate");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(200, 48);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "Selected Auto";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(200, 75);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 15);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price:";
            // 
            // transLabel
            // 
            transLabel.AutoSize = true;
            transLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transLabel.Location = new Point(200, 112);
            transLabel.Name = "transLabel";
            transLabel.Size = new Size(76, 15);
            transLabel.TabIndex = 12;
            transLabel.Text = "Trans Label:";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotalLabel.Location = new Point(200, 167);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(56, 15);
            subTotalLabel.TabIndex = 13;
            subTotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taxLabel.Location = new Point(200, 210);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(63, 15);
            taxLabel.TabIndex = 14;
            taxLabel.Text = "Tax Label:";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.Location = new Point(203, 245);
            Total.Name = "Total";
            Total.Size = new Size(38, 15);
            Total.TabIndex = 15;
            Total.Text = "Total:";
            // 
            // priceOutputLabel
            // 
            priceOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            priceOutputLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceOutputLabel.Location = new Point(247, 67);
            priceOutputLabel.Name = "priceOutputLabel";
            priceOutputLabel.Size = new Size(155, 23);
            priceOutputLabel.TabIndex = 16;
            priceOutputLabel.Text = "label4";
            priceOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(priceOutputLabel, "Shows car price");
            // 
            // transOutputLabel
            // 
            transOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            transOutputLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transOutputLabel.Location = new Point(282, 104);
            transOutputLabel.Name = "transOutputLabel";
            transOutputLabel.Size = new Size(155, 23);
            transOutputLabel.TabIndex = 17;
            transOutputLabel.Text = "label4";
            transOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(transOutputLabel, "Shows transmission price");
            // 
            // subTotalOutputLabel
            // 
            subTotalOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            subTotalOutputLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotalOutputLabel.Location = new Point(262, 159);
            subTotalOutputLabel.Name = "subTotalOutputLabel";
            subTotalOutputLabel.Size = new Size(175, 23);
            subTotalOutputLabel.TabIndex = 18;
            subTotalOutputLabel.Text = "label4";
            subTotalOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(subTotalOutputLabel, "shows the subtotal");
            // 
            // taxOutputLabel
            // 
            taxOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            taxOutputLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taxOutputLabel.Location = new Point(269, 202);
            taxOutputLabel.Name = "taxOutputLabel";
            taxOutputLabel.Size = new Size(100, 23);
            taxOutputLabel.TabIndex = 19;
            taxOutputLabel.Text = "label4";
            taxOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(taxOutputLabel, "Shows the sales tax");
            // 
            // totalOutputLabel
            // 
            totalOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            totalOutputLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOutputLabel.Location = new Point(247, 237);
            totalOutputLabel.Name = "totalOutputLabel";
            totalOutputLabel.Size = new Size(100, 23);
            totalOutputLabel.TabIndex = 20;
            totalOutputLabel.Text = "label4";
            totalOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(totalOutputLabel, "Shows the full price");
            // 
            // Form1
            // 
            AcceptButton = calculatePriceBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            CancelButton = exitBtn;
            ClientSize = new Size(525, 393);
            Controls.Add(totalOutputLabel);
            Controls.Add(taxOutputLabel);
            Controls.Add(subTotalOutputLabel);
            Controls.Add(transOutputLabel);
            Controls.Add(priceOutputLabel);
            Controls.Add(Total);
            Controls.Add(taxLabel);
            Controls.Add(subTotalLabel);
            Controls.Add(transLabel);
            Controls.Add(priceLabel);
            Controls.Add(label5);
            Controls.Add(salesTaxTextBox);
            Controls.Add(taxRateLabel);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculatePriceBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(transmissionListBox);
            Controls.Add(carListBox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-CPT-185-A01 Test -1 Car Dealership Pricing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox carListBox;
        private ListBox transmissionListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button calculatePriceBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label taxRateLabel;
        private TextBox salesTaxTextBox;
        private Label label5;
        private Label priceLabel;
        private Label transLabel;
        private Label subTotalLabel;
        private Label taxLabel;
        private Label Total;
        private Label priceOutputLabel;
        private Label transOutputLabel;
        private Label subTotalOutputLabel;
        private Label taxOutputLabel;
        private Label totalOutputLabel;
        private ToolTip toolTip1;
    }
}
