namespace Product_Inventory
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //array for product names
        string[] productName = new string[5];
        //array for product price 
        decimal[] productPrice = new decimal[5];

        private void Form1_Load(object sender, EventArgs e)
        {
            productName[0] = "Jackets"; //element 0 
            productName[1] = "Shirts"; //element 1 
            productName[2] = "Pants"; //element 2 
            productName[3] = "Socks"; //element 3 
            productName[4] = "Shoes"; //element 4 

            productPrice[0] = 100.00m; //element 0 
            productPrice[1] = 40.00m; //element 1
            productPrice[2] = 80.00m; //element 2
            productPrice[3] = 20.00m; //element 3
            productPrice[4] = 150.00m; //element 4

            //add to the productName to listBox 
            for (int i = 0; i < productName.Length; i++)
            {
                listBoxProducts.Items.Add(productName[i]);
            }

        }

        //user is selecting from the list box
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem();
        }

        private void SelectedItem()
        {
            if (listBoxProducts.SelectedIndex == 0) //Jackets
            {
                //show the price in the label
                priceLabel.Text = "Jackets prices: $" + productPrice[0].ToString();
            }

            if (listBoxProducts.SelectedIndex == 1)  //Shirts
            {
                //show the price in the label
                priceLabel.Text = "Shirts prices: $" + productPrice[1].ToString();
            }

            if (listBoxProducts.SelectedIndex == 2) //Pants
            {
                //show the price in the label
                priceLabel.Text = "Pants prices: $" + productPrice[2].ToString();

            }

            if (listBoxProducts.SelectedIndex == 3) //Socks
            {
                //show the price in the label
                priceLabel.Text = "Socks prices: $" + productPrice[3].ToString();
            }

            if (listBoxProducts.SelectedIndex == 4) //Shoes
            {
                //show the price in the label
                priceLabel.Text = "Shoes prices: $" + productPrice[4].ToString();
            }
        }

        
    }
}
