namespace maslyanchuk_E_Test_1
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Test-1

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //closes the form
            MessageBox.Show("Thanks for you have a nice day");
            this.Close();
        }

        private void calculatePriceBtn_Click(object sender, EventArgs e)
        {
            //holds the value of sales tax
            decimal taxRate = 0;
            decimal basePrice = 0;
            decimal transmissionPrice = 0;
            decimal subTotal = 0;
            decimal salesTax = 0;
            decimal totalPrice = 0;

            try
            {
                //checks if the list boxes are both selected 
                if (carListBox.SelectedItem != null && transmissionListBox.SelectedItem != null)
                {
                    //convert sales tax to double 
                    taxRate = decimal.Parse(salesTaxTextBox.Text);

                    if (taxRate < 0)
                    {
                        //tell the user to enter a positive sales tax
                        MessageBox.Show("Please enter a postive sales tax.");
                    }

                    //determine which car is selected and transmission
                    switch (carListBox.SelectedIndex)
                    {
                        case 0:
                            basePrice = 250000; //base price for lambo
                            priceOutputLabel.Text = basePrice.ToString("C"); //displays price in price label
                            break;

                        case 1:
                            basePrice = 150000; //base price for ferrai
                            priceOutputLabel.Text = basePrice.ToString("C"); //displays price in price label
                            break;

                        case 2:
                            basePrice = 75000; //base price for corvette
                            priceOutputLabel.Text = basePrice.ToString("C"); //displays price in price label
                            break;

                        case 3:
                            basePrice = 90000; //base price for tesla
                            priceOutputLabel.Text = basePrice.ToString("C"); //displays price in price label
                            break;

                        case 4:
                            basePrice = 500000; //base price for bentley
                            priceOutputLabel.Text = basePrice.ToString("C"); //displays price in price label
                            break;


                    }

                    //determine which car is selected and transmission
                    switch (transmissionListBox.SelectedIndex)
                    {
                        case 0:
                            transmissionPrice += 0; //no additional cost
                            transOutputLabel.Text = transmissionPrice.ToString("C"); //displays the transmission price in label
                            break;

                        case 1:
                            transmissionPrice += 5000; //additional 5k to cost
                            transOutputLabel.Text = transmissionPrice.ToString("C"); //displays the transmission price in label
                            break;

                        case 2:
                            transmissionPrice = basePrice * .02m; //addtional 2% of the cost
                            transOutputLabel.Text = transmissionPrice.ToString("c"); //displays the transmission price in label
                            break;

                    }

                    //calculation for the subtotal, tax rate, and full price of the car
                    subTotal = basePrice + transmissionPrice;
                    salesTax = subTotal * (taxRate / 100);
                    totalPrice = subTotal + salesTax;

                    //display the subTotal of selected car and selected transmission
                    subTotalOutputLabel.Text = subTotal.ToString("C");

                    //display the sales tax as a percentage
                    taxOutputLabel.Text = taxRate.ToString("P");

                    //display the total price
                    totalOutputLabel.Text = totalPrice.ToString("C");

                }
                else
                {
                    MessageBox.Show("Please select both a Car and a transmission");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a Sales Taxs");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears the form text box
            salesTaxTextBox.Text = "";

            //clear the list box
            carListBox.SelectedItem = null;
            transmissionListBox.SelectedItem = null;

            //clear the labels
            priceOutputLabel.Text = "";
            transOutputLabel.Text = "";
            subTotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";

        }
    }
}
