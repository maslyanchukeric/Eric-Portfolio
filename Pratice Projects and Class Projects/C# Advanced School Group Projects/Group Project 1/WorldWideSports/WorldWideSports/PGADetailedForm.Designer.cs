namespace WorldWideSports
{
    partial class PGADetailedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PGADetailedForm));
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.rchTxtBoxStats = new System.Windows.Forms.RichTextBox();
            this.rchTxtBoxTournament = new System.Windows.Forms.RichTextBox();
            this.cmbBoxPlayers = new System.Windows.Forms.ComboBox();
            this.lblPGATitle = new System.Windows.Forms.Label();
            this.pGA_ALL_TOURNAMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.pGA_PLAYER_STATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pGA_PlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pGA_PlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.pGA_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_PLAYER_STATSTableAdapter();
            this.pGA_ALL_TOURNAMENTSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter();
            this.rchBoxFavPlayer = new System.Windows.Forms.RichTextBox();
            this.favoritePGAPlayersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoritePGAPlayersTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.grpBoxTournaments = new System.Windows.Forms.GroupBox();
            this.grpBoxFavPlayer = new System.Windows.Forms.GroupBox();
            this.toolTipPGADetails = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_ALL_TOURNAMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PLAYER_STATSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PlayersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePGAPlayersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.grpBoxTournaments.SuspendLayout();
            this.grpBoxFavPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxStats.Controls.Add(this.rchTxtBoxStats);
            this.grpBoxStats.Location = new System.Drawing.Point(14, 88);
            this.grpBoxStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxStats.Name = "grpBoxStats";
            this.grpBoxStats.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxStats.Size = new System.Drawing.Size(514, 412);
            this.grpBoxStats.TabIndex = 0;
            this.grpBoxStats.TabStop = false;
            this.grpBoxStats.Text = "Player Stats";
            // 
            // rchTxtBoxStats
            // 
            this.rchTxtBoxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBoxStats.Location = new System.Drawing.Point(7, 26);
            this.rchTxtBoxStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchTxtBoxStats.Name = "rchTxtBoxStats";
            this.rchTxtBoxStats.ReadOnly = true;
            this.rchTxtBoxStats.Size = new System.Drawing.Size(493, 378);
            this.rchTxtBoxStats.TabIndex = 0;
            this.rchTxtBoxStats.Text = "";
            // 
            // rchTxtBoxTournament
            // 
            this.rchTxtBoxTournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBoxTournament.Location = new System.Drawing.Point(7, 26);
            this.rchTxtBoxTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchTxtBoxTournament.Name = "rchTxtBoxTournament";
            this.rchTxtBoxTournament.ReadOnly = true;
            this.rchTxtBoxTournament.Size = new System.Drawing.Size(533, 773);
            this.rchTxtBoxTournament.TabIndex = 2;
            this.rchTxtBoxTournament.Text = "";
            // 
            // cmbBoxPlayers
            // 
            this.cmbBoxPlayers.FormattingEnabled = true;
            this.cmbBoxPlayers.Items.AddRange(new object[] {
            "SelectPlayer"});
            this.cmbBoxPlayers.Location = new System.Drawing.Point(660, 18);
            this.cmbBoxPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxPlayers.Name = "cmbBoxPlayers";
            this.cmbBoxPlayers.Size = new System.Drawing.Size(198, 28);
            this.cmbBoxPlayers.TabIndex = 1;
            this.toolTipPGADetails.SetToolTip(this.cmbBoxPlayers, "Select PGA Player");
            this.cmbBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPlayers_SelectedIndexChanged);
            // 
            // lblPGATitle
            // 
            this.lblPGATitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPGATitle.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGATitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPGATitle.Location = new System.Drawing.Point(345, 8);
            this.lblPGATitle.Name = "lblPGATitle";
            this.lblPGATitle.Size = new System.Drawing.Size(207, 49);
            this.lblPGATitle.TabIndex = 4;
            this.lblPGATitle.Text = "PGA Details";
            // 
            // pGA_ALL_TOURNAMENTSBindingSource
            // 
            this.pGA_ALL_TOURNAMENTSBindingSource.DataMember = "PGA_ALL_TOURNAMENTS";
            this.pGA_ALL_TOURNAMENTSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGA_PLAYER_STATSBindingSource
            // 
            this.pGA_PLAYER_STATSBindingSource.DataMember = "PGA_PLAYER_STATS";
            this.pGA_PLAYER_STATSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // pGA_PlayersBindingSource
            // 
            this.pGA_PlayersBindingSource.DataMember = "PGA_Players";
            this.pGA_PlayersBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // pGA_PlayersTableAdapter
            // 
            this.pGA_PlayersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = this.pGA_PLAYER_STATSTableAdapter;
            this.tableAdapterManager.PGA_PlayersTableAdapter = this.pGA_PlayersTableAdapter;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // pGA_PLAYER_STATSTableAdapter
            // 
            this.pGA_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // pGA_ALL_TOURNAMENTSTableAdapter
            // 
            this.pGA_ALL_TOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // rchBoxFavPlayer
            // 
            this.rchBoxFavPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rchBoxFavPlayer.Location = new System.Drawing.Point(8, 26);
            this.rchBoxFavPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchBoxFavPlayer.Name = "rchBoxFavPlayer";
            this.rchBoxFavPlayer.ReadOnly = true;
            this.rchBoxFavPlayer.Size = new System.Drawing.Size(492, 353);
            this.rchBoxFavPlayer.TabIndex = 5;
            this.rchBoxFavPlayer.Text = "";
            // 
            // favoritePGAPlayersBindingSource
            // 
            this.favoritePGAPlayersBindingSource.DataMember = "FavoritePGAPlayers";
            this.favoritePGAPlayersBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // favoritePGAPlayersTableAdapter
            // 
            this.favoritePGAPlayersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.picBoxLogo);
            this.panel1.Controls.Add(this.lblPGATitle);
            this.panel1.Controls.Add(this.cmbBoxPlayers);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 65);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(936, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "< &Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(181, 59);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 8;
            this.picBoxLogo.TabStop = false;
            // 
            // grpBoxTournaments
            // 
            this.grpBoxTournaments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxTournaments.Controls.Add(this.rchTxtBoxTournament);
            this.grpBoxTournaments.Location = new System.Drawing.Point(534, 88);
            this.grpBoxTournaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxTournaments.Name = "grpBoxTournaments";
            this.grpBoxTournaments.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxTournaments.Size = new System.Drawing.Size(547, 808);
            this.grpBoxTournaments.TabIndex = 6;
            this.grpBoxTournaments.TabStop = false;
            this.grpBoxTournaments.Text = "TournamentsStats";
            // 
            // grpBoxFavPlayer
            // 
            this.grpBoxFavPlayer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxFavPlayer.Controls.Add(this.rchBoxFavPlayer);
            this.grpBoxFavPlayer.Location = new System.Drawing.Point(14, 508);
            this.grpBoxFavPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxFavPlayer.Name = "grpBoxFavPlayer";
            this.grpBoxFavPlayer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxFavPlayer.Size = new System.Drawing.Size(514, 388);
            this.grpBoxFavPlayer.TabIndex = 7;
            this.grpBoxFavPlayer.TabStop = false;
            this.grpBoxFavPlayer.Text = "Favorite Player Stats";
            // 
            // PGADetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1088, 906);
            this.Controls.Add(this.grpBoxFavPlayer);
            this.Controls.Add(this.grpBoxTournaments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBoxStats);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PGADetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGA Details";
            this.Load += new System.EventHandler(this.PGADetailedForm_Load);
            this.grpBoxStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pGA_ALL_TOURNAMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PLAYER_STATSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGA_PlayersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritePGAPlayersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.grpBoxTournaments.ResumeLayout(false);
            this.grpBoxFavPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStats;
        private System.Windows.Forms.ComboBox cmbBoxPlayers;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource pGA_PlayersBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PlayersTableAdapter pGA_PlayersTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WorldWideSportsDBDataSetTableAdapters.PGA_PLAYER_STATSTableAdapter pGA_PLAYER_STATSTableAdapter;
        private System.Windows.Forms.BindingSource pGA_PLAYER_STATSBindingSource;
        private System.Windows.Forms.RichTextBox rchTxtBoxStats;
        private System.Windows.Forms.Label lblPGATitle;
        private System.Windows.Forms.BindingSource pGA_ALL_TOURNAMENTSBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter pGA_ALL_TOURNAMENTSTableAdapter;
        private System.Windows.Forms.RichTextBox rchTxtBoxTournament;
        private System.Windows.Forms.RichTextBox rchBoxFavPlayer;
        private System.Windows.Forms.BindingSource favoritePGAPlayersBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.FavoritePGAPlayersTableAdapter favoritePGAPlayersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxTournaments;
        private System.Windows.Forms.GroupBox grpBoxFavPlayer;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ToolTip toolTipPGADetails;
        private System.Windows.Forms.Button btnExit;
    }
}