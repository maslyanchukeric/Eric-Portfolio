using System.Net;
namespace maslyanchuk_E_Lab_6_Chapter_6
{
    //Eric Maslyanchuk
    //Lab 6 
    //Chapter 6
    //CPT-185-A01

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        decimal partsPrice; //hold the parts price
        decimal laborHours; //hold the labor price

        const decimal tax = 0.07m; //holds the tax percentage

        decimal serviceTotal;
        decimal taxAmount;
        decimal parts;
        decimal labor;
        decimal total;

        //click event for calculate button
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //caluclates the total of what the user selected and calls all the methods
                serviceTotal = OilChangeCharge() + LubeCharge() + RadiatorFlushCharge() + TransmissionFlushCharge()
                    + InspectionCharge() + ReplaceMufflerCharge() + TireRotationCharge();

                parts = PartsCharge(); //calls the parts charge method
                labor = laborCharge(); //calls the labor charge method
                taxAmount = PartsTaxCharge(parts); //calls the tax charge method
                total = TotalCharge(serviceTotal, parts, taxAmount, labor); //calls method that gets the total

                //display the costs
                serivceAndLaborLabel.Text = (serviceTotal + labor).ToString("C");
                partsLabel.Text = parts.ToString("C");
                taxLabel.Text = taxAmount.ToString("C");
                totalFeeLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //click event that clears form
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //calls method to clear form
            ClearForm();
        }

        //method that returns the oil change price
        private decimal OilChangeCharge()
        {
            //checks to see if check box is checked
            if (oilCheckBox.Checked == true)
            {
                //sets the price for the job
                return 50.00m;
            }
            else
            {
               return 0m;
            }
        }

        //method that returns the lube Job price
        private decimal LubeCharge()
        {
            //checks to see if check box is checked
            if (lubeCheckBox.Checked == true)
            {
                //sets the price for the job
                return 40.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the radiator flush price
        private decimal RadiatorFlushCharge()
        {
            //checks to see if check box is checked
            if (radiatorCheckBox.Checked == true)
            {
                //sets the price for the job
                return 100.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the transmission flush price
        private decimal TransmissionFlushCharge()
        {
            //checks to see if check box is checked
            if (transmissionCheckBox.Checked == true)
            {
                //sets the price for the job
                return 120.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the inspection price
        private decimal InspectionCharge()
        {
            //checks to see if check box is checked
            if (inpsectioncheckBox.Checked == true)
            {
                //sets the price for the job
                return 35.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the replace muffler job price
        private decimal ReplaceMufflerCharge()
        {
            //checks to see if check box is checked
            if (mufflerCheckBox.Checked == true)
            {
                //sets the price for the job
                return 150.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the tire rotation job price
        private decimal TireRotationCharge()
        {
            //checks to see if check box is checked
            if (tireCheckBox.Checked == true)
            {
                //sets the price for the job
                return 25.00m;
            }
            else
            {
                //returns 0 for if not selected
                return 0m;
            }
        }

        //method that returns the price of parts
        private decimal PartsCharge()
        {
            //convert the string to decimal and makes sure number is not negative
            if (decimal.TryParse(partsTextBox.Text, out partsPrice) && partsPrice >= 0m)
            {
                //The decimal value of partsPrice if valid
                return partsPrice;
            }
            else
            {
                //message error
                MessageBox.Show("Invalid Entry");

                //decimal value of partsPrice if not valid
                return 0m;
            }
        }

        //method that returns the price of labor
        private decimal laborCharge()
        {
            const decimal laborPerHour = 75.00m; //holds the labor per hour
            decimal totalLabor = 0.0m; //holds the total price of labor

            //convert the string to decimal and makes sure the number is not negative
            if (decimal.TryParse(laborTextBox.Text, out laborHours) && laborHours >= 0m)
            {
                //get the total labor from the user and the labor per hour
                totalLabor = laborHours * laborPerHour;

                //returns the totalLabor
                return totalLabor;
            }
            else
            {
                //message error
                MessageBox.Show("Invalid Entry");

                //decimal value of laborPrice if not valid
                return 0m;
            }
        }

        //method that returns the price with parts and tax using an argument called parts to calculate the tax
        private decimal PartsTaxCharge(decimal parts)
        {
            return parts * tax;
        }

        //method that returns the total charges
        private decimal TotalCharge(decimal serviceTotal, decimal parts, decimal taxAmount, decimal labor)
        {
            decimal totalPrice; //holds the total price for the user

            totalPrice = serviceTotal + parts + taxAmount + labor; //calculates the total

            return totalPrice; //returns total

        }

        //Total charges

        private void ClearForm()
        {
            //clears all the check boxes
            oilCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
            radiatorCheckBox.Checked = false;
            transmissionCheckBox.Checked = false;
            inpsectioncheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireCheckBox.Checked = false;

            //clears all the labels
            serivceAndLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalFeeLabel.Text = "";

            //clears the text boxes
            partsTextBox.Text = string.Empty;
            laborTextBox.Text = string.Empty;

            //focus on the calculate button
            calculateBtn.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //message when exiting
            MessageBox.Show("Thanks for coming to Joe's Automotive!");

            //close the form
            this.Close();
        }
    }
}
