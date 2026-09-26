using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Maslyanchuk_Eric
{
    //Eric Maslyanchuk
    //Lab 3
    //You have been tasked with building an
    //application that will serve as a system for a company’s state database program. 
    //this form will be the main form that will allow the user to import data from a text file

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Close button event handler
        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();

        }

        //Import Data button event handler
        private void importDataBtn_Click(object sender, EventArgs e)
        {
            //clear the database before importing new data
            StateRepository.ClearStates();

            try
            {
                //this is where data import code will go
                //after importing data i will open the next form

                //create an streamreader object
                StreamReader inputFile;

                //open the file
                inputFile = File.OpenText("StatesInfo.txt");

                //create a list to hold the state objects
                List<State> states = new List<State>();

                //variable to hold how much bad and good data there is
                int bad = 0;
                int good = 0;

                //read the file until the end
                while (!inputFile.EndOfStream)
                {
                    //read a line from the file
                    string line = inputFile.ReadLine();

                    if (string.IsNullOrWhiteSpace(line)) //check for null or whitespace
                    {
                        continue; //skip to next iteration if line is null or whitespace
                    }

                    line = line.Trim(); //remove any extra spaces

                    //split the line into fields
                    string[] parts = line.Split('|');

                    //validate the data format
                    if (parts.Length != 12)
                    {
                        bad++;
                        //data is invalid, show an error message

                        //show message for bad data format
                        MessageBox.Show("Invalid data format in file (dosent have 12 parts." + " Bad data: " + bad);
                    }
                    //try parse to makes sure is correct
                    else if (!int.TryParse(parts[1], out int pop))
                    {
                        bad++; //count goes up for bad data

                        //data is invalid, show an error message
                        MessageBox.Show("Invalid data format in file for population." + " Bad data: " + bad);

                    }
                    else if (!decimal.TryParse(parts[10], out decimal income)) //try parse income
                    {
                        bad++; //count goes up for bad data

                        //data is invalid, show an error message
                        MessageBox.Show("Invalid data format in file for income." + " Bad data: " + bad);
                    }
                    else if (!decimal.TryParse(parts[11], out decimal percentage)) //try parse percentage
                    {
                        bad++; //count goes up for bad data

                        //data is invalid, show an error message
                        MessageBox.Show("Invalid data format in file for percentage." + " Bad data: " + bad);
                    }
                    else
                    {
                        //data is good, create a state object
                        State state = new State(); //create new state object
                        state.StateName = parts[0]; //set state name
                        state.StatePopulation = pop; //set population
                        state.FlagDescription = parts[2]; //set flag description
                        state.StateFlower = parts[3]; //set state flower
                        state.StateBird = parts[4]; //set state bird
                        state.StateColor = parts[5]; //set state color
                        state.LargestCity1 = parts[6]; //set largest city 1
                        state.LargestCity2 = parts[7]; //set largest city 2
                        state.LargestCity3 = parts[8]; //set largest city 3
                        state.StateCapital = parts[9]; //set state capital
                        state.StateMedianIncome = income;//set median income
                        state.StateComputerJobsPercentage = percentage;//set computer jobs percentage

                        //add the state object to the list
                        states.Add(state);

                        good++; //count goes up for good data
                    }
                }

                //close the file
                inputFile.Close();

                //show a message indicating how many records were imported
                if (states.Count == 0)
                {
                    //no records were imported, show an error message
                    throw new Exception("No records were imported.");
                }
                else
                {
                    //INSERT INTO DATABASE HERE (uses the local List<State>)
                    StateRepository.InsertStates(states);

                    //show summary message
                    MessageBox.Show($"Import successful.\nGood: {good}\nBad: {bad}\nInserted: {states.Count}");
                }

                //open new form and pass the list of states to it
                StateForm stateForm = new StateForm();

                stateForm.ShowDialog(); //show the form as a dialog

            }
            catch (Exception ex) //catch any exceptions
            {
                //show an error message
                MessageBox.Show("Error something happen when read file or opening file: " + ex.Message);
            }

           
        }
    }
}
