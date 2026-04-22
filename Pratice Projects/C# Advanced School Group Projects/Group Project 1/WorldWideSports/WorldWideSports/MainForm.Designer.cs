namespace WorldWideSports
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnViewNfl = new System.Windows.Forms.Button();
            this.btnViewPga = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnLoginCreate = new System.Windows.Forms.Button();
            this.lblNavBar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.favoriteNFLTeamsTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter();
            this.favoritePGAPlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter();
            this.pgA_PlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter();
            this.nfL_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter();
            this.mainFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPgaAndNflUpcoming = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxPga = new System.Windows.Forms.GroupBox();
            this.cbxPga = new System.Windows.Forms.ComboBox();
            this.btnSavePga = new System.Windows.Forms.Button();
            this.gbxNfl = new System.Windows.Forms.GroupBox();
            this.cbxNflTeams = new System.Windows.Forms.ComboBox();
            this.btnSaveFavTeam = new System.Windows.Forms.Button();
            this.gbxHolder1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxPga.SuspendLayout();
            this.gbxNfl.SuspendLayout();
            this.gbxHolder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewNfl
            // 
            this.btnViewNfl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewNfl.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNfl.Location = new System.Drawing.Point(450, 65);
            this.btnViewNfl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewNfl.Name = "btnViewNfl";
            this.btnViewNfl.Size = new System.Drawing.Size(202, 55);
            this.btnViewNfl.TabIndex = 11;
            this.btnViewNfl.Text = "View NFL Details";
            this.mainFormToolTip.SetToolTip(this.btnViewNfl, "Click to View Nfl Details");
            this.btnViewNfl.UseVisualStyleBackColor = false;
            this.btnViewNfl.Visible = false;
            this.btnViewNfl.Click += new System.EventHandler(this.btnViewNfl_Click);
            // 
            // btnViewPga
            // 
            this.btnViewPga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPga.Location = new System.Drawing.Point(696, 65);
            this.btnViewPga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewPga.Name = "btnViewPga";
            this.btnViewPga.Size = new System.Drawing.Size(210, 55);
            this.btnViewPga.TabIndex = 12;
            this.btnViewPga.Text = "View PGA Details";
            this.mainFormToolTip.SetToolTip(this.btnViewPga, "Click to View PGA Details");
            this.btnViewPga.UseVisualStyleBackColor = true;
            this.btnViewPga.Visible = false;
            this.btnViewPga.Click += new System.EventHandler(this.btnViewPga_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccount.Location = new System.Drawing.Point(1369, 18);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(230, 29);
            this.lblAccount.TabIndex = 16;
            this.lblAccount.Text = "Account: ";
            this.lblAccount.Visible = false;
            // 
            // btnLoginCreate
            // 
            this.btnLoginCreate.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCreate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoginCreate.Location = new System.Drawing.Point(1374, 69);
            this.btnLoginCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginCreate.Name = "btnLoginCreate";
            this.btnLoginCreate.Size = new System.Drawing.Size(260, 49);
            this.btnLoginCreate.TabIndex = 14;
            this.btnLoginCreate.Text = "Log In/Create Account";
            this.mainFormToolTip.SetToolTip(this.btnLoginCreate, "Click to Login or Create Account");
            this.btnLoginCreate.UseVisualStyleBackColor = true;
            this.btnLoginCreate.Click += new System.EventHandler(this.btnLoginCreate_Click);
            // 
            // lblNavBar
            // 
            this.lblNavBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNavBar.Location = new System.Drawing.Point(-6, 58);
            this.lblNavBar.Name = "lblNavBar";
            this.lblNavBar.Size = new System.Drawing.Size(1667, 69);
            this.lblNavBar.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(772, 892);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.mainFormToolTip.SetToolTip(this.btnExit, "Click to Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // favoriteNFLTeamsTableAdapter
            // 
            this.favoriteNFLTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // favoritePGAPlayersTableAdapter
            // 
            this.favoritePGAPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // pgA_PlayersTableAdapter
            // 
            this.pgA_PlayersTableAdapter.ClearBeforeFill = true;
            // 
            // nfL_PLAYER_STATSTableAdapter
            // 
            this.nfL_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // btnPgaAndNflUpcoming
            // 
            this.btnPgaAndNflUpcoming.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPgaAndNflUpcoming.Location = new System.Drawing.Point(950, 66);
            this.btnPgaAndNflUpcoming.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPgaAndNflUpcoming.Name = "btnPgaAndNflUpcoming";
            this.btnPgaAndNflUpcoming.Size = new System.Drawing.Size(204, 54);
            this.btnPgaAndNflUpcoming.TabIndex = 13;
            this.btnPgaAndNflUpcoming.Text = "Upcoming Fixtures";
            this.mainFormToolTip.SetToolTip(this.btnPgaAndNflUpcoming, "Click to View Upcoming Fixtures");
            this.btnPgaAndNflUpcoming.UseVisualStyleBackColor = true;
            this.btnPgaAndNflUpcoming.Visible = false;
            this.btnPgaAndNflUpcoming.Click += new System.EventHandler(this.btnPgaAndNflUpcoming_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1657, 756);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // gbxPga
            // 
            this.gbxPga.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxPga.Controls.Add(this.btnSavePga);
            this.gbxPga.Controls.Add(this.cbxPga);
            this.gbxPga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxPga.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPga.Location = new System.Drawing.Point(531, 249);
            this.gbxPga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPga.Name = "gbxPga";
            this.gbxPga.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPga.Size = new System.Drawing.Size(278, 258);
            this.gbxPga.TabIndex = 5;
            this.gbxPga.TabStop = false;
            this.gbxPga.Text = "Choose your Favorite PGA Player:";
            this.gbxPga.Visible = false;
            // 
            // cbxPga
            // 
            this.cbxPga.FormattingEnabled = true;
            this.cbxPga.Location = new System.Drawing.Point(18, 98);
            this.cbxPga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPga.Name = "cbxPga";
            this.cbxPga.Size = new System.Drawing.Size(253, 31);
            this.cbxPga.TabIndex = 0;
            this.mainFormToolTip.SetToolTip(this.cbxPga, "Select Your Favorite Player");
            // 
            // btnSavePga
            // 
            this.btnSavePga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSavePga.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePga.Location = new System.Drawing.Point(36, 171);
            this.btnSavePga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSavePga.Name = "btnSavePga";
            this.btnSavePga.Size = new System.Drawing.Size(212, 46);
            this.btnSavePga.TabIndex = 3;
            this.btnSavePga.Text = "&Save Favorite Player";
            this.mainFormToolTip.SetToolTip(this.btnSavePga, "Click to Save Your Favorite Player");
            this.btnSavePga.UseVisualStyleBackColor = true;
            this.btnSavePga.Click += new System.EventHandler(this.btnSavePga_Click);
            // 
            // gbxNfl
            // 
            this.gbxNfl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNfl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxNfl.Controls.Add(this.btnSaveFavTeam);
            this.gbxNfl.Controls.Add(this.cbxNflTeams);
            this.gbxNfl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxNfl.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNfl.Location = new System.Drawing.Point(854, 249);
            this.gbxNfl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxNfl.Name = "gbxNfl";
            this.gbxNfl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxNfl.Size = new System.Drawing.Size(278, 258);
            this.gbxNfl.TabIndex = 4;
            this.gbxNfl.TabStop = false;
            this.gbxNfl.Text = "Choose your Favorite NFL Team:";
            this.gbxNfl.Visible = false;
            // 
            // cbxNflTeams
            // 
            this.cbxNflTeams.FormattingEnabled = true;
            this.cbxNflTeams.Location = new System.Drawing.Point(18, 99);
            this.cbxNflTeams.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNflTeams.Name = "cbxNflTeams";
            this.cbxNflTeams.Size = new System.Drawing.Size(253, 31);
            this.cbxNflTeams.TabIndex = 0;
            this.mainFormToolTip.SetToolTip(this.cbxNflTeams, "Select Your Favorite Team");
            // 
            // btnSaveFavTeam
            // 
            this.btnSaveFavTeam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveFavTeam.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFavTeam.Location = new System.Drawing.Point(29, 170);
            this.btnSaveFavTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveFavTeam.Name = "btnSaveFavTeam";
            this.btnSaveFavTeam.Size = new System.Drawing.Size(233, 46);
            this.btnSaveFavTeam.TabIndex = 1;
            this.btnSaveFavTeam.Text = "&Save Favorite Team";
            this.mainFormToolTip.SetToolTip(this.btnSaveFavTeam, "Click to Save Your Favorite Team");
            this.btnSaveFavTeam.UseVisualStyleBackColor = true;
            this.btnSaveFavTeam.Click += new System.EventHandler(this.btnSaveFavTeam_Click);
            // 
            // gbxHolder1
            // 
            this.gbxHolder1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxHolder1.Controls.Add(this.gbxNfl);
            this.gbxHolder1.Controls.Add(this.gbxPga);
            this.gbxHolder1.Controls.Add(this.pictureBox2);
            this.gbxHolder1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxHolder1.Location = new System.Drawing.Point(-2, 128);
            this.gbxHolder1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxHolder1.Name = "gbxHolder1";
            this.gbxHolder1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxHolder1.Size = new System.Drawing.Size(1663, 756);
            this.gbxHolder1.TabIndex = 10;
            this.gbxHolder1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1662, 939);
            this.Controls.Add(this.btnViewNfl);
            this.Controls.Add(this.btnPgaAndNflUpcoming);
            this.Controls.Add(this.btnViewPga);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnLoginCreate);
            this.Controls.Add(this.lblNavBar);
            this.Controls.Add(this.gbxHolder1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Wide Sports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxPga.ResumeLayout(false);
            this.gbxNfl.ResumeLayout(false);
            this.gbxHolder1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewNfl;
        private System.Windows.Forms.Button btnViewPga;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnLoginCreate;
        private System.Windows.Forms.Label lblNavBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter favoriteNFLTeamsTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter favoritePGAPlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter pgA_PlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter nfL_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.ToolTip mainFormToolTip;
        private System.Windows.Forms.Button btnPgaAndNflUpcoming;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbxPga;
        private System.Windows.Forms.Button btnSavePga;
        private System.Windows.Forms.ComboBox cbxPga;
        private System.Windows.Forms.GroupBox gbxNfl;
        private System.Windows.Forms.Button btnSaveFavTeam;
        private System.Windows.Forms.ComboBox cbxNflTeams;
        private System.Windows.Forms.GroupBox gbxHolder1;
    }
}