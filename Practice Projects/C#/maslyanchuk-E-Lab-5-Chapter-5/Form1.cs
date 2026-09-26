using System.Diagnostics.CodeAnalysis;

namespace maslyanchuk_E_Lab_5_Chapter_5
{
    //Eric Maslyanchuk
    //Lab 5
    //Chapter 5
    //CPT-185-A01

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //program wont crash
            try
            {
                //variables for the code
                int startingPopulation = int.Parse(startNumTxtBox.Text); //holds users entry as startingPopulation
                double growthPercentage = double.Parse(percentageTxtBox.Text) / 100; //holds user entry as growthPercentage
                int numOfDays = int.Parse(daysNumTxtBox.Text); //holds user entry as numOfDays

                double population = startingPopulation; //holds the startingPopulation value as population

                if ((startingPopulation <= 0) || (growthPercentage <= 0.0) || (numOfDays <= 0))
                {
                    //error you can have a negative population or percentage or days
                    MessageBox.Show("You entered a negative number. Please enter a positive number.");

                    //clears the text boxes
                    startNumTxtBox.Text = "";
                    percentageTxtBox.Text = "";
                    daysNumTxtBox.Text = "";

                    //focus on the first text box
                    startNumTxtBox.Focus();
                }
                else
                {
                    //good data

                    //clear the listbox
                    populationListBox.Items.Clear();

                    //add the colums in list box
                    populationListBox.Items.Add("------------------------------------------------");
                    populationListBox.Items.Add("Days \t Approximate Population");
                    populationListBox.Items.Add("------------------------------------------------");
                    //loops for the amount of days enter by user
                    for (int day = 1; day <= numOfDays; day++)
                    {
                        //display the days and the Approximate Population
                        populationListBox.Items.Add(day + "\t\t" + population.ToString("F4")); //displays the days and the new population with 6 decimal places

                        //calculates the population growth
                        population = population * (1 + growthPercentage);

                    }
                }

            }
            catch (Exception ex)
            {
                //error message will pop if invalid entry occurs
                MessageBox.Show("Error Incorrent Entry");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clears the texts boxes
            startNumTxtBox.Text = "";
            percentageTxtBox.Text = "";
            daysNumTxtBox.Text = "";

            //clear the listbox
            populationListBox.Items.Clear();

            //focus on the first text box
            startNumTxtBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //closes the form 
            MessageBox.Show("Thank you have a good day");
            this.Close();
        }
    }
}
