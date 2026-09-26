using System.Windows.Forms;

namespace maslyanchuk_E_Lab__10_Chapter_10
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Lab 10

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //create a plane object 
                DormMeal plan = new DormMeal();

                //check if radio button for dorm is checked
                if (allenHallRadioButton.Checked == true)
                {
                    plan.DormCost = 1500m;
                }
                else if (pikeHallRadioButton.Checked == true)
                {
                    plan.DormCost = 1600m;
                }
                else if (farthingHallRadioButton.Checked == true)
                {
                    plan.DormCost = 1800m;
                }
                else if (universitySuitesRadioButton.Checked == true)
                {
                    plan.DormCost = 2500m;
                }

                //check if radio button for meal is checked
                if (meal7RadioButton.Checked == true)
                {
                    plan.MealCost = 600m;
                }
                else if (meal14RadioButton.Checked == true)
                {
                    plan.MealCost = 1200m;
                }
                else if (unlimitedRadioButton.Checked == true)
                {
                    plan.MealCost = 1700m;
                }

                // if the dorm cost and meal cost is still Zero error mes
                if (plan.DormCost == 0 || plan.MealCost == 0)
                {
                    MessageBox.Show("Please select both a dorm and a meal plan.", "Error");
                    return;
                }

                //create a new form 
                Form totalForm = new Cost(plan);

                //calls the form
                totalForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //clear the radio buttons
            allenHallRadioButton.Checked = false;
            pikeHallRadioButton.Checked = false;
            farthingHallRadioButton.Checked = false;
            universitySuitesRadioButton.Checked = false;
            meal7RadioButton.Checked = false;
            meal14RadioButton.Checked = false;
            unlimitedRadioButton.Checked = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
