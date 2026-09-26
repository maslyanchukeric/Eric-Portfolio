namespace maslyanchuk_E_Lab_6_Chapter_6
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
            groupBox1 = new GroupBox();
            lubeCheckBox = new CheckBox();
            oilCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            transmissionCheckBox = new CheckBox();
            radiatorCheckBox = new CheckBox();
            groupBox3 = new GroupBox();
            tireCheckBox = new CheckBox();
            mufflerCheckBox = new CheckBox();
            inpsectioncheckBox = new CheckBox();
            groupBox4 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            laborTextBox = new TextBox();
            partsTextBox = new TextBox();
            groupBox5 = new GroupBox();
            totalFeeLabel = new Label();
            taxLabel = new Label();
            partsLabel = new Label();
            serivceAndLaborLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            calculateBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            label11 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lubeCheckBox);
            groupBox1.Controls.Add(oilCheckBox);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oil and Lube";
            toolTip1.SetToolTip(groupBox1, "Choose a Job");
            // 
            // lubeCheckBox
            // 
            lubeCheckBox.AutoSize = true;
            lubeCheckBox.Location = new Point(44, 56);
            lubeCheckBox.Name = "lubeCheckBox";
            lubeCheckBox.Size = new Size(107, 19);
            lubeCheckBox.TabIndex = 1;
            lubeCheckBox.Text = "Lube Job ($40)";
            toolTip1.SetToolTip(lubeCheckBox, "Lube job option");
            lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilCheckBox
            // 
            oilCheckBox.AutoSize = true;
            oilCheckBox.Location = new Point(44, 22);
            oilCheckBox.Name = "oilCheckBox";
            oilCheckBox.Size = new Size(121, 19);
            oilCheckBox.TabIndex = 0;
            oilCheckBox.Text = "Oil Change ($50)";
            toolTip1.SetToolTip(oilCheckBox, "Change oil option");
            oilCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transmissionCheckBox);
            groupBox2.Controls.Add(radiatorCheckBox);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(218, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flushes";
            toolTip1.SetToolTip(groupBox2, "Choose a job");
            // 
            // transmissionCheckBox
            // 
            transmissionCheckBox.AutoSize = true;
            transmissionCheckBox.Location = new Point(20, 56);
            transmissionCheckBox.Name = "transmissionCheckBox";
            transmissionCheckBox.Size = new Size(174, 19);
            transmissionCheckBox.TabIndex = 1;
            transmissionCheckBox.Text = "Transmission Flush ($120)";
            toolTip1.SetToolTip(transmissionCheckBox, "Transmission flush option");
            transmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            radiatorCheckBox.AutoSize = true;
            radiatorCheckBox.Location = new Point(48, 21);
            radiatorCheckBox.Name = "radiatorCheckBox";
            radiatorCheckBox.Size = new Size(146, 19);
            radiatorCheckBox.TabIndex = 0;
            radiatorCheckBox.Text = "Radiator Flush ($100)";
            toolTip1.SetToolTip(radiatorCheckBox, "Radiator flush option");
            radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tireCheckBox);
            groupBox3.Controls.Add(mufflerCheckBox);
            groupBox3.Controls.Add(inpsectioncheckBox);
            groupBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 127);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            toolTip1.SetToolTip(groupBox3, "Choose a job");
            // 
            // tireCheckBox
            // 
            tireCheckBox.AutoSize = true;
            tireCheckBox.Location = new Point(44, 93);
            tireCheckBox.Name = "tireCheckBox";
            tireCheckBox.Size = new Size(131, 19);
            tireCheckBox.TabIndex = 2;
            tireCheckBox.Text = "Tire Rotation ($25)";
            toolTip1.SetToolTip(tireCheckBox, "Tire Rotation");
            tireCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            mufflerCheckBox.AutoSize = true;
            mufflerCheckBox.Location = new Point(44, 58);
            mufflerCheckBox.Name = "mufflerCheckBox";
            mufflerCheckBox.Size = new Size(153, 19);
            mufflerCheckBox.TabIndex = 1;
            mufflerCheckBox.Text = "Replace Muffler ($150)";
            toolTip1.SetToolTip(mufflerCheckBox, "Replace Muffler option");
            mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inpsectioncheckBox
            // 
            inpsectioncheckBox.AutoSize = true;
            inpsectioncheckBox.Location = new Point(44, 22);
            inpsectioncheckBox.Name = "inpsectioncheckBox";
            inpsectioncheckBox.Size = new Size(108, 19);
            inpsectioncheckBox.TabIndex = 0;
            inpsectioncheckBox.Text = "Inpection ($35)";
            toolTip1.SetToolTip(inpsectioncheckBox, "Inspection option\r\n");
            inpsectioncheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(laborTextBox);
            groupBox4.Controls.Add(partsTextBox);
            groupBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox4.Location = new Point(218, 156);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(211, 127);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parts and Labor";
            toolTip1.SetToolTip(groupBox4, "Choose a Job");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Labor (Hours): ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 40);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "Parts:";
            // 
            // laborTextBox
            // 
            laborTextBox.Location = new Point(105, 71);
            laborTextBox.Name = "laborTextBox";
            laborTextBox.Size = new Size(100, 22);
            laborTextBox.TabIndex = 1;
            toolTip1.SetToolTip(laborTextBox, "Enter hours for job");
            // 
            // partsTextBox
            // 
            partsTextBox.Location = new Point(105, 32);
            partsTextBox.Name = "partsTextBox";
            partsTextBox.Size = new Size(100, 22);
            partsTextBox.TabIndex = 0;
            toolTip1.SetToolTip(partsTextBox, "Enter parts price ");
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(totalFeeLabel);
            groupBox5.Controls.Add(taxLabel);
            groupBox5.Controls.Add(partsLabel);
            groupBox5.Controls.Add(serivceAndLaborLabel);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            groupBox5.Location = new Point(12, 289);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(417, 147);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Summary";
            toolTip1.SetToolTip(groupBox5, "Results");
            // 
            // totalFeeLabel
            // 
            totalFeeLabel.BorderStyle = BorderStyle.FixedSingle;
            totalFeeLabel.Location = new Point(240, 115);
            totalFeeLabel.Name = "totalFeeLabel";
            totalFeeLabel.Size = new Size(100, 23);
            totalFeeLabel.TabIndex = 7;
            toolTip1.SetToolTip(totalFeeLabel, "Total");
            // 
            // taxLabel
            // 
            taxLabel.BorderStyle = BorderStyle.FixedSingle;
            taxLabel.Location = new Point(240, 78);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(100, 23);
            taxLabel.TabIndex = 6;
            toolTip1.SetToolTip(taxLabel, "Part price with tax ");
            // 
            // partsLabel
            // 
            partsLabel.BorderStyle = BorderStyle.FixedSingle;
            partsLabel.Location = new Point(240, 47);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(100, 23);
            partsLabel.TabIndex = 5;
            toolTip1.SetToolTip(partsLabel, "Parts price ");
            // 
            // serivceAndLaborLabel
            // 
            serivceAndLaborLabel.BorderStyle = BorderStyle.FixedSingle;
            serivceAndLaborLabel.Location = new Point(240, 19);
            serivceAndLaborLabel.Name = "serivceAndLaborLabel";
            serivceAndLaborLabel.Size = new Size(100, 23);
            serivceAndLaborLabel.TabIndex = 4;
            toolTip1.SetToolTip(serivceAndLaborLabel, "Price of service and job ");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 123);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Total Fee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 86);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 2;
            label5.Text = "Tax (on parts):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 55);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Parts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 0;
            label3.Text = "Service and Labor: ";
            // 
            // calculateBtn
            // 
            calculateBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            calculateBtn.Location = new Point(77, 445);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(75, 23);
            calculateBtn.TabIndex = 4;
            calculateBtn.Text = "Ca&lculate";
            toolTip1.SetToolTip(calculateBtn, "Calculate prices ");
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            clearBtn.Location = new Point(189, 445);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "&Clear";
            toolTip1.SetToolTip(clearBtn, "Clear forms ");
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            exitBtn.Location = new Point(305, 445);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "&Exit";
            toolTip1.SetToolTip(exitBtn, "Exit form ");
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(140, 9);
            label11.Name = "label11";
            label11.Size = new Size(159, 24);
            label11.TabIndex = 8;
            label11.Text = "Joes Automotive";
            // 
            // Form1
            // 
            AcceptButton = calculateBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = exitBtn;
            ClientSize = new Size(440, 477);
            Controls.Add(label11);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(calculateBtn);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maslyanchuk-E-Lab-6-Chapter-6-CPT-185-A01";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox lubeCheckBox;
        private CheckBox oilCheckBox;
        private GroupBox groupBox2;
        private CheckBox transmissionCheckBox;
        private CheckBox radiatorCheckBox;
        private GroupBox groupBox3;
        private CheckBox tireCheckBox;
        private CheckBox mufflerCheckBox;
        private CheckBox inpsectioncheckBox;
        private GroupBox groupBox4;
        private Label label2;
        private Label label1;
        private TextBox laborTextBox;
        private TextBox partsTextBox;
        private GroupBox groupBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label totalFeeLabel;
        private Label taxLabel;
        private Label partsLabel;
        private Label serivceAndLaborLabel;
        private Label label6;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label11;
        private ToolTip toolTip1;
    }
}
