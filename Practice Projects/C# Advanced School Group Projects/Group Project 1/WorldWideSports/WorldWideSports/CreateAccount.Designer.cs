namespace WorldWideSports
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.confirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 546);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.createAccountBtn);
            this.panel2.Controls.Add(this.confirmPasswordTxtBox);
            this.panel2.Controls.Add(this.passwordTxtBox);
            this.panel2.Controls.Add(this.usernameTxtBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(197, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 292);
            this.panel2.TabIndex = 0;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold);
            this.createAccountBtn.Location = new System.Drawing.Point(197, 243);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(136, 34);
            this.createAccountBtn.TabIndex = 7;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // confirmPasswordTxtBox
            // 
            this.confirmPasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTxtBox.Location = new System.Drawing.Point(236, 194);
            this.confirmPasswordTxtBox.Name = "confirmPasswordTxtBox";
            this.confirmPasswordTxtBox.Size = new System.Drawing.Size(205, 20);
            this.confirmPasswordTxtBox.TabIndex = 6;
            this.confirmPasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxtBox.Location = new System.Drawing.Point(236, 136);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(205, 20);
            this.passwordTxtBox.TabIndex = 5;
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxtBox.Location = new System.Drawing.Point(236, 83);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(205, 20);
            this.usernameTxtBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(85, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confrim Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(101, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoriteNFLTeamsTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayers_NewTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayersTableAdapter = null;
            this.tableAdapterManager.NFL_GamesTableAdapter = null;
            this.tableAdapterManager.NFL_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_ALL_TOURNAMENTSTableAdapter = null;
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_PlayersTableAdapter = null;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 546);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPasswordTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button createAccountBtn;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}