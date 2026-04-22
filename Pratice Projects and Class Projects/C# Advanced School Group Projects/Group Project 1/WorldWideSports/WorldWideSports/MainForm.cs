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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        //this is the userid that will be used to link the favorite teams and players to the user account, it will be set when the user logs in successfully
        public int CurrentUserId { get; set; }


        // flags to track if both favorite buttons have been clicked
        //problem with this!!!
        private bool nflSaved = false;
        private bool pgaSaved = false;

        

        private void btnViewNfl_Click(object sender, EventArgs e)
        {
            //opens the nfl details form
            NFLDetailedForm nflDetails = new NFLDetailedForm(nflTeamNames, CurrentUserId);
            nflDetails.Owner = this;
            nflDetails.Show();
            this.Hide();
        }

        private void btnViewPga_Click(object sender, EventArgs e)
        {
            //opens the pga details form
            PGADetailedForm pgaDetails = new PGADetailedForm(CurrentUserId);
            pgaDetails.Owner = this;
            pgaDetails.Show();
            this.Hide();
        }

        private void btnLoginCreate_Click(object sender, EventArgs e)
        {
            if (btnLoginCreate.Text == "Logout")
            {
                //this will log the user out by hiding the group boxes and resetting the account label and changing the button text back to login
                NoShowGbxAndBtn();
                lblAccount.Text = "";
                lblAccount.Visible = false;
                btnLoginCreate.Text = "Login/Create Account";
                //this will reset the saved flags to false
                nflSaved = false;
                pgaSaved = false;
                MessageBox.Show("You have been logged out.");
                //return the form to the login state and exit the method so it doesn't open the login form again
                return;
            }

            //this takes the user to the login form where they can either log in or create an account
            LoginForm loginForm = new LoginForm();
            //this will make the main form the owner of the login form
            loginForm.Owner = this;
            loginForm.Show();
            //this will hide the main form while the login form is open
            this.Hide();
        }

        private void btnSaveFavTeam_Click(object sender, EventArgs e)
        {
            //this will get the users team selection and turn it into a string to be saved
            string selectedTeamName = cbxNflTeams.SelectedItem.ToString();

            //convert the full nfl team name back to the abbreviation using the dictionary
            string teamAbbr = nflTeamNames.FirstOrDefault(x => x.Value == selectedTeamName).Key;

            //this will check if the team abbreviation is null or empty
            if (string.IsNullOrEmpty(teamAbbr))
            {
                MessageBox.Show("Please select a valid team.");
                return;
            }

            try
            {

                //check if the user already has a saved favorite team
                this.favoriteNFLTeamsTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoriteNFLTeams);

                //checks the existing row for the userid and gets the team abbreviation if it exists
                var existingRow = this.worldWideSportsDBDataSet.FavoriteNFLTeams.FirstOrDefault(r => r.UserId == CurrentUserId);

                if (existingRow != null)
                {
                    //user already has a favorite team so update it
                    existingRow.TeamAbbr = teamAbbr;
                    favoriteNFLTeamsTableAdapter.Update(existingRow);
                    MessageBox.Show("Favorite team updated!");
                }
                else
                {
                    //user has no favorite team yet so insert a new row
                    favoriteNFLTeamsTableAdapter.Insert(CurrentUserId, teamAbbr);
                    MessageBox.Show("Favorite team saved!");

                }
                //hides the favorite team selection group box after saving
                gbxNfl.Visible = false;

                //set this variable to true to indicate that the user has saved their favorite nfl team
                nflSaved = true;

                //shows the main buttons
                ShowMainButtons();
            }
            catch (Exception ex)
            {
                //display a message box to the user
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePga_Click(object sender, EventArgs e)
        {
            //this will get the users team selection and turn it into a string to be saved
            string selectedPlayer = cbxPga.Text;

            //checking if the selected player is null or empty
            if (string.IsNullOrEmpty(selectedPlayer))
            {
                MessageBox.Show("Please select a valid player.");
                return;
            }

            try
            {
                // check if the user already has a saved favorite player
                this.favoritePGAPlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoritePGAPlayers);

                var existingRow = this.worldWideSportsDBDataSet.FavoritePGAPlayers
                    .FirstOrDefault(r => r.UserId == CurrentUserId);

                if (existingRow != null)
                {
                    // user already has a favorite player so update it
                    existingRow.PlayerName = selectedPlayer;
                    favoritePGAPlayersTableAdapter.Update(existingRow);
                    MessageBox.Show("Favorite player updated!");
                }
                else
                {
                    // user has no favorite player yet so insert a new row
                    favoritePGAPlayersTableAdapter.Insert(CurrentUserId, selectedPlayer);
                    MessageBox.Show("Favorite player saved!");
                }
                //hides the favorite player  selection group box after saving
                gbxPga.Visible = false;

                //this will set the pgaSaved variable to true to indicate that the user has saved their favorite pga player
                pgaSaved = true;

                //this will show the main buttons if both the nflSaved and pgaSaved variables are true
                ShowMainButtons();

            }
            catch (Exception ex)
            {
                //display a message box to the user
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //loads the NFL player stats into the DataSet
            this.nfL_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_PLAYER_STATS);

            // Pulls the nfl teams from the NFL_PLAYER_STATS table, and orders them alphabetically, and removes duplicates, and converts it to a list for the combo box
            var nflTeams = this.worldWideSportsDBDataSet.NFL_PLAYER_STATS
                .Select("", "team")
                .Select(r => r["team"].ToString())
                .Distinct()
                .OrderBy(t => t)
                .ToList()
                //this will replace the team abbreviations with the full team names in the combo box
                .Select(abbr => nflTeamNames.ContainsKey(abbr) ? nflTeamNames[abbr] : abbr)
                .OrderBy(t => t)
                .ToList();


            // this binds the nfl teams to the combo box
            cbxNflTeams.DataSource = nflTeams;

            // load all PGA players into the DataSet
            this.pgA_PlayersTableAdapter.Fill(this.worldWideSportsDBDataSet.PGA_Players);

            // this binds PGA players to the combo box
            cbxPga.DataSource = this.worldWideSportsDBDataSet.PGA_Players;
            cbxPga.DisplayMember = "PlayerName";
            cbxPga.ValueMember = "PlayerId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this will close the program
            MessageBox.Show("Thank you for using World Wide Sports! Goodbye!");
            this.Close();
        }
        public void ShowGbxAndBtn()
        {
            //show the group boxes to save the favorite teams and players only when the user logs in successfully
            gbxNfl.Visible = true;
            gbxPga.Visible = true;
        }
        public void NoShowGbxAndBtn()
        {
            //wpll not show the group boxes and containers
            gbxNfl.Visible = false;
            gbxPga.Visible = false; ;
            btnViewPga.Visible = false;
            btnViewNfl.Visible = false;
            btnPgaAndNflUpcoming.Visible = false;
        }
        public void SetAccount(string username, int userId)
        {
            //this will get the username from the login form and display it on the main form, and change the login button to a logout button
            lblAccount.Text = "Account: " + username;
            lblAccount.Visible = true;
            btnLoginCreate.Text = "Logout";
            //contrusting the CurrentUserId property with the userId that is passed in from the login form
            CurrentUserId = userId;
        }
        //this is the dictionary that will be used to replace the team abbreviations with the full team names in the combo box
        public static Dictionary<string, string> nflTeamNames = new Dictionary<string, string>
        {
            {"ARI", "Arizona Cardinals"},
            {"ATL", "Atlanta Falcons"},
            {"BAL", "Baltimore Ravens"},
            {"BUF", "Buffalo Bills"},
            {"CAR", "Carolina Panthers"},
            {"CHI", "Chicago Bears"},
            {"CIN", "Cincinnati Bengals"},
            {"CLE", "Cleveland Browns"},
            {"DAL", "Dallas Cowboys"},
            {"DEN", "Denver Broncos"},
            {"DET", "Detroit Lions"},
            {"GB",  "Green Bay Packers"},
            {"HOU", "Houston Texans"},
            {"IND", "Indianapolis Colts"},
            {"JAX", "Jacksonville Jaguars"},
            {"KC",  "Kansas City Chiefs"},
            {"LA",  "Los Angeles Rams"},
            {"LAC", "Los Angeles Chargers"},
            {"LV",  "Las Vegas Raiders"},
            {"MIA", "Miami Dolphins"},
            {"MIN", "Minnesota Vikings"},
            {"NE",  "New England Patriots"},
            {"NO",  "New Orleans Saints"},
            {"NYG", "New York Giants"},
            {"NYJ", "New York Jets"},
            {"PHI", "Philadelphia Eagles"},
            {"PIT", "Pittsburgh Steelers"},
            {"SEA", "Seattle Seahawks"},
            {"SF",  "San Francisco 49ers"},
            {"TB",  "Tampa Bay Buccaneers"},
            {"TEN", "Tennessee Titans"},
            {"WAS", "Washington Commanders"}
        };
        //Dictionary for what teams are in what divisions
        public static Dictionary<string, (string Division, string Conference)> nflStructure =
            new Dictionary<string, (string, string)>
            {
                // AFC East
                { "BUF", ("AFC East", "AFC") },
                { "MIA", ("AFC East", "AFC") },
                { "NE",  ("AFC East", "AFC") },
                { "NYJ", ("AFC East", "AFC") },
                // AFC North
                { "BAL", ("AFC North", "AFC") },
                { "CIN", ("AFC North", "AFC") },
                { "CLE", ("AFC North", "AFC") },
                { "PIT", ("AFC North", "AFC") },
                // AFC South
                { "HOU", ("AFC South", "AFC") },
                { "IND", ("AFC South", "AFC") },
                { "JAX", ("AFC South", "AFC") },
                { "TEN", ("AFC South", "AFC") },
                // AFC West
                { "DEN", ("AFC West", "AFC") },
                { "KC",  ("AFC West", "AFC") },
                { "LV",  ("AFC West", "AFC") },
                { "LAC", ("AFC West", "AFC") },
                // NFC East
                { "DAL", ("NFC East", "NFC") },
                { "NYG", ("NFC East", "NFC") },
                { "PHI", ("NFC East", "NFC") },
                { "WAS", ("NFC East", "NFC") },
                // NFC North
                { "CHI", ("NFC North", "NFC") },
                { "DET", ("NFC North", "NFC") },
                { "GB",  ("NFC North", "NFC") },
                { "MIN", ("NFC North", "NFC") },
                // NFC South
                { "ATL", ("NFC South", "NFC") },
                { "CAR", ("NFC South", "NFC") },
                { "NO",  ("NFC South", "NFC") },
                { "TB",  ("NFC South", "NFC") },
                // NFC West
                { "ARI", ("NFC West", "NFC") },
                { "LA", ("NFC West", "NFC") },
                { "SEA", ("NFC West", "NFC") },
                { "SF",  ("NFC West", "NFC") }
            };

        private void btnPgaAndNflUpcoming_Click(object sender, EventArgs e)
        {
            // open the fixtures form
            UpcomingFixtures fixturesForm = new UpcomingFixtures();

            //the parent of the upcoming fixtures form
            fixturesForm.Owner = this;

            //show the fixtures form
            fixturesForm.Show();

            //this will hide the form while the fixtures form is open
            this.Hide();
        }

        public void ShowMainButtons()
        {
            if (nflSaved && pgaSaved)
            {
                btnPgaAndNflUpcoming.Visible = true;
                btnViewNfl.Visible = true;
                btnViewPga.Visible = true;
            }
        }
    }
}
