using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_3_Maslyanchuk_Eric
{
    //this is a class that connects to the database and performs operations on the state table

    //repository class to handle database operations for states
    public static class StateRepository
    {
        //method to get all states from the database
        public static List<State> GetAllStates()
        {
            //create a list to hold the states
            List<State> states = new List<State>();

            //sql query to read all rows from state table
            string sql = @"SELECT
                          StateID,
                          StateName,
                          StatePopulation,
                          FlagDescription,
                          StateFlower,
                          StateBird,
                          StateColor,
                          LargestCity1,
                          LargestCity2,
                          LargestCity3,
                          StateCapital,
                          StateMedianIncome,
                          StateComputerJobsPercentage
                          FROM States
                          ORDER BY StateName;";

            //getting the connection from the database
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                //create the sql command 
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //open the database connection
                    conn.Open();

                    //execute the command and get a data reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //create the state class object
                            State s = new State();

                            //map the columns
                            s.StateID = (int)reader["StateID"];
                            s.StateName = reader["StateName"].ToString();
                            s.StatePopulation = (int)reader["StatePopulation"];
                            s.FlagDescription = reader["FlagDescription"].ToString();
                            s.StateFlower = reader["StateFlower"].ToString();
                            s.StateBird = reader["StateBird"].ToString();
                            s.StateColor = reader["StateColor"].ToString();
                            s.LargestCity1 = reader["LargestCity1"].ToString();
                            s.LargestCity2 = reader["LargestCity2"].ToString();
                            s.LargestCity3 = reader["LargestCity3"].ToString();
                            s.StateCapital = reader["StateCapital"].ToString();
                            s.StateMedianIncome = (decimal)reader["StateMedianIncome"];
                            s.StateComputerJobsPercentage = (decimal)reader["StateComputerJobsPercentage"];

                            //add the state to the list
                            states.Add(s);
                        }

                    }
                }
            }

            //return the list of states
            return states;
        }

        //method to insert multiple states into the database
        public static void InsertStates(List<State> states)
        {
            //validate input
            if (states == null || states.Count == 0)
            {
                throw new ArgumentException("The states list cannot be null or empty.", nameof(states));//input is invalid
            }

            //sql insert statement
            string sql = @" 
            INSERT INTO States(StateName, StatePopulation, FlagDescription, StateFlower, StateBird, StateColor,
             LargestCity1, LargestCity2, LargestCity3, StateCapital, StateMedianIncome, StateComputerJobsPercentage) 
            
            VALUES(@StateName, @StatePopulation, @FlagDescription, @StateFlower, @StateBird, @StateColor,
            @LargestCity1, @LargestCity2, @LargestCity3, @StateCapital, @StateMedianIncome, @StateComputerJobsPercentage);"; //SQL Insert statement

            //get the database connection and create the command
            using (SqlConnection conn = DatabaseManager.GetConnection())

            // create the command
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                // define parameters ONCE
                cmd.Parameters.Add("@StateName", System.Data.SqlDbType.NVarChar, 50); // State Name
                cmd.Parameters.Add("@StatePopulation", System.Data.SqlDbType.Int); // Population
                cmd.Parameters.Add("@FlagDescription", System.Data.SqlDbType.NVarChar, -1); // Flag Description
                cmd.Parameters.Add("@StateFlower", System.Data.SqlDbType.NVarChar, 80); // State Flower 
                cmd.Parameters.Add("@StateBird", System.Data.SqlDbType.NVarChar, 80); // State Bird
                cmd.Parameters.Add("@StateColor", System.Data.SqlDbType.NVarChar, 80); // State Color
                cmd.Parameters.Add("@LargestCity1", System.Data.SqlDbType.NVarChar, 80); // Largest City 1
                cmd.Parameters.Add("@LargestCity2", System.Data.SqlDbType.NVarChar, 80); // Largest City 2
                cmd.Parameters.Add("@LargestCity3", System.Data.SqlDbType.NVarChar, 80); // Largest City 3
                cmd.Parameters.Add("@StateCapital", System.Data.SqlDbType.NVarChar, 80); // State Capital
                cmd.Parameters.Add("@StateMedianIncome", System.Data.SqlDbType.Decimal).Precision = 12; // Median Income
                cmd.Parameters["@StateMedianIncome"].Scale = 2; // Set scale for decimal
                cmd.Parameters.Add("@StateComputerJobsPercentage", System.Data.SqlDbType.Decimal).Precision = 6; // Computer Jobs Percent
                cmd.Parameters["@StateComputerJobsPercentage"].Scale = 2; // Set scale for decimal

                // loop through each state and set parameter values
                foreach (State s in states)
                {

                    // State Name
                    if (s.StateName != null)
                    {
                        cmd.Parameters["@StateName"].Value = s.StateName;
                    }
                    else
                    {
                        cmd.Parameters["@StateName"].Value = "";
                    }

                    // Population (numbers are always safe)
                    cmd.Parameters["@StatePopulation"].Value = s.StatePopulation;

                    // Flag Description
                    if (s.FlagDescription != null)
                    {
                        cmd.Parameters["@FlagDescription"].Value = s.FlagDescription;
                    }
                    else
                    {
                        cmd.Parameters["@FlagDescription"].Value = "";
                    }

                    // State Flower
                    if (s.StateFlower != null)
                    {
                        cmd.Parameters["@StateFlower"].Value = s.StateFlower;
                    }
                    else
                    {
                        cmd.Parameters["@StateFlower"].Value = "";
                    }

                    // State Bird
                    if (s.StateBird != null)
                    {
                        cmd.Parameters["@StateBird"].Value = s.StateBird;
                    }
                    else
                    {
                        cmd.Parameters["@StateBird"].Value = "";
                    }

                    // State Color
                    if (s.StateColor != null)
                    {
                        cmd.Parameters["@StateColor"].Value = s.StateColor;
                    }
                    else
                    {
                        cmd.Parameters["@StateColor"].Value = "";
                    }

                    // Largest City 1
                    if (s.LargestCity1 != null)
                    {
                        cmd.Parameters["@LargestCity1"].Value = s.LargestCity1;
                    }
                    else
                    {
                        cmd.Parameters["@LargestCity1"].Value = "";
                    }

                    // Largest City 2
                    if (s.LargestCity2 != null)
                    {
                        cmd.Parameters["@LargestCity2"].Value = s.LargestCity2;
                    }
                    else
                    {
                        cmd.Parameters["@LargestCity2"].Value = "";
                    }

                    // Largest City 3
                    if (s.LargestCity3 != null)
                    {
                        cmd.Parameters["@LargestCity3"].Value = s.LargestCity3;
                    }
                    else
                    {
                        cmd.Parameters["@LargestCity3"].Value = "";
                    }

                    // Capital
                    if (s.StateCapital != null)
                    {
                        cmd.Parameters["@StateCapital"].Value = s.StateCapital;
                    }
                    else
                    {
                        cmd.Parameters["@StateCapital"].Value = "";
                    }

                    // Median Income
                    cmd.Parameters["@StateMedianIncome"].Value = s.StateMedianIncome;

                    // Computer Jobs Percent
                    cmd.Parameters["@StateComputerJobsPercentage"].Value = s.StateComputerJobsPercentage;

                    // INSERT the row
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //method to count all states from the database
        public static int GetStateCount()
        {
            int count = 0;

            //sql query to count all rows from state table
            string sql = "SELECT COUNT(*) FROM States;";

            //getting the connection from the database
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                //create the sql command 
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //open the database connection
                    conn.Open();

                    //execute the command and get the count
                    count = (int)cmd.ExecuteScalar();
                }
            }
            //return the count of states
            return count;
        }

        //method to get a state info when state is selected in the combobox
        public static State GetStateByName(string selectedState)
        {
            //create a state object to hold the result
            State state = null;

            //sql query to read the state by name
            string sql = @"SELECT
                          StateID,
                          StateName,
                          StatePopulation,
                          FlagDescription,
                          StateFlower,
                          StateBird,
                          StateColor,
                          LargestCity1,
                          LargestCity2,
                          LargestCity3,
                          StateCapital,
                          StateMedianIncome,
                          StateComputerJobsPercentage
                          FROM States
                          WHERE StateName = @StateName;";

            //getting the connection from the database
            using (SqlConnection conn = DatabaseManager.GetConnection())

            //create the sql command
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                //create parameter for state name
                cmd.Parameters.AddWithValue("@StateName", selectedState);

                //open the database connection
                conn.Open();

                //execute the command and get a data reader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //read the state data
                    if (reader.Read())
                    {
                        //create the state class object
                        state = new State();

                        //map the columns
                        state.StateID = (int)reader["StateID"];
                        state.StateName = reader["StateName"].ToString();
                        state.StatePopulation = (int)reader["StatePopulation"];
                        state.FlagDescription = reader["FlagDescription"].ToString();
                        state.StateFlower = reader["StateFlower"].ToString();
                        state.StateBird = reader["StateBird"].ToString();
                        state.StateColor = reader["StateColor"].ToString();
                        state.LargestCity1 = reader["LargestCity1"].ToString();
                        state.LargestCity2 = reader["LargestCity2"].ToString();
                        state.LargestCity3 = reader["LargestCity3"].ToString();
                        state.StateCapital = reader["StateCapital"].ToString();
                        state.StateMedianIncome = (decimal)reader["StateMedianIncome"];
                        state.StateComputerJobsPercentage = (decimal)reader["StateComputerJobsPercentage"];
                    }
                }
            }

            //return the state object
            return state;
        }

        //method to clear all states from the database
        public static void ClearStates()
        {
            //sql query to delete all rows from state table
            string sql = "DELETE FROM States;";

            //getting the connection from the database
            using (SqlConnection conn = DatabaseManager.GetConnection())
            {
                conn.Open(); // open ONCE

                // delete all rows
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // reset IDENTITY back to 1 (must be INSIDE the same connection)
                using (SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT ('States', RESEED, 0);", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ExportStatesToFile(string fileName)
        {
            // if user wants to export updated info for states to a file
            List<State> states = GetAllStates();

            StreamWriter outputFile;

            // overwrites the file each time
            outputFile = File.CreateText(fileName);

            // write each state's info to the file
            foreach (State s in states)
            {
                //create a line with state info separated by '|'
                string line =
                    s.StateName + "|" +
                    s.StatePopulation + "|" +
                    s.FlagDescription + "|" +
                    s.StateFlower + "|" +
                    s.StateBird + "|" +
                    s.StateColor + "|" +
                    s.LargestCity1 + "|" +
                    s.LargestCity2 + "|" +
                    s.LargestCity3 + "|" +
                    s.StateCapital + "|" +
                    s.StateMedianIncome + "|" +
                    s.StateComputerJobsPercentage;

                //write the line to the file
                outputFile.WriteLine(line);
            }

            //close the file
            outputFile.Close();    
        }
    }
}
    

