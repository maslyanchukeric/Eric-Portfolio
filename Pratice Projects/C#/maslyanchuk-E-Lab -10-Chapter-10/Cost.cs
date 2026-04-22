using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maslyanchuk_E_Lab__10_Chapter_10
{
    public partial class Cost : Form
    {
        //Eric Maslyanchuk
        //CPT-185-A01
        //Lab 10

        // Field to hold selected DormMeal object passed from the main form
        private DormMeal plan;

        // Constructor that receives the selected DormMeal object from the main form
        public Cost(DormMeal selectedPlan)
        {
            InitializeComponent();

            // Store the reference to the selected plan
            plan = selectedPlan;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the current Cost form
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //display cost in labels on the form
            dormCostLabel.Text = plan.DormCost.ToString("C");
            mealCostLabel.Text = plan.MealCost.ToString("C");
            totalCostLabel.Text = plan.TotalCost.ToString("C");
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // Create instance About form
            Form aboutForm = new About();

            // Display the About form 
            aboutForm.ShowDialog();
        }
    }
}
