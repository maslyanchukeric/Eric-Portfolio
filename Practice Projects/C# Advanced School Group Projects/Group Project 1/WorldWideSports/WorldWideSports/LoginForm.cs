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

namespace WorldWideSports
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void favoriteNFLTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.favoriteNFLTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldWideSportsDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.worldWideSportsDBDataSet.Users);
            // TODO: This line of code loads data into the 'worldWideSportsDBDataSet.FavoriteNFLTeams' table. You can move, or remove it, as needed.
            this.favoriteNFLTeamsTableAdapter.Fill(this.worldWideSportsDBDataSet.FavoriteNFLTeams);

            //center the panel on the form
            CenterPanel();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //text variables
                string username = usernameTxtBox.Text.Trim();
                string password = passwordTxtBox.Text;


                //check if text box arent empty
                if (usernameTxtBox.Text == "" && passwordTxtBox.Text == "")
                {
                    //display a message box to the user
                    MessageBox.Show("Please enter a username and password.");
                }

                //varaible to hold the number of matches for the username and password
                int matchCount = (int)usersTableAdapter.CheckLogin(usernameTxtBox.Text.Trim(), passwordTxtBox.Text);

                //check if the username and password are correct
                if (matchCount > 0)
                {
                    //display a message box to the user
                    MessageBox.Show("Login successful!");

                    //open the main form
                    MainForm mainForm = (MainForm)this.Owner;

                    //reload the users table to get the latest data, especially the userId for the logged in user
                    this.usersTableAdapter.Fill(this.worldWideSportsDBDataSet.Users);

                    // find the user row that matches the username to get their Id
                    var userRow = this.worldWideSportsDBDataSet.Users.FirstOrDefault(u => u.Username == usernameTxtBox.Text.Trim());

                    // ternary operator, if the userId is not null, set it to the userId, otherwise set it to 0 as safe fallback
                    int userId = userRow != null ? userRow.UserId : 0;

                    // pass both username and userId to the main form
                    mainForm.SetAccount(usernameTxtBox.Text.Trim(), userId);

                    //this will show the group boxes to save the favorite teams and players only when the user logs in successfully
                    mainForm.ShowGbxAndBtn();

                    //shows the main form
                    mainForm.Show();

                    //hide the login form
                    this.Hide();
                }
                else
                {
                    //display a message box to the user
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                //display a message box to the user
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //get the main form
            MainForm mainForm = (MainForm)this.Owner;

            //close the application and return to the main form
            mainForm.Show();

            //close the application
            this.Close();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //open the create account form
            CreateAccount createAccountForm = new CreateAccount();
            createAccountForm.ShowDialog();
        }

        private void CenterPanel()
        {
            //center the panel on the form
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            panel2.Top = (this.ClientSize.Height - panel2.Height) / 2;
        }
    }

}
