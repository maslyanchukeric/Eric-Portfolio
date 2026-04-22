namespace WorldWideSports
{
    partial class UpcomingFixtures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpcomingFixtures));
            this.gbxPgaGames = new System.Windows.Forms.GroupBox();
            this.rtxPgaUpcoming = new System.Windows.Forms.RichTextBox();
            this.gbxNflGames = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.upcomingFixToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nfL_GamesTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter();
            this.worldWideSportsDBDataSet = new WorldWideSports.WorldWideSportsDBDataSet();
            this.pgA_ALL_TOURNAMENTSTableAdapter = new WorldWideSports.WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter();
            this.gbxPgaGames.SuspendLayout();
            this.gbxNflGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPgaGames
            // 
            this.gbxPgaGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbxPgaGames.Controls.Add(this.rtxPgaUpcoming);
            this.gbxPgaGames.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPgaGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPgaGames.Location = new System.Drawing.Point(522, 100);
            this.gbxPgaGames.Name = "gbxPgaGames";
            this.gbxPgaGames.Size = new System.Drawing.Size(368, 617);
            this.gbxPgaGames.TabIndex = 0;
            this.gbxPgaGames.TabStop = false;
            this.gbxPgaGames.Text = "PGA Upcoming Fixtures";
            // 
            // rtxPgaUpcoming
            // 
            this.rtxPgaUpcoming.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtxPgaUpcoming.Location = new System.Drawing.Point(45, 39);
            this.rtxPgaUpcoming.Name = "rtxPgaUpcoming";
            this.rtxPgaUpcoming.ReadOnly = true;
            this.rtxPgaUpcoming.Size = new System.Drawing.Size(317, 572);
            this.rtxPgaUpcoming.TabIndex = 0;
            this.rtxPgaUpcoming.Text = "";
            this.upcomingFixToolTip.SetToolTip(this.rtxPgaUpcoming, "Scroll to see Fixtures");
            // 
            // gbxNflGames
            // 
            this.gbxNflGames.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gbxNflGames.Controls.Add(this.richTextBox1);
            this.gbxNflGames.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNflGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNflGames.Location = new System.Drawing.Point(81, 100);
            this.gbxNflGames.Name = "gbxNflGames";
            this.gbxNflGames.Size = new System.Drawing.Size(368, 617);
            this.gbxNflGames.TabIndex = 1;
            this.gbxNflGames.TabStop = false;
            this.gbxNflGames.Text = "NFL Upcoming Fixtures";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(45, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(317, 572);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.upcomingFixToolTip.SetToolTip(this.richTextBox1, "Scroll to see Fixtures");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(851, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< &Back";
            this.upcomingFixToolTip.SetToolTip(this.btnBack, "Click to go back to the Main page");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nfL_GamesTableAdapter
            // 
            this.nfL_GamesTableAdapter.ClearBeforeFill = true;
            // 
            // worldWideSportsDBDataSet
            // 
            this.worldWideSportsDBDataSet.DataSetName = "WorldWideSportsDBDataSet";
            this.worldWideSportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pgA_ALL_TOURNAMENTSTableAdapter
            // 
            this.pgA_ALL_TOURNAMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // UpcomingFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1017, 758);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxNflGames);
            this.Controls.Add(this.gbxPgaGames);
            this.Name = "UpcomingFixtures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upcoming Fixtures";
            this.Load += new System.EventHandler(this.UpcomingFixtures_Load);
            this.gbxPgaGames.ResumeLayout(false);
            this.gbxNflGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldWideSportsDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPgaGames;
        private System.Windows.Forms.GroupBox gbxNflGames;
        private System.Windows.Forms.RichTextBox rtxPgaUpcoming;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip upcomingFixToolTip;
        private WorldWideSportsDBDataSetTableAdapters.NFL_GamesTableAdapter nfL_GamesTableAdapter;
        private WorldWideSportsDBDataSet worldWideSportsDBDataSet;
        private WorldWideSportsDBDataSetTableAdapters.PGA_ALL_TOURNAMENTSTableAdapter pgA_ALL_TOURNAMENTSTableAdapter;
    }
}