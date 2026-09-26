using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldWideSports.WorldWideSportsDBDataSetTableAdapters;
using static WorldWideSports.WorldWideSportsDBDataSet;

namespace WorldWideSports
{
    public partial class PGADetailedForm : Form
    {
        int user;
        public PGADetailedForm(int userId)
        {
            InitializeComponent();
            user = userId;
        }

        private void PGADetailedForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.FavoritePGAPlayers' table. You can move, or remove it, as needed.
            this.favoritePGAPlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoritePGAPlayers);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS' table. You can move, or remove it, as needed.
            this.pGA_ALL_TOURNAMENTSTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_PLAYER_STATS' table. You can move, or remove it, as needed.
            this.pGA_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_PLAYER_STATS);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.PGA_Players' table. You can move, or remove it, as needed.
            this.pGA_PlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_Players);
            
            //this fills the combo box with pga player names
            cmbBoxPlayers.DataSource = worldWideSportsDBDataSet.PGA_PLAYER_STATS;
            cmbBoxPlayers.DisplayMember = "player_name";
            cmbBoxPlayers.Text = "Select Player";
            rchTxtBoxStats.Clear();
            rchTxtBoxTournament.Clear();


            PGAPlayerStats favStats = new PGAPlayerStats();
            //Load Favorite PGAPlayer
            //Looks at datagrid view of the PGA player stats table and gets the info from it
            foreach (WorldWideSportsDBDataSet.FavoritePGAPlayersRow favRow in worldWideSportsDBDataSet.FavoritePGAPlayers.Rows)
            {
                if (favRow.UserId.ToString() == user.ToString())
                {
                    var playerRow = worldWideSportsDBDataSet.PGA_PLAYER_STATS
                        .Where(x => x.player_name.ToString() == favRow.PlayerName.ToString());
                    foreach (var players in playerRow)
                    {
                        favStats.PlayerName = players.player_name.ToString();
                        favStats.Season = players.season;
                        favStats.Wins = players.wins;
                        favStats.TopTenFinish = players.top10_finishes;
                        favStats.AverageScore = players.avg_score;
                        favStats.EventsPlayed = players.events_played;
                        favStats.TotalEarnings = players.total_earnings;
                        favStats.TotalFedXPoints = players.total_earnings;
                        rchBoxFavPlayer.AppendText(favStats.ToString()+"\n\n");
                    }
                }
            }
            //Outputs the stats into txtBox
           
        }

        private void pGA_PlayersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pGA_PlayersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldWideSportsDBDataSet);

        }
        

        private void cmbBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Makes sure to clear TxtBox before outputing the players stats
            //rchTxtBoxStats.Clear();
            rchTxtBoxTournament.Clear();
            //Creates a PGAPlayer stats variable :D
            PGAPlayerStats stats = new PGAPlayerStats();
            PGATournament tournament = new PGATournament();
            //Makes sure something is selected and that its not the starter Message 
            if (cmbBoxPlayers.SelectedIndex != -1 && cmbBoxPlayers.SelectedItem != "Select Player")
            {
                //Looks at datagrid view of the PGA player stats table and gets the info from it
                var playerRow = (WorldWideSportsDBDataSet.PGA_PLAYER_STATSRow)
                ((DataRowView)cmbBoxPlayers.SelectedItem).Row;
                stats.PlayerName= playerRow.player_name.ToString();
                stats.Season = playerRow.season;
                stats.Wins = playerRow.wins;
                stats.TopTenFinish = playerRow.top10_finishes;
                stats.AverageScore = playerRow.avg_score;
                stats.EventsPlayed = playerRow.events_played;
                stats.TotalEarnings = playerRow.total_earnings;
                stats.TotalFedXPoints = playerRow.total_earnings;
                //Outputs the stats into txtBox
                rchTxtBoxStats.Text = stats.ToString();

                //this will filter the tournaments only using the 2023 and 2024 seasons
                var filteredTournaments = worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS
                    .Where(x => x.name.ToString() == cmbBoxPlayers.Text && (x.season == 2023 || x.season == 2024));

                foreach (var tournamentRows in filteredTournaments)
                { 
                        tournament.Season = tournamentRows.season;
                        tournament.Tournament = tournamentRows.tournament;
                        tournament.Location = tournamentRows.location;
                        tournament.Position = tournamentRows.position;
                        tournament.Score = tournamentRows.score;
                        //Checks if coloumn is null and gives it a zero
                        //COol stuff i found checks for nulls and puts a value 👍
                        tournament.Round1 = tournamentRows.Isround1Null() ? 0: tournamentRows.round1;
                        tournament.Round2 = tournamentRows.Isround2Null() ? 0 : tournamentRows.round2;
                        tournament.Round3 = tournamentRows.Isround3Null() ? 0 : tournamentRows.round3;
                        tournament.Round4 = tournamentRows.Isround4Null() ? 0 : tournamentRows.round4;
                        tournament.Total = tournamentRows.total;
                        tournament.Earnings = tournamentRows.IsearningsNull() ? 0 : tournamentRows.earnings;
                        tournament.FedXPoints = tournamentRows.Isfedex_pointsNull() ? 0 : tournamentRows.fedex_points;
                        rchTxtBoxTournament.AppendText(tournament.ToString() +"\n\n");

                }
                

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //sorry changed this
            //get the main form
            MainForm mainForm = (MainForm)this.Owner;

            //close the application and return to the main form
            mainForm.Show();

            //this will close the form and send you back to the main
            this.Close();
        }
    }
}
