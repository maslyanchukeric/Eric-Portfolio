using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideSports
{
    public partial class UpcomingFixtures : Form
    {
        public UpcomingFixtures()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //get the main form
            MainForm mainForm = (MainForm)this.Owner;

            //close the application and return to the main form
            mainForm.Show();

            //this will close the form and send you back to the main
            this.Close();
        }

        private void UpcomingFixtures_Load(object sender, EventArgs e)
        {
            try
            {
                //loads the NFL_Games table into the dataset
                this.nfL_GamesTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_Games);

                //using LINQ create a list of NFLGames objects for the games in week 1 of the 2025 season, ordered by gameday
                var nflGamesList = this.worldWideSportsDBDataSet.NFL_Games
                    .Where(g => g.season == "2025" && g.week == 1)
                    .OrderBy(g => g.gameday)
                    .Select(g => new NFLGames(g.game_id, g.season, g.week, g.gameday, g.gametime, g.away_team, g.home_team, g.stadium))
                    .ToList();

                // loop through the games and display them in the RichTextBox
                foreach (NFLGames game in nflGamesList)
                {
                    richTextBox1.AppendText(game.ToString() + "\n");
                }


                //loads the PGA Tournaments table into the dataset
                this.pgA_ALL_TOURNAMENTSTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS);

                // Using LINQ get only 2025 tournaments
                var pgaTournamentList = this.worldWideSportsDBDataSet.PGA_ALL_TOURNAMENTS
                    .Where(g => g.season == 2025)
                    .OrderBy(g => g.start)
                    .Select(g => new { g.season, g.tournament, g.location })
                    .Distinct()
                    .ToList();

                //loop through each tournament and display in RichTextBox
                foreach (var tournament in pgaTournamentList)
                {
                    rtxPgaUpcoming.AppendText($"Season: {tournament.season}\nTournament: {tournament.tournament}\nLocation: {tournament.location}\n\n");
                    rtxPgaUpcoming.AppendText("--------------------------------------------------\n\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the data: " + ex.Message);
            }
        }
    }
}
