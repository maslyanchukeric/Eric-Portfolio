namespace Lab_3_Maslyanchuk_Eric
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.importDataBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "To enter into United States Database to click Import Data";
            // 
            // importDataBtn
            // 
            this.importDataBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importDataBtn.Location = new System.Drawing.Point(189, 64);
            this.importDataBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importDataBtn.Name = "importDataBtn";
            this.importDataBtn.Size = new System.Drawing.Size(88, 27);
            this.importDataBtn.TabIndex = 2;
            this.importDataBtn.Text = "Import Data";
            this.toolTip1.SetToolTip(this.importDataBtn, "Imports text file data to database");
            this.importDataBtn.UseVisualStyleBackColor = true;
            this.importDataBtn.Click += new System.EventHandler(this.importDataBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(189, 107);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 27);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitBtn, "Exit the application");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 162);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.importDataBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to United States Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importDataBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

