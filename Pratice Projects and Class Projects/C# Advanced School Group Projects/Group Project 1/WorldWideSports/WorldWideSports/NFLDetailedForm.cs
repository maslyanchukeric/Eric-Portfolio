using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideSports
{

    public partial class NFLDetailedForm : Form
    {
        private Dictionary<string, TeamStanding> standings;
        //initialize variables with class
        DetailedNFlGames games = new DetailedNFlGames();
        NFLPlayers player = new NFLPlayers();
        //Password1!
        //Gets Dictionary from main form
        int user;

        //strings to hold the text for the boxes to make it easier to format and output to the boxes
        private string stats2023Text = "";
        private string stats2024Text = "";
        private string teamsStatsText = "";
        private string favTeamStatsText = "";
        private string favPlayerStatsText = "";

        //Template for formatting the text in the boxes
        private string Col(params (string text, int width)[] cols)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in cols)
            {
                sb.Append(c.text.PadRight(c.width));
            }
            return sb.ToString();
        }
        public NFLDetailedForm(Dictionary<string, string> nflTeamNamesGet, int userID)
        {
            InitializeComponent();
            user = userID;
            ///Used main form dictionary to fill the combo box
            cmbBoxTeams.DataSource = new BindingSource(nflTeamNamesGet, null);
            //makes sure it displays team name out and behind it the abreviation for ease of database use
            cmbBoxTeams.DisplayMember = "value";
            cmbBoxTeams.ValueMember = "key";
            //Sets it to nothing to start the cmbbox at select team
            cmbBoxTeams.SelectedIndex = -1;
            cmbBoxTeams.Text = "Select Team";



        }

        //FORM LOAD
        private void NFLDetailedForm_Load(object sender, EventArgs e)
        {
            //Loads data when the form loads
            this.favoriteNFLTeamsTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoriteNFLTeams);
            this.playerStats2024TableAdapter.Fill(this.worldWideSportsPlayersPlusDataSet.PlayerStats2024);
            this.playerStats2023TableAdapter.Fill(this.worldWideSportsPlayersPlusDataSet.PlayerStats2023);
            this.nFL_PLAYER_STATSTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_PLAYER_STATS);
            this.nFL_GamesTableAdapter.Fill(this.worldWideSportsDBDataSet.NFL_Games);

            ComputeNFLStandings();

            //Adds the view options to the view selector combo box
            cmbViewSelector.Items.Add("2023 Player Stats");
            cmbViewSelector.Items.Add("2024 Player Stats");
            cmbViewSelector.Items.Add("Team Stats");
            cmbViewSelector.Items.Add("Favorite Team Stats");
            cmbViewSelector.Items.Add("Favorite Player Stats");
            cmbViewSelector.SelectedIndex = -1;
            cmbViewSelector.Text = "Select View";
            //set the font for the box to consolas so it lines up in columns
            rchTxtBoxMain.Font = new Font("Consolas", 10);

            //Favorite Team column headings
            favTeamStatsText += (
                    Col(
                        ("Season", 10),
                        ("Week", 6),
                        ("Date", 12),
                        ("Time", 8),
                        ("Home", 8),
                        ("Away", 8),
                        ("HScore", 8),
                        ("AScore", 8),
                        ("Total", 8),
                        ("OT", 6),
                        ("Referee", 15)
                    ) + "\n"
                );
            favTeamStatsText += (new string('-', 120) + "\n");


            //FAVORITE TEAM GAMES
            //initialize Fav variables with class
            DetailedNFlGames favGames = new DetailedNFlGames();
            string teamAbrev = "";
            //Fills Favorite Team list on load
            foreach (WorldWideSportsDBDataSet.FavoriteNFLTeamsRow favRow in worldWideSportsDBDataSet.FavoriteNFLTeams.Rows)
            {
                if (favRow.UserId.ToString() == user.ToString())
                {
                    var gamesRow = worldWideSportsDBDataSet.NFL_Games
                        .Where(x => x.home_team.ToString() == favRow.TeamAbbr.ToString() && (x.season == "2023" || x.season == "2024"));//added 2023 and 2024 filter
                    foreach (var game in gamesRow)
                    {
                        //set every class atribute with the column in the table
                        favGames.GameId = game.game_id.ToString();
                        favGames.Season = game.season.ToString();
                        favGames.Week = game.week;
                        favGames.Gameday = game.gameday;
                        favGames.Gametime = game.gametime;
                        favGames.AwayTeam = game.away_team;
                        favGames.HomeTeam = game.home_team;
                        favGames.Stadium = game.stadium;
                        favGames.AwayScore = game.away_score;
                        favGames.HomeScore = game.home_score;
                        favGames.Total = game.total;
                        favGames.OverTime = game.overtime;
                        favGames.AwayCoach = game.away_coach;
                        favGames.HomeCoach = game.home_coach;
                        favGames.Referee = game.referee;
                        //gets team abrev now to use for fav team
                        teamAbrev = game.home_team;
                        //outputs the games to the box for the favorite team
                        favTeamStatsText += (
                            Col(
                                (favGames.Season, 10),
                                (favGames.Week.ToString(), 6),
                                (favGames.Gameday.ToShortDateString(), 12),
                                (favGames.Gametime.ToString(@"hh\:mm"), 8),
                                (favGames.HomeTeam, 8),
                                (favGames.AwayTeam, 8),
                                (favGames.HomeScore.ToString(), 8),
                                (favGames.AwayScore.ToString(), 8),
                                (favGames.Total.ToString(), 8),
                                (favGames.OverTime ? "Yes" : "No", 6),
                                (favGames.Referee, 15)
                                ) + "\n"
                                );
                    }
                }
            }

            //FAVORITE PLAYERS
            //Favorite Players column headings
            favPlayerStatsText += (
                Col(
                    ("Player", 25),
                    ("Age", 10),
                    ("Position", 15)
                ) + "\n"
            );
            favPlayerStatsText += (new string('-', 50) + "\n");
            //Add Favorite Players
            var player24Data = worldWideSportsPlayersPlusDataSet.PlayerStats2024
           .Where(x => x.Team.ToString() == teamAbrev.ToString())
           .OrderBy(x => x.Player);
            foreach (var players in player24Data)
            {
                //Outputs the player into text
                favPlayerStatsText += (
                    Col(
                        (players.Player, 25),
                        (players.Age.ToString(), 10),
                        (players.Pos, 15)
                    ) + "\n"
                );
            }
        }

        //TEAM SELECTION COMBO BOX CHANGE
        private void cmbBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initialize variables with class
            DetailedNFlGames games = new DetailedNFlGames();
            NFLPlayers player = new NFLPlayers();

            //Reset text buffers for team
            stats2023Text = "";
            stats2024Text = "";
            teamsStatsText = "";
            //clear text box
            rchTxtBoxMain.Clear();

            //2023 player column headings
            stats2023Text += (
                Col(
                    ("Player", 25),
                    ("Age", 10),
                    ("Position", 15),
                    ("Season", 8),
                    ("Games Played", 15),
                    ("Games Started", 15),
                    ("Total Points", 15),
                    ("Points Per Game", 20)
                ) + "\n");
            stats2023Text += (new string('-', 120) + "\n");

            //2024 player column headings
            stats2024Text += (
                Col(
                    ("Player", 25),
                    ("Age", 10),
                    ("Position", 15),
                    ("Season", 8),
                    ("Games Played", 15),
                    ("Games Started", 15),
                    ("Total Points", 15),
                    ("Points Per Game", 20)
                ) + "\n");
            stats2024Text += (new string('-', 120) + "\n");

            //Team games column headings
            teamsStatsText += (
                Col(
                    ("Season", 10),
                    ("Week", 6),
                    ("Date", 12),
                    ("Time", 8),
                    ("Home", 8),
                    ("Away", 8),
                    ("HScore", 8),
                    ("AScore", 8),
                    ("Total", 8),
                    ("OT", 6),
                    ("Referee", 15)
                ) + "\n"
            );
            teamsStatsText += (new string('-', 120) + "\n");

            if (cmbBoxTeams.SelectedIndex != -1)
            {
                //Add Games
                //this filters the games based on the 2023 and 2024 season and the team selected in the combo box using linq to get the rows that match the criteria
                var filteredGames = worldWideSportsDBDataSet.NFL_Games
                    .Where(x => x.home_team.ToString() == cmbBoxTeams.SelectedValue.ToString() && (x.season == "2023" || x.season == "2024"));
                //sets the values for the class using the columns and outputs them to box for each game that matches the combo box team selection and season selection
                foreach (var gamesRow in filteredGames)
                {
                    //set every class atribute with the column in the table
                    games.GameId = gamesRow.game_id.ToString();
                    games.Season = gamesRow.season.ToString();
                    games.Week = gamesRow.week;
                    games.Gameday = gamesRow.gameday;
                    games.Gametime = gamesRow.gametime;
                    games.AwayTeam = gamesRow.away_team;
                    games.HomeTeam = gamesRow.home_team;
                    games.Stadium = gamesRow.stadium;
                    games.AwayScore = gamesRow.away_score;
                    games.HomeScore = gamesRow.home_score;
                    games.Total = gamesRow.total;
                    games.OverTime = gamesRow.overtime;
                    games.AwayCoach = gamesRow.away_coach;
                    games.HomeCoach = gamesRow.home_coach;
                    games.Referee = gamesRow.referee;

                    teamsStatsText += (
                        Col(
                            (games.Season, 10),
                            (games.Week.ToString(), 6),
                            (games.Gameday.ToShortDateString(), 12),
                            (games.Gametime.ToString(@"hh\:mm"), 8),
                            (games.HomeTeam, 8),
                            (games.AwayTeam, 8),
                            (games.HomeScore.ToString(), 8),
                            (games.AwayScore.ToString(), 8),
                            (games.Total.ToString(), 8),
                            (games.OverTime ? "Yes" : "No", 6),
                            (games.Referee, 15)
                        ) + "\n"
                        );
                }//end if


                //players
                //2023
                var player23Data = worldWideSportsPlayersPlusDataSet.PlayerStats2023
                //LINQ get player stats and rows and set them on the player class and outputs them to box
                    .Where(x => x.Team.ToString() == cmbBoxTeams.SelectedValue.ToString())
                    .OrderBy(x => x.Player);
                foreach (var p in player23Data)
                {
                    stats2023Text += (
                        Col(
                            (p.Player, 25),
                            (p.Age.ToString(), 10),
                            (p.Pos, 15),
                            ("'23", 8),
                            (p.G.ToString(), 15),
                            (p.GS.ToString(), 15),
                            (p.Pts.ToString(), 15),
                            (p._Pts_G.ToString(), 20)
                        ) + "\n"
                    );
                }

                //var player2024
                //Lingq to get the players based on teams using the combo box Values which are the team abreviations
                var player24Data = worldWideSportsPlayersPlusDataSet.PlayerStats2024
                    .Where(x => x.Team.ToString() == cmbBoxTeams.SelectedValue.ToString())
                    .OrderBy(x => x.Player);
                foreach (var p in player24Data)
                {
                    stats2024Text += (
                        Col(
                            (p.Player, 25),
                            (p.Age.ToString(), 10),
                            (p.Pos, 15),
                            ("'24", 8),
                            (p.G.ToString(), 15),
                            (p.GS.ToString(), 15),
                            (p.Pts.ToString(), 15),
                            (p._Pts_G.ToString(), 20)
                        ) + "\n"
                    );
                }
                string fullName = cmbBoxTeams.Text;
                UpdateTeamImages(fullName);
                UpdateTeamStatLabels();
            }//end if
        }
        
        private void UpdateTeamStatLabels()
        {
            if (standings == null) return; //standings not computed yet
            if (cmbBoxTeams.SelectedValue == null) return; //no team selected
            //update standings and rankings
            string teamAbbr = cmbBoxTeams.SelectedValue.ToString();
            string fullName = cmbBoxTeams.Text;
            if (!standings.ContainsKey(teamAbbr)) return; //team not found in standings

            var s = standings[teamAbbr];
            //Update labels
            lblRecord.Text = $"{s.Wins} - {s.Losses} - {s.Ties}";
            lblDivRank.Text = s.DivisionRank.ToString();
            lblConfRank.Text = s.ConferenceRank.ToString();
            lblLeageRank.Text = s.LeagueRank.ToString();
        }
        private void nFL_GamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nFL_GamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldWideSportsDBDataSet);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //sorry changed this

            //making a variable for the main form and setting it to the owner of this form which is the main form
            MainForm mainForm = (MainForm)this.Owner;

            //close the application and return to the main form
            mainForm.Show();

            //this will close the form and send you back to the main
            this.Close();
        }

        private void cmbViewSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbViewSelector.SelectedItem.ToString())
            {
                case "2023 Player Stats":
                    rchTxtBoxMain.Text = stats2023Text;
                    break;
                case "2024 Player Stats":
                    rchTxtBoxMain.Text = stats2024Text;
                    break;
                case "Team Stats":
                    rchTxtBoxMain.Text = teamsStatsText;
                    break;
                case "Favorite Team Stats":
                    rchTxtBoxMain.Text = favTeamStatsText;
                    break;
                case "Favorite Player Stats":
                    rchTxtBoxMain.Text = favPlayerStatsText;
                    break;
            }
            rchTxtBoxMain.SelectionStart = 0;
        }
        private void ComputeNFLStandings()
        {
            standings = new Dictionary<string, TeamStanding>();
            //detect most recent season
            string mostRecentSeason = worldWideSportsDBDataSet.NFL_Games.Max(g => g.season);
            var seasonGames = worldWideSportsDBDataSet.NFL_Games.Where(g => g.season == mostRecentSeason);
            //standings dictionary
            foreach (var team in MainForm.nflStructure.Keys)
            {
                int wins = 0, losses = 0, ties = 0;
                int divWins = 0, divLosses = 0, divTies = 0;
                int confWins = 0, confLosses = 0, confTies = 0;

                var games = seasonGames.Where(g => g.home_team == team || g.away_team == team);
                foreach (var game in games)
                {
                    bool isHome = game.home_team == team;
                    int myScore = isHome ? game.home_score : game.away_score;
                    int oppScore = isHome ? game.away_score : game.home_score;
                    bool win = myScore > oppScore;
                    //overall record
                    if (win) wins++;
                    else if (myScore < oppScore) losses++;
                    else ties++;
                    //division record
                    if (game.div_game)
                    {
                        if (win) divWins++;
                        else if (myScore < oppScore) divLosses++;
                        else divTies++;
                    }
                    //conference record
                    string opp = isHome ? game.away_team : game.home_team;
                    if (!MainForm.nflStructure.ContainsKey(opp))
                    {
                        MessageBox.Show("Missing opp key: '" + opp + "'");
                        continue;
                    }

                    if (!MainForm.nflStructure.ContainsKey(team))
                    {
                        MessageBox.Show("Missing team key: '" + team + "'");
                        continue;
                    }

                    if (MainForm.nflStructure[opp].Conference ==
                        MainForm.nflStructure[team].Conference)
                    {
                        if (win) confWins++;
                        else if (myScore < oppScore) confLosses++;
                        else confTies++;
                    }
                }
                var info = MainForm.nflStructure[team];
                standings[team] = new TeamStanding
                {
                    Team = team,
                    Wins = wins,
                    Losses = losses,
                    Ties = ties,
                    Division = info.Division,
                    Conference = info.Conference,
                    DivWins = divWins,
                    DivLosses = divLosses,
                    DivTies = divTies,
                    ConfWins = confWins,
                    ConfLosses = confLosses,
                    ConfTies = confTies
                };
            }
            ComputeRankings();
        }

        private void ComputeRankings()
        {
            //league ranking
            var league = standings.Values.OrderByDescending(s => s.Wins)
                .ThenBy(s => s.Losses)
                .ThenByDescending(s => s.Ties)
                .ToList();
            for (int i = 0; i < league.Count; i++)
            {
                league[i].LeagueRank = i + 1;
            }
            //conference ranking
            foreach (var conf in standings.Values.Select(s => s.Conference).Distinct())
            {
                var confTeams = standings.Values.Where(s => s.Conference == conf)
                    .OrderByDescending(s => s.Wins)
                    .ThenBy(s => s.Losses)
                    .ThenByDescending(s => s.Ties)
                    .ToList();
                for (int i = 0; i < confTeams.Count; i++)
                {
                    confTeams[i].ConferenceRank = i + 1;
                }
            }
            //division ranking
            foreach (var div in standings.Values.Select(s => s.Division).Distinct())
            {
                var divTeams = standings.Values.Where(s => s.Division == div)
                    .OrderByDescending(s => s.Wins)
                    .ThenBy(s => s.Losses)
                    .ThenByDescending(s => s.Ties)
                    .ToList();
                for (int i = 0; i < divTeams.Count; i++)
                {
                    divTeams[i].DivisionRank = i + 1;
                }
            }
        }
        public class TeamStanding
        {
            public string Team { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Ties { get; set; }
            public int DivWins { get; set; }
            public int DivLosses { get; set; }
            public int DivTies { get; set; }
            public int ConfWins { get; set; }
            public int ConfLosses { get; set; }
            public int ConfTies { get; set; }
            public string Division { get; set; }
            public string Conference { get; set; }
            public int DivisionRank { get; set; }
            public int ConferenceRank { get; set; }
            public int LeagueRank { get; set; }
            public double WinPercentage => (Wins + (Ties * 0.5)) / (Wins + Losses + Ties);
        }

        private void UpdateTeamImages(string selectedTeam)
        {
            //Update team logos
            switch (selectedTeam)
            {
                case "Arizona Cardinals":
                    pBoxTeamLogo.Image = Properties.Resources.ArizonaLogo;
                    pBoxTeamText.Image = Properties.Resources.ArizonaText;
                    break;
                case "Atlanta Falcons":
                    pBoxTeamLogo.Image = Properties.Resources.AtlantaLogo;
                    pBoxTeamText.Image = Properties.Resources.AtlantaText;
                    break;
                case "Baltimore Ravens":
                    pBoxTeamLogo.Image = Properties.Resources.BaltimoreLogo;
                    pBoxTeamText.Image = Properties.Resources.BaltimoreText;
                    break;
                case "Buffalo Bills":
                    pBoxTeamLogo.Image = Properties.Resources.BuffaloLogo;
                    pBoxTeamText.Image = Properties.Resources.BuffaloText;
                    break;
                case "Carolina Panthers":
                    pBoxTeamLogo.Image = Properties.Resources.CarolinaLogo;
                    pBoxTeamText.Image = Properties.Resources.CarolinaText;
                    break;
                case "Chicago Bears":
                    pBoxTeamLogo.Image = Properties.Resources.ChicagoLogo;
                    pBoxTeamText.Image = Properties.Resources.ChicagoText;
                    break;
                case "Cincinnati Bengals":
                    pBoxTeamLogo.Image = Properties.Resources.CincinnatiLogo;
                    pBoxTeamText.Image = Properties.Resources.cincinnatiText;
                    break;
                case "Cleveland Browns":
                    pBoxTeamLogo.Image = Properties.Resources.ClevelandLogo;
                    pBoxTeamText.Image = Properties.Resources.ClevelandText;
                    break;
                case "Dallas Cowboys":
                    pBoxTeamLogo.Image = Properties.Resources.DallasLogo;
                    pBoxTeamText.Image = Properties.Resources.DallasText;
                    break;
                case "Denver Broncos":
                    pBoxTeamLogo.Image = Properties.Resources.DenverLogo;
                    pBoxTeamText.Image = Properties.Resources.DenverText;
                    break;
                case "Detroit Lions":
                    pBoxTeamLogo.Image = Properties.Resources.DetroitLogo;
                    pBoxTeamText.Image = Properties.Resources.DetroitText;
                    break;
                case "Green Bay Packers":
                    pBoxTeamLogo.Image = Properties.Resources.GreenBayLogo;
                    pBoxTeamText.Image = Properties.Resources.GreenBayText;
                    break;
                case "Houston Texans":
                    pBoxTeamLogo.Image = Properties.Resources.HoustonLogo;
                    pBoxTeamText.Image = Properties.Resources.HoustonText;
                    break;
                case "Indianapolis Colts":
                    pBoxTeamLogo.Image = Properties.Resources.IndianapolisLogo;
                    pBoxTeamText.Image = Properties.Resources.IndianapolisText;
                    break;
                case "Jacksonville Jaguars":
                    pBoxTeamLogo.Image = Properties.Resources.JacksonvilleLogo;
                    pBoxTeamText.Image = Properties.Resources.JacksonvilleText;
                    break;
                case "Kansas City Chiefs":
                    pBoxTeamLogo.Image = Properties.Resources.KansasCityLogo;
                    pBoxTeamText.Image = Properties.Resources.KansasCityText;
                    break;
                case "Los Angeles Chargers":
                    pBoxTeamLogo.Image = Properties.Resources.LAChargersLogo;
                    pBoxTeamText.Image = Properties.Resources.LAChargersText;
                    break;
                case "Los Angeles Rams":
                    pBoxTeamLogo.Image = Properties.Resources.LARamsLogo;
                    pBoxTeamText.Image = Properties.Resources.LARamsText;
                    break;
                case "Las Vegas Raiders":
                    pBoxTeamLogo.Image = Properties.Resources.VegasLogo;
                    pBoxTeamText.Image = Properties.Resources.VegasText;
                    break;
                case "Miami Dolphins":
                    pBoxTeamLogo.Image = Properties.Resources.MiamiLogo;
                    pBoxTeamText.Image = Properties.Resources.MiamiText;
                    break;
                case "Minnesota Vikings":
                    pBoxTeamLogo.Image = Properties.Resources.MinnesotaLogo;
                    pBoxTeamText.Image = Properties.Resources.MinnesotaText;
                    break;
                case "New England Patriots":
                    pBoxTeamLogo.Image = Properties.Resources.NewEnglandLogo;
                    pBoxTeamText.Image = Properties.Resources.NewEnglandText;
                    break;
                case "New Orleans Saints":
                    pBoxTeamLogo.Image = Properties.Resources.NewOrleansLogo;
                    pBoxTeamText.Image = Properties.Resources.NewOrleansText;
                    break;
                case "New York Giants":
                    pBoxTeamLogo.Image = Properties.Resources.NewYorkGiantsLogo;
                    pBoxTeamText.Image = Properties.Resources.NewYorkGiantsText;
                    break;
                case "New York Jets":
                    pBoxTeamLogo.Image = Properties.Resources.NewYorkJetsLogo;
                    pBoxTeamText.Image = Properties.Resources.NewYorkJetsText;
                    break;
                case "Philadelphia Eagles":
                    pBoxTeamLogo.Image = Properties.Resources.PhillyLogo;
                    pBoxTeamText.Image = Properties.Resources.PhillyText;
                    break;
                case "Pittsburgh Steelers":
                    pBoxTeamLogo.Image = Properties.Resources.PittsburghLogo;
                    pBoxTeamText.Image = Properties.Resources.PittsburghText;
                    break;
                case "Seattle Seahawks":
                    pBoxTeamLogo.Image = Properties.Resources.SeattleLogo;
                    pBoxTeamText.Image = Properties.Resources.SeattleText;
                    break;
                case "San Francisco 49ers":
                    pBoxTeamLogo.Image = Properties.Resources.SanFranLogo;
                    pBoxTeamText.Image = Properties.Resources.SanFranText;
                    break;
                case "Tampa Bay Buccaneers":
                    pBoxTeamLogo.Image = Properties.Resources.TampaLogo;
                    pBoxTeamText.Image = Properties.Resources.TampaText;
                    break;
                case "Tennessee Titans":
                    pBoxTeamLogo.Image = Properties.Resources.TennesseeLogo;
                    pBoxTeamText.Image = Properties.Resources.TennesseeText;
                    break;
                case "Washington Commanders":
                    pBoxTeamLogo.Image = Properties.Resources.WashingtonLogo;
                    pBoxTeamText.Image = Properties.Resources.WashingtonText;
                    break;
                default:
                    pBoxTeamLogo.Image = null;
                    pBoxTeamText.Image = null;
                    break;
            }
        }
    }
}
