namespace WorldWideSports
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.favoriteNFLTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteNFLTeamsTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1575, 815);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.createAccountBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.passwordTxtBox);
            this.panel2.Controls.Add(this.usernameTxtBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(503, 349);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 413);
            this.panel2.TabIndex = 2;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.Black;
            this.createAccountBtn.Location = new System.Drawing.Point(180, 340);
            this.createAccountBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(208, 52);
            this.createAccountBtn.TabIndex = 8;
            this.createAccountBtn.Text = "&Create Account";
            this.toolTip1.SetToolTip(this.createAccountBtn, "Opens form to create account");
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(156, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Don\'t have an account?";
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(357, 202);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(147, 52);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitBtn, "Exit World Wide Sports");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(69, 202);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(147, 52);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "&Login";
            this.toolTip1.SetToolTip(this.loginBtn, "Login to your account");
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxtBox.Location = new System.Drawing.Point(226, 135);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(276, 26);
            this.passwordTxtBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.passwordTxtBox, "Enter Password");
            this.passwordTxtBox.UseSystemPasswordChar = true;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxtBox.Location = new System.Drawing.Point(226, 79);
            this.usernameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(276, 26);
            this.usernameTxtBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.usernameTxtBox, "Enter Username");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(63, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(939, 112);
            this.label2.TabIndex = 1;
            this.label2.Text = "World Wide Sports";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // favoriteNFLTeamsBindingSource
            // 
            this.favoriteNFLTeamsBindingSource.DataMember = "FavoriteNFLTeams";
            this.favoriteNFLTeamsBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // favoriteNFLTeamsTableAdapter
            // 
            this.favoriteNFLTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoriteNFLTeamsTableAdapter = this.favoriteNFLTeamsTableAdapter;
            this.tableAdapterManager.FavoritePGAPlayers_NewTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayersTableAdapter = null;
            this.tableAdapterManager.NFL_GamesTableAdapter = null;
            this.tableAdapterManager.NFL_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_ALL_TOURNAMENTSTableAdapter = null;
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_PlayersTableAdapter = null;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1575, 815);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource favoriteNFLTeamsBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter favoriteNFLTeamsTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}

