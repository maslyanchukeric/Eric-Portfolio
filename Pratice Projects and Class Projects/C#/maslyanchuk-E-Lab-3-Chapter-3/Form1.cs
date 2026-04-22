namespace maslyanchuk_E_Lab_3
{
    /*
    * Eric Maslyanchuk
    * CPT - 185 - AO1
    * Lab 3
    */

    /*
     * Create an application that allows the user to enter the number of 
     * tickets sold for three seating categories at an athletic stadium:
     * Class A seats cost $15 each
     * Class B seats cost $12 each
     * Class C seats cost $9 each
     * The application should calculate and display the income generated 
     * from each class of ticket sales and the total revenue generated.
     */

    public partial class stadiumSeating : Form
    {
        public stadiumSeating()
        {
            InitializeComponent();
        }
        private void calculateRevenueBtn_Click(object sender, EventArgs e)
        {
            //varibles
            int classAPrice = 15;
            int classBPrice = 12;
            int classCPrice = 9;

            int classATickets;
            int classBTickets;
            int classCTickets;

            decimal classATotal;
            decimal classBTotal;
            decimal classCTotal;
            decimal totalRevenue;

            try
            {
                //converts users enrty to the a int
                classATickets = int.Parse(classATxtBox.Text);
                classBTickets = int.Parse(classBTxtBox.Text);
                classCTickets = int.Parse(classCTxtBox.Text);

                //makes sure that user doesnt enter a negative number 
                if ((classATickets < 0) || (classBTickets < 0) || (classCTickets < 0))
                {
                    //if user enter a negative number then messages pops and clears the text boxes
                    MessageBox.Show("You entered a neagtive number!! Please try again!");
                    classATxtBox.Clear();
                    classBTxtBox.Clear();
                    classCTxtBox.Clear();
                }
                else
                {
                    //calculate the seats price 
                    classATotal = classATickets * classAPrice;
                    classBTotal = classBTickets * classBPrice;
                    classCTotal = classCTickets * classCPrice;

                    //calculates total revenue
                    totalRevenue = classATotal + classBTotal + classCTotal;

                    //display the ticket sales in the text box 
                    RevenueATxtBox.Text = classATotal.ToString("c");
                    RevenueBTxtBox.Text = classBTotal.ToString("c");
                    RevenueCTxtBox.Text = classCTotal.ToString("c");
                    totalTxtBox.Text = totalRevenue.ToString("c");
                }
            }
            catch (Exception ex)
            {
                //message to show user a entry error
                MessageBox.Show("Please enter valid whole numbers for all ticket fields.");
                classATxtBox.Clear();
                classBTxtBox.Clear();
                classCTxtBox.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //clears all the text boxes
            classATxtBox.Clear();
            classBTxtBox.Clear();
            classCTxtBox.Clear();

            //clears the revenue text box
            RevenueATxtBox.Clear();
            RevenueBTxtBox.Clear();
            RevenueCTxtBox.Clear();

            //clears the total text box 
            totalTxtBox.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //message box says thanks
            MessageBox.Show("Thank You!");

            //closes the form
            this.Close();
        }
    }
}
