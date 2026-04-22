using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDB_Lab_2_Eric_Maslyanchuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        // ascending order button click event
        private void ascendingOrderBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopAscendingOrder(cityDBDataSet.City);
        }

        // descending order button click event
        private void descendingOrderBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopDescendingOrder(cityDBDataSet.City);
        }

        // sort City Name button click event
        private void sortCityNameBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCityName(cityDBDataSet.City);
        }

        // average population button click event
        private void averagePopulation_Click(object sender, EventArgs e)
        {
            int avgPopulation = Convert.ToInt32(cityTableAdapter.AveragePopulation());
            averageLabel.Text = "Average Population: " + avgPopulation.ToString("N0"); // shows the result in the label
        }

        // highest population button click event
        private void highestPopulationBtn_Click(object sender, EventArgs e)
        {
            int highestPop = Convert.ToInt32(cityTableAdapter.AveragePopulation());
            highestLabel.Text = "Highest Population: " + highestPop.ToString("N0"); // shows the result in the label
        }

        // lowest population button click event
        private void lowestPopulationBtn_Click(object sender, EventArgs e)
        {
            int lowestPop = Convert.ToInt32(cityTableAdapter.LowestPopulation());
            lowestLabel.Text = "Lowest Population: " + lowestPop.ToString("N0"); //shows the result in the label
        }

        // add city button click event
        private void addCityBtn_Click(object sender, EventArgs e)
        {
            cityBindingSource.AddNew();
        }

        private void deleteCityBtn_Click(object sender, EventArgs e)
        {
            //checks if there is a current record to delete
            if (cityBindingSource.Current != null)
            {
                //removes the selected record
                cityBindingSource.RemoveCurrent();
            }
        }

        // save button click event
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validates the data, ends the edit and updates the database
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);
        }
    }
}
