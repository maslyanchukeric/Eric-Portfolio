using System.Linq.Expressions;

namespace maslyanchuk_E_Test_2
{
    //Eric Maslyanchuk
    //Test-2
    //CPT-185-A01

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //message says thank you and close the form
            MessageBox.Show("Thank you! Have a great Day!");

            this.Close();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //varibles
                decimal total;
                decimal bouns;
                decimal largest;
                decimal smallest;

                //calls method populate year to fill the combo box
                PopulateYear();

                //create a streamReader
                StreamReader inputFile;

                //create array of salaries
                decimal[] salaries = new decimal[10];

                //create a counter to count the elements in array
                int index = 0;
                if (yearComboBox.SelectedItem == null)
                {
                    //error Message
                    MessageBox.Show("Please select a year to continue");
                    resultLabel.Text = ""; // Clear the results label
                    return; // Exit the method if no year is selected
                }
                else
                {
                    //seacrh for the file
                    if (openFileDialogSalary.ShowDialog() == DialogResult.OK)
                    {
                        //open the file 
                        inputFile = File.OpenText(openFileDialogSalary.FileName);

                        //read the file
                        while (!inputFile.EndOfStream && index < salaries.Length)
                        {
                            //add the elements in to array
                            salaries[index] = decimal.Parse(inputFile.ReadLine());
                            index++; //count goes up
                        }

                        //close the file
                        inputFile.Close();

                        //get the total salaies, number of records,
                        //average, largest, smallest, and bonus

                        //get bonus
                        bouns = GetBonus(salaries, index);

                        //get the total of salaies
                        total = GetTotalSalaires(salaries);

                        //get the largest salary 
                        largest = GetLargestSalary(salaries);

                        //get the smalles salary
                        smallest = GetSmallestSalary(salaries);


                        //display the total salaies, number of records,
                        //average, largest, smallest, and bonus
                        resultLabel.Text = "Total Salaries: " + total.ToString("C") + "\n" +
                                           "Bonus Amount: " + bouns.ToString("C") + "\n" +
                                           "Largest Salary: " + largest.ToString("c") + "\n" +
                                           "Smallest Salary: " + smallest.ToString("c") + "\n" +
                                           "Number of Records: " + index.ToString();
                    }
                    else
                    {
                        //clears the combo box

                        //message shows you hit cancel
                        MessageBox.Show("You hit the cancel button");

                        //focus on the process button
                        processBtn.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                //error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clear the combo box
            yearComboBox.SelectedItem = null;

            //clear the result Label
            resultLabel.Text = "Total Salaries: " + "\n" +
                               "Bonus Amount: " + "\n" +
                               "Largest Salary: " + "\n" +
                               "Smallest Salary: ";

        }

        private decimal GetSmallestSalary(decimal[] salaries)
        {
            decimal smallest = salaries[0]; //holds the element 0 as the largest 

            //loops thru the array
            for (int i = 0; i < salaries.Length; i++)
            {
                //check to see if i is larger than largest
                if (salaries[i] < smallest)
                {
                    //sets that element as largest
                    smallest = salaries[i];
                }
            }

            return smallest;

        }

        private decimal GetLargestSalary(decimal[] salaries)
        {
            decimal largest = salaries[0]; //holds the element 0 as the largest 

            //loops thru the array
            for (int i = 0; i < salaries.Length; i++)
            {
                //check to see if i is larger than largest
                if (salaries[i] > largest)
                {
                    //sets that element as largest
                    largest = salaries[i];
                }
            }

            return largest;
        }

        private decimal GetTotalSalaires(decimal[] salaries)
        {
            decimal total = 0; //hold the number of total salary

            for (int i = 0; i < salaries.Length; i++)
            {
                total += salaries[i];
            }
            //returns total salaries
            return total;
        }

        private decimal GetBonus(decimal[] salaries, int index)
        {

            //calculation to get the average
            decimal average = GetTotalSalaires(salaries) / index;

            // get year from combo box
            int selectedYear = int.Parse(yearComboBox.SelectedItem.ToString()); //holds the selected year

            decimal bonus = 0m; //holds the bonus

            if (selectedYear < 2000)
            {
                bonus = average * 0.10m;
            }
            else if (selectedYear >= 2000 && selectedYear <= 2008)
            {
                bonus = average * 0.20m;
            }
            else
            {
                bonus = 0.0m;
            }
            return bonus;
        }

        private void PopulateYear()
        {
            //fills the year from 1900 to 2024 into combo box
            for (int year = 1900; year <= 2024; year++)
            {
                yearComboBox.Items.Add(year.ToString());
            }
        }

       
    }
}
