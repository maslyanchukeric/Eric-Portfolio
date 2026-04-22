namespace WorldWideSports
{
    partial class NFLDetailedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFLDetailedForm));
            this.cmbBoxTeams = new System.Windows.Forms.ComboBox();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.nFL_GamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_GamesTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter();
            this.tableAdapterManager = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager();
            this.nFL_PLAYER_STATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFL_PLAYER_STATSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter();
            this.worldWideSportsPlayersPlusDataSet = new WorldWideSports.WorldWideSportsPlayersPlusDataSet();
            this.playerStats2023BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerStats2023TableAdapter = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2023TableAdapter();
            this.tableAdapterManager1 = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager();
            this.playerStats2024TableAdapter = new WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2024TableAdapter();
            this.playerStats2024BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteNFLTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteNFLTeamsTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBoxTeamText = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTipNFLDetails = new System.Windows.Forms.ToolTip(this.components);
            this.cmbViewSelector = new System.Windows.Forms.ComboBox();
            this.rchTxtBoxMain = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDivRank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblConfRank = new System.Windows.Forms.Label();
            this.lblLeageRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_GamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_PLAYER_STATSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsPlayersPlusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2023BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2024BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTeamText)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxTeams
            // 
            this.cmbBoxTeams.FormattingEnabled = true;
            this.cmbBoxTeams.Location = new System.Drawing.Point(1107, 91);
            this.cmbBoxTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxTeams.Name = "cmbBoxTeams";
            this.cmbBoxTeams.Size = new System.Drawing.Size(242, 28);
            this.cmbBoxTeams.TabIndex = 3;
            this.toolTipNFLDetails.SetToolTip(this.cmbBoxTeams, "Select NFL Team");
            this.cmbBoxTeams.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTeams_SelectedIndexChanged);
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nFL_GamesBindingSource
            // 
            this.nFL_GamesBindingSource.DataMember = "NFL_Games";
            this.nFL_GamesBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // nFL_GamesTableAdapter
            // 
            this.nFL_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoriteNFLTeamsTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayers_NewTableAdapter = null;
            this.tableAdapterManager.FavoritePGAPlayersTableAdapter = null;
            this.tableAdapterManager.NFL_GamesTableAdapter = this.nFL_GamesTableAdapter;
            this.tableAdapterManager.NFL_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_ALL_TOURNAMENTSTableAdapter = null;
            this.tableAdapterManager.PGA_PLAYER_STATSTableAdapter = null;
            this.tableAdapterManager.PGA_PlayersTableAdapter = null;
            this.tableAdapterManager.PGA_TOURNAMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WorldWideSports.WorldWideSportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nFL_PLAYER_STATSBindingSource
            // 
            this.nFL_PLAYER_STATSBindingSource.DataMember = "NFL_PLAYER_STATS";
            this.nFL_PLAYER_STATSBindingSource.DataSource = this.worldWideSportsDBDataSet;
            // 
            // nFL_PLAYER_STATSTableAdapter
            // 
            this.nFL_PLAYER_STATSTableAdapter.ClearBeforeFill = true;
            // 
            // worldWideSportsPlayersPlusDataSet
            // 
            this.worldWideSportsPlayersPlusDataSet.DataSetName = "WorldWideSportsPlayersPlusDataSet";
            this.worldWideSportsPlayersPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerStats2023BindingSource
            // 
            this.playerStats2023BindingSource.DataMember = "PlayerStats2023";
            this.playerStats2023BindingSource.DataSource = this.worldWideSportsPlayersPlusDataSet;
            // 
            // playerStats2023TableAdapter
            // 
            this.playerStats2023TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PlayerStats2023TableAdapter = this.playerStats2023TableAdapter;
            this.tableAdapterManager1.PlayerStats2024TableAdapter = this.playerStats2024TableAdapter;
            this.tableAdapterManager1.UpdateOrder = WorldWideSports.WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerStats2024TableAdapter
            // 
            this.playerStats2024TableAdapter.ClearBeforeFill = true;
            // 
            // playerStats2024BindingSource
            // 
            this.playerStats2024BindingSource.DataMember = "PlayerStats2024";
            this.playerStats2024BindingSource.DataSource = this.worldWideSportsPlayersPlusDataSet;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.LightCyan;
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.btnExit);
            this.pnlBackground.Controls.Add(this.pictureBox1);
            this.pnlBackground.Controls.Add(this.cmbBoxTeams);
            this.pnlBackground.Location = new System.Drawing.Point(12, 11);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1352, 147);
            this.pnlBackground.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pBoxTeamText);
            this.panel2.Location = new System.Drawing.Point(391, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 141);
            this.panel2.TabIndex = 11;
            // 
            // pBoxTeamText
            // 
            this.pBoxTeamText.Image = global::WorldWideSports.Properties.Resources.ArizonaText;
            this.pBoxTeamText.Location = new System.Drawing.Point(0, 0);
            this.pBoxTeamText.Name = "pBoxTeamText";
            this.pBoxTeamText.Size = new System.Drawing.Size(710, 141);
            this.pBoxTeamText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxTeamText.TabIndex = 0;
            this.pBoxTeamText.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pBoxTeamLogo);
            this.panel1.Location = new System.Drawing.Point(225, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 141);
            this.panel1.TabIndex = 10;
            // 
            // pBoxTeamLogo
            // 
            this.pBoxTeamLogo.Image = global::WorldWideSports.Properties.Resources.WashingtonText;
            this.pBoxTeamLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxTeamLogo.Name = "pBoxTeamLogo";
            this.pBoxTeamLogo.Size = new System.Drawing.Size(160, 141);
            this.pBoxTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxTeamLogo.TabIndex = 0;
            this.pBoxTeamLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1224, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "< &Back";
            this.toolTipNFLDetails.SetToolTip(this.btnExit, "Exit Detailed View");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbViewSelector
            // 
            this.cmbViewSelector.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewSelector.FormattingEnabled = true;
            this.cmbViewSelector.Location = new System.Drawing.Point(12, 347);
            this.cmbViewSelector.Name = "cmbViewSelector";
            this.cmbViewSelector.Size = new System.Drawing.Size(299, 31);
            this.cmbViewSelector.TabIndex = 10;
            this.cmbViewSelector.SelectedIndexChanged += new System.EventHandler(this.cmbViewSelector_SelectedIndexChanged);
            // 
            // rchTxtBoxMain
            // 
            this.rchTxtBoxMain.Location = new System.Drawing.Point(12, 384);
            this.rchTxtBoxMain.Name = "rchTxtBoxMain";
            this.rchTxtBoxMain.Size = new System.Drawing.Size(1352, 323);
            this.rchTxtBoxMain.TabIndex = 11;
            this.rchTxtBoxMain.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Record";
            // 
            // lblRecord
            // 
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(85, 241);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(87, 25);
            this.lblRecord.TabIndex = 12;
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Division Ranking";
            // 
            // lblDivRank
            // 
            this.lblDivRank.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivRank.Location = new System.Drawing.Point(322, 241);
            this.lblDivRank.Name = "lblDivRank";
            this.lblDivRank.Size = new System.Drawing.Size(186, 25);
            this.lblDivRank.TabIndex = 12;
            this.lblDivRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Conference Ranking";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1027, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "League Ranking";
            // 
            // lblConfRank
            // 
            this.lblConfRank.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfRank.Location = new System.Drawing.Point(658, 241);
            this.lblConfRank.Name = "lblConfRank";
            this.lblConfRank.Size = new System.Drawing.Size(224, 25);
            this.lblConfRank.TabIndex = 12;
            this.lblConfRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeageRank
            // 
            this.lblLeageRank.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeageRank.Location = new System.Drawing.Point(1032, 241);
            this.lblLeageRank.Name = "lblLeageRank";
            this.lblLeageRank.Size = new System.Drawing.Size(178, 25);
            this.lblLeageRank.TabIndex = 12;
            this.lblLeageRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NFLDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1376, 719);
            this.Controls.Add(this.lblDivRank);
            this.Controls.Add(this.lblConfRank);
            this.Controls.Add(this.lblLeageRank);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchTxtBoxMain);
            this.Controls.Add(this.cmbViewSelector);
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NFLDetailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFL Team Details";
            this.Load += new System.EventHandler(this.NFLDetailedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_GamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFL_PLAYER_STATSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsPlayersPlusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2023BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStats2024BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteNFLTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTeamText)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxTeams;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private System.Windows.Forms.BindingSource nFL_GamesBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter nFL_GamesTableAdapter;
        private WorldWideSportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource nFL_PLAYER_STATSBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.NFL_PLAYER_STATSTableAdapter nFL_PLAYER_STATSTableAdapter;
        private WorldWideSportsPlayersPlusDataSet worldWideSportsPlayersPlusDataSet;
        private System.Windows.Forms.BindingSource playerStats2023BindingSource;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2023TableAdapter playerStats2023TableAdapter;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private WorldWideSportsPlayersPlusDataSetTableAdapters.PlayerStats2024TableAdapter playerStats2024TableAdapter;
        private System.Windows.Forms.BindingSource playerStats2024BindingSource;
        private System.Windows.Forms.BindingSource favoriteNFLTeamsBindingSource;
        private WorldWideSportsDBDataSetTableAdapters.FavoriteNFLTeamsTableAdapter favoriteNFLTeamsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipNFLDetails;
        private System.Windows.Forms.ComboBox cmbViewSelector;
        private System.Windows.Forms.RichTextBox rchTxtBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDivRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblConfRank;
        private System.Windows.Forms.Label lblLeageRank;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pBoxTeamText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxTeamLogo;
    }
}