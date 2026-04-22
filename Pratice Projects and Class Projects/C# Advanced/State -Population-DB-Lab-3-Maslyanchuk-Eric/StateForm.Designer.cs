namespace Lab_3_Maslyanchuk_Eric
{
    partial class StateForm
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
            this.components = new System.ComponentModel.Container();
            this.statesDataGridView = new System.Windows.Forms.DataGridView();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stateDetailsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchStateBtn = new System.Windows.Forms.Button();
            this.stateLargestCitiesTextBox = new System.Windows.Forms.TextBox();
            this.searchStateLargestCitiesBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compJobsGreaterBtn = new System.Windows.Forms.Button();
            this.compJobsLessBtn = new System.Windows.Forms.Button();
            this.incomceGreaterThanBtn = new System.Windows.Forms.Button();
            this.incomeLessThanBtn = new System.Windows.Forms.Button();
            this.popGreaterThanBtn = new System.Windows.Forms.Button();
            this.popLessThanBtn = new System.Windows.Forms.Button();
            this.searchStateComputerJobBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stateComputerJobTextBox = new System.Windows.Forms.TextBox();
            this.searchStateMedianIncomeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stateMedainIncomeTextBox = new System.Windows.Forms.TextBox();
            this.searchStatePopulationBtn = new System.Windows.Forms.Button();
            this.statePopulationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statesDataGridView
            // 
            this.statesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.statesDataGridView.Name = "statesDataGridView";
            this.statesDataGridView.Size = new System.Drawing.Size(1260, 409);
            this.statesDataGridView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.statesDataGridView, "States Data here");
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(15, 468);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(153, 23);
            this.stateComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a State from dropdow box to view state details";
            // 
            // stateDetailsBtn
            // 
            this.stateDetailsBtn.Location = new System.Drawing.Point(174, 467);
            this.stateDetailsBtn.Name = "stateDetailsBtn";
            this.stateDetailsBtn.Size = new System.Drawing.Size(123, 23);
            this.stateDetailsBtn.TabIndex = 2;
            this.stateDetailsBtn.Text = "Show State Details";
            this.toolTip1.SetToolTip(this.stateDetailsBtn, "Shows the State Details");
            this.stateDetailsBtn.UseVisualStyleBackColor = true;
            this.stateDetailsBtn.Click += new System.EventHandler(this.stateDetailsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search for State, State Captial, State Bird, State Color, State Flower";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(7, 39);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(155, 22);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchStateBtn
            // 
            this.searchStateBtn.Location = new System.Drawing.Point(169, 37);
            this.searchStateBtn.Name = "searchStateBtn";
            this.searchStateBtn.Size = new System.Drawing.Size(122, 23);
            this.searchStateBtn.TabIndex = 6;
            this.searchStateBtn.Text = "Search State";
            this.toolTip1.SetToolTip(this.searchStateBtn, "Searchs state, captial, bird, color, flower");
            this.searchStateBtn.UseVisualStyleBackColor = true;
            this.searchStateBtn.Click += new System.EventHandler(this.searchStateBtn_Click);
            // 
            // stateLargestCitiesTextBox
            // 
            this.stateLargestCitiesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateLargestCitiesTextBox.Location = new System.Drawing.Point(6, 87);
            this.stateLargestCitiesTextBox.Name = "stateLargestCitiesTextBox";
            this.stateLargestCitiesTextBox.Size = new System.Drawing.Size(155, 22);
            this.stateLargestCitiesTextBox.TabIndex = 7;
            // 
            // searchStateLargestCitiesBtn
            // 
            this.searchStateLargestCitiesBtn.Location = new System.Drawing.Point(168, 87);
            this.searchStateLargestCitiesBtn.Name = "searchStateLargestCitiesBtn";
            this.searchStateLargestCitiesBtn.Size = new System.Drawing.Size(159, 23);
            this.searchStateLargestCitiesBtn.TabIndex = 8;
            this.searchStateLargestCitiesBtn.Text = "Search for Largest Cities";
            this.toolTip1.SetToolTip(this.searchStateLargestCitiesBtn, "Search Largest Cities");
            this.searchStateLargestCitiesBtn.UseVisualStyleBackColor = true;
            this.searchStateLargestCitiesBtn.Click += new System.EventHandler(this.searchStateLargestCitiesBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compJobsGreaterBtn);
            this.groupBox2.Controls.Add(this.compJobsLessBtn);
            this.groupBox2.Controls.Add(this.incomceGreaterThanBtn);
            this.groupBox2.Controls.Add(this.incomeLessThanBtn);
            this.groupBox2.Controls.Add(this.popGreaterThanBtn);
            this.groupBox2.Controls.Add(this.popLessThanBtn);
            this.groupBox2.Controls.Add(this.searchStateComputerJobBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stateComputerJobTextBox);
            this.groupBox2.Controls.Add(this.searchStateMedianIncomeBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.stateMedainIncomeTextBox);
            this.groupBox2.Controls.Add(this.searchStatePopulationBtn);
            this.groupBox2.Controls.Add(this.statePopulationTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchStateLargestCitiesBtn);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.stateLargestCitiesTextBox);
            this.groupBox2.Controls.Add(this.searchStateBtn);
            this.groupBox2.Location = new System.Drawing.Point(303, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 293);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search ";
            // 
            // compJobsGreaterBtn
            // 
            this.compJobsGreaterBtn.Location = new System.Drawing.Point(517, 251);
            this.compJobsGreaterBtn.Name = "compJobsGreaterBtn";
            this.compJobsGreaterBtn.Size = new System.Drawing.Size(235, 23);
            this.compJobsGreaterBtn.TabIndex = 24;
            this.compJobsGreaterBtn.Text = "Find Computer Job % Greater Than";
            this.toolTip1.SetToolTip(this.compJobsGreaterBtn, "Filter Greater Than Computer Job Percentage");
            this.compJobsGreaterBtn.UseVisualStyleBackColor = true;
            this.compJobsGreaterBtn.Click += new System.EventHandler(this.compJobsGreaterBtn_Click);
            // 
            // compJobsLessBtn
            // 
            this.compJobsLessBtn.Location = new System.Drawing.Point(343, 252);
            this.compJobsLessBtn.Name = "compJobsLessBtn";
            this.compJobsLessBtn.Size = new System.Drawing.Size(168, 23);
            this.compJobsLessBtn.TabIndex = 23;
            this.compJobsLessBtn.Text = "Find Computer Job % Less Than";
            this.toolTip1.SetToolTip(this.compJobsLessBtn, "Filter Less Than Computer Job %");
            this.compJobsLessBtn.UseVisualStyleBackColor = true;
            this.compJobsLessBtn.Click += new System.EventHandler(this.compJobsLessBtn_Click);
            // 
            // incomceGreaterThanBtn
            // 
            this.incomceGreaterThanBtn.Location = new System.Drawing.Point(543, 194);
            this.incomceGreaterThanBtn.Name = "incomceGreaterThanBtn";
            this.incomceGreaterThanBtn.Size = new System.Drawing.Size(209, 23);
            this.incomceGreaterThanBtn.TabIndex = 22;
            this.incomceGreaterThanBtn.Text = "Find Median Income Greater Than";
            this.toolTip1.SetToolTip(this.incomceGreaterThanBtn, "Filter Greater Than Median Income");
            this.incomceGreaterThanBtn.UseVisualStyleBackColor = true;
            this.incomceGreaterThanBtn.Click += new System.EventHandler(this.incomceGreaterThanBtn_Click);
            // 
            // incomeLessThanBtn
            // 
            this.incomeLessThanBtn.Location = new System.Drawing.Point(343, 194);
            this.incomeLessThanBtn.Name = "incomeLessThanBtn";
            this.incomeLessThanBtn.Size = new System.Drawing.Size(194, 23);
            this.incomeLessThanBtn.TabIndex = 21;
            this.incomeLessThanBtn.Text = "Find Median Income Less Than";
            this.toolTip1.SetToolTip(this.incomeLessThanBtn, "Filter Less Than Median Income\r\n");
            this.incomeLessThanBtn.UseVisualStyleBackColor = true;
            this.incomeLessThanBtn.Click += new System.EventHandler(this.incomeLessThanBtn_Click);
            // 
            // popGreaterThanBtn
            // 
            this.popGreaterThanBtn.Location = new System.Drawing.Point(517, 141);
            this.popGreaterThanBtn.Name = "popGreaterThanBtn";
            this.popGreaterThanBtn.Size = new System.Drawing.Size(180, 23);
            this.popGreaterThanBtn.TabIndex = 20;
            this.popGreaterThanBtn.Text = "Find Population Greater Than";
            this.toolTip1.SetToolTip(this.popGreaterThanBtn, "Filter Greater Than Population ");
            this.popGreaterThanBtn.UseVisualStyleBackColor = true;
            this.popGreaterThanBtn.Click += new System.EventHandler(this.popGreaterThanBtn_Click);
            // 
            // popLessThanBtn
            // 
            this.popLessThanBtn.Location = new System.Drawing.Point(343, 143);
            this.popLessThanBtn.Name = "popLessThanBtn";
            this.popLessThanBtn.Size = new System.Drawing.Size(168, 23);
            this.popLessThanBtn.TabIndex = 19;
            this.popLessThanBtn.Text = "Find Population Less Than";
            this.toolTip1.SetToolTip(this.popLessThanBtn, "Filter Less Than Population");
            this.popLessThanBtn.UseVisualStyleBackColor = true;
            this.popLessThanBtn.Click += new System.EventHandler(this.popLessThanBtn_Click);
            // 
            // searchStateComputerJobBtn
            // 
            this.searchStateComputerJobBtn.Location = new System.Drawing.Point(170, 251);
            this.searchStateComputerJobBtn.Name = "searchStateComputerJobBtn";
            this.searchStateComputerJobBtn.Size = new System.Drawing.Size(168, 23);
            this.searchStateComputerJobBtn.TabIndex = 18;
            this.searchStateComputerJobBtn.Text = "Search Computer Job %";
            this.toolTip1.SetToolTip(this.searchStateComputerJobBtn, "Search Computer Job %");
            this.searchStateComputerJobBtn.UseVisualStyleBackColor = true;
            this.searchStateComputerJobBtn.Click += new System.EventHandler(this.searchStateComputerJobBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Search Computer Job Percentage";
            // 
            // stateComputerJobTextBox
            // 
            this.stateComputerJobTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateComputerJobTextBox.Location = new System.Drawing.Point(7, 253);
            this.stateComputerJobTextBox.Name = "stateComputerJobTextBox";
            this.stateComputerJobTextBox.Size = new System.Drawing.Size(152, 22);
            this.stateComputerJobTextBox.TabIndex = 16;
            // 
            // searchStateMedianIncomeBtn
            // 
            this.searchStateMedianIncomeBtn.Location = new System.Drawing.Point(169, 194);
            this.searchStateMedianIncomeBtn.Name = "searchStateMedianIncomeBtn";
            this.searchStateMedianIncomeBtn.Size = new System.Drawing.Size(168, 23);
            this.searchStateMedianIncomeBtn.TabIndex = 15;
            this.searchStateMedianIncomeBtn.Text = "Search Median Income";
            this.toolTip1.SetToolTip(this.searchStateMedianIncomeBtn, "Search Median Income");
            this.searchStateMedianIncomeBtn.UseVisualStyleBackColor = true;
            this.searchStateMedianIncomeBtn.Click += new System.EventHandler(this.searchStateMedianIncomeBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Search Median Income";
            // 
            // stateMedainIncomeTextBox
            // 
            this.stateMedainIncomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateMedainIncomeTextBox.Location = new System.Drawing.Point(6, 196);
            this.stateMedainIncomeTextBox.Name = "stateMedainIncomeTextBox";
            this.stateMedainIncomeTextBox.Size = new System.Drawing.Size(152, 22);
            this.stateMedainIncomeTextBox.TabIndex = 13;
            // 
            // searchStatePopulationBtn
            // 
            this.searchStatePopulationBtn.Location = new System.Drawing.Point(169, 141);
            this.searchStatePopulationBtn.Name = "searchStatePopulationBtn";
            this.searchStatePopulationBtn.Size = new System.Drawing.Size(168, 23);
            this.searchStatePopulationBtn.TabIndex = 12;
            this.searchStatePopulationBtn.Text = "Search Population";
            this.toolTip1.SetToolTip(this.searchStatePopulationBtn, "Search Population");
            this.searchStatePopulationBtn.UseVisualStyleBackColor = true;
            this.searchStatePopulationBtn.Click += new System.EventHandler(this.searchStatePopulationBtn_Click);
            // 
            // statePopulationTextBox
            // 
            this.statePopulationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePopulationTextBox.Location = new System.Drawing.Point(6, 143);
            this.statePopulationTextBox.Name = "statePopulationTextBox";
            this.statePopulationTextBox.Size = new System.Drawing.Size(152, 22);
            this.statePopulationTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search for a Large City";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1197, 758);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearBtn, "Clears the form");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1197, 790);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitBtn, "Exit the form");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Database";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(159, 83);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(95, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update Data";
            this.toolTip1.SetToolTip(this.updateBtn, "Updates the data");
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Updating the data please look for the State and update the column that needs to b" +
    "e updated then hit update button\r\n";
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stateDetailsBtn);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statesDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatesForm";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statesDataGridView;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stateDetailsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchStateBtn;
        private System.Windows.Forms.TextBox stateLargestCitiesTextBox;
        private System.Windows.Forms.Button searchStateLargestCitiesBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statePopulationTextBox;
        private System.Windows.Forms.Button searchStatePopulationBtn;
        private System.Windows.Forms.Button searchStateComputerJobBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stateComputerJobTextBox;
        private System.Windows.Forms.Button searchStateMedianIncomeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stateMedainIncomeTextBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button popGreaterThanBtn;
        private System.Windows.Forms.Button popLessThanBtn;
        private System.Windows.Forms.Button incomceGreaterThanBtn;
        private System.Windows.Forms.Button incomeLessThanBtn;
        private System.Windows.Forms.Button compJobsGreaterBtn;
        private System.Windows.Forms.Button compJobsLessBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}