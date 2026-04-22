using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maslyanchuk_E_Lab_11_Chapter_13
{
    //Eric Maslyanchuk
    //Lab 11
    //City Population Database

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //saves any changes made in the grid back into the database
        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);
        }

        //loads the City table when the form starts
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);
        }

        //sorts by population (ascending)
        private void sortAscBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopulationAsc(populationDBDataSet.City);
        }

        //sorts by population (descending)
        private void sortDescBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByPopulationDesc(populationDBDataSet.City);
        }

        //sorts by city name (A–Z)
        private void sortNameBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.FillByCityName(populationDBDataSet.City);
        }

        //shows the total population of all cities
        private void totalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(cityTableAdapter.GetTotalPopulation());
                MessageBox.Show($"Total Population: {total:N0}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total: " + ex.Message);
            }
        }

        //shows the average population
        private void averageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decimal avg = Convert.ToDecimal(cityTableAdapter.GetAveragePopulation());
                MessageBox.Show($"Average Population: {avg:N0}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating average: " + ex.Message);
            }
        }

        //shows the lowest population
        private void minBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int min = Convert.ToInt32(cityTableAdapter.GetMinPopulation());
                MessageBox.Show($"Lowest Population: {min:N0}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating minimum: " + ex.Message);
            }
        }

        //shows the highest population
        private void maxBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int max = Convert.ToInt32(cityTableAdapter.GetMaxPopulation());
                MessageBox.Show($"Highest Population: {max:N0}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating maximum: " + ex.Message);
            }
        }

        //reloads the original table from the database
        private void resetBtn_Click(object sender, EventArgs e)
        {
            cityTableAdapter.Fill(populationDBDataSet.City);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you have a good day");
            this.Close();
        }
    }
}
