using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Maslyanchuk_Eric
{
    //state form class
    //this form displays state information and allows searching, filtering and updating

    public partial class StateForm : Form
    {
        //binding source for data binding
        private BindingSource statesBS = new BindingSource();

        //data set and table adapter for database interaction
        private UnitedStatesDataSet ds = new UnitedStatesDataSet();

        //table adapter for states table
        private UnitedStatesDataSetTableAdapters.StatesTableAdapter ta = new UnitedStatesDataSetTableAdapters.StatesTableAdapter();
        
        public StateForm() 
        {
            InitializeComponent();
            
        }

        //form load event handler
        private void StateForm_Load(object sender, EventArgs e)
        {
            try
            {
                ta.Fill(ds.States);

                // bind grid to DataTable (this is what makes UPDATE possible)
                statesBS.DataSource = ds.States;
                statesDataGridView.AutoGenerateColumns = true;
                statesDataGridView.DataSource = statesBS;

                // allow editing
                statesDataGridView.ReadOnly = false;
                statesDataGridView.AllowUserToAddRows = false;

                // combo box can still show states
                stateComboBox.DisplayMember = "StateName";
                stateComboBox.DataSource = ds.States;
                stateComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data load failed: " + ex.Message);
            }
        }

        //state details button click event handler
        private void stateDetailsBtn_Click(object sender, EventArgs e)
        {
            if(stateComboBox.SelectedIndex != -1)
            {
                //get the selected row from the combo box
                DataRowView row = (DataRowView)stateComboBox.SelectedItem;

                //create a State object from the selected row
                State selectedState = new State();

                //populate the State object with data from the DataRowView
                selectedState.StateID = Convert.ToInt32(row["StateID"]); 
                selectedState.StateName = row["StateName"].ToString();
                selectedState.StatePopulation = Convert.ToInt32(row["StatePopulation"]);
                selectedState.FlagDescription = row["FlagDescription"].ToString();
                selectedState.StateFlower = row["StateFlower"].ToString();
                selectedState.StateBird = row["StateBird"].ToString();
                selectedState.StateColor = row["StateColor"].ToString();
                selectedState.LargestCity1 = row["LargestCity1"].ToString();
                selectedState.LargestCity2 = row["LargestCity2"].ToString();
                selectedState.LargestCity3 = row["LargestCity3"].ToString();
                selectedState.StateCapital = row["StateCapital"].ToString();
                selectedState.StateMedianIncome = Convert.ToDecimal(row["StateMedianIncome"]);
                selectedState.StateComputerJobsPercentage = Convert.ToDecimal(row["StateComputerJobsPercentage"]);

                //open the StateDetailForm with the selected state
                StateDetailForm stateInfoForm = new StateDetailForm(selectedState);
                stateInfoForm.ShowDialog();
            }
            else
            {
                //show error message if no state is selected
                MessageBox.Show("Please select a state from the dropdown box.");
            }
        }

        //search button click event handler
        private void searchStateBtn_Click(object sender, EventArgs e)
        {
            //get the search text
            string text = searchTextBox.Text.Trim().ToLower();

            if(text == "")
            {
                //reset the binding source to show all states
                MessageBox.Show("Please enter a state name to search.");

                //clear the textbox
                return;
            }

            //escape single quotes in the search text   
            text = text.Replace("'", "''");

            //filter the info based on the search text (state name)
            statesBS.Filter = "StateName LIKE '%" + text + "%' OR " +
                              "StateCapital LIKE '%" + text + "%' OR " +
                              "StateBird LIKE '%" + text + "%' OR " +
                              "StateColor LIKE '%" + text + "%' OR " +
                              "StateFlower LIKE '%" + text + "%'";


        }

        //search largest cities button click event handler
        private void searchStateLargestCitiesBtn_Click(object sender, EventArgs e)
        {
            //get the search text
            string searchText = stateLargestCitiesTextBox.Text.Trim();

            if(searchText == "")
            {
                //show error message for empty input
                MessageBox.Show("Please enter a city name to search.");
                //clear the textbox
                return;
            }
            //escape single quotes in the search text
            searchText = searchText.Replace("'", "''");

            //filter the info based on the largest cities
            statesBS.Filter = "LargestCity1 LIKE '%" + searchText + "%' OR " +
                              "LargestCity2 LIKE '%" + searchText + "%' OR " +
                              "LargestCity3 LIKE '%" + searchText + "%'";
        }

        //search population button click event handler
        private void searchStatePopulationBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to an integer
            int population;

            //filter the info based on the population number
            if (!int.TryParse(statePopulationTextBox.Text.Trim(), out population))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid population number.");

                //clear the textbox
                statePopulationTextBox.Clear();
                return;
            }
            //filer rows by exact population match
            statesBS.Filter = "StatePopulation = " + population;
        }

        //search population less than button click event handler
        private void popLessThanBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to an integer
            int pop;

            //filter the info based on the population number
            if (!int.TryParse(statePopulationTextBox.Text.Trim(), out pop))
            {
                MessageBox.Show("Please enter a valid population number.");
                statePopulationTextBox.Clear();
                return;
            }

            //filter states by population less than
            statesBS.Filter = "StatePopulation <= " + pop;

        }

        // search population greater than button click event handler
        private void popGreaterThanBtn_Click(object sender, EventArgs e)
        {
            int pop;

            // check if input is NOT a number
            if (!int.TryParse(statePopulationTextBox.Text.Trim(), out pop))
            {
                MessageBox.Show("Please enter a valid population number.");
                statePopulationTextBox.Clear();
                return;
            }

            // filter states by population greater than or equal to value
            statesBS.Filter = "StatePopulation >= " + pop;
        }

        //search median income button click event handler
        private void searchStateMedianIncomeBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal medianIncome;

            //filter the info based on the median income
            if (!decimal.TryParse(stateMedainIncomeTextBox.Text.Trim(), out medianIncome))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid median income.");

                //clear the textbox
                stateMedainIncomeTextBox.Clear();
                return;
            }

            //filer rows by exact median income match
            statesBS.Filter = "StateMedianIncome = " + medianIncome;
        }

        //search median income greater than button click event handler
        private void incomceGreaterThanBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal income;

            //filter the info based on the median income
            if (!decimal.TryParse(stateMedainIncomeTextBox.Text.Trim(), out income))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid median income.");

                //clear the textbox
                stateMedainIncomeTextBox.Clear();
                return;
            }

            //filter states by median income greater than
            statesBS.Filter = "StateMedianIncome >= " + income;
        }

        //search median income less than button click event handler
        private void incomeLessThanBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal income;

            //filter the info based on the median income
            if (!decimal.TryParse(stateMedainIncomeTextBox.Text.Trim(), out income))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid median income.");

                //clear the textbox
                stateMedainIncomeTextBox.Clear();
                return;
            }

            //filter states by median income less than
            statesBS.Filter = "StateMedianIncome <= " + income;
        }
        private void searchStateComputerJobBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal computerJobPercent;

            //filter the info based on the computer job percentage
            if (!decimal.TryParse(stateComputerJobTextBox.Text.Trim(), out computerJobPercent))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid percentage. For example 3.21");

                //clear the textbox
                stateComputerJobTextBox.Clear();

                return;
            }

            //filer rows by exact computer job percentage match
            statesBS.Filter = "StateComputerJobsPercentage = " + computerJobPercent;
        }

        //search computer jobs greater than button click event handler
        private void compJobsGreaterBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal pct;

            //filter the info based on the computer job percentage
            if (!decimal.TryParse(stateComputerJobTextBox.Text.Trim(), out pct))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid percentage. For example 3.21");

                //clear the textbox
                stateComputerJobTextBox.Clear();

                return;
            }

            //filter states by computer job percentage greater than
            statesBS.Filter = "StateComputerJobsPercentage >= " + pct;
        }

        //search computer jobs less than button click event handler
        private void compJobsLessBtn_Click(object sender, EventArgs e)
        {
            //parse the search text to a decimal
            decimal pct;

            //filter the info based on the computer job percentage
            if (!decimal.TryParse(stateComputerJobTextBox.Text.Trim(), out pct))
            {
                //message box showing the error
                MessageBox.Show("Please enter a valid percentage. For example 3.21");

                //clear the textbox
                stateComputerJobTextBox.Clear();

                return;
            }

            //filter states by computer job percentage less than
            statesBS.Filter = "StateComputerJobsPercentage <= " + pct;
        }

        //update button click event handler
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                statesBS.EndEdit();
                ta.Update(ds.States); // save to DB first

                 // then update the text file

                MessageBox.Show("Changes saved (DB + text file).");

                StateRepository.ExportStatesToFile("StatesInfo.txt");
                MessageBox.Show("Export complete.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        //clear button click event handler
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //reset the combo box selection
            stateComboBox.SelectedIndex = -1;

            //clear all search text boxes
            searchTextBox.Clear();
            stateLargestCitiesTextBox.Clear();
            statePopulationTextBox.Clear();
            stateMedainIncomeTextBox.Clear();
            stateComputerJobTextBox.Clear();

            //resets the grid back to all rows
            statesBS.RemoveFilter();
            
        }

        //exit button click event handler
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
