using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslyanchuk_E_Lab__10_Chapter_10
{
    //Eric Maslyanchuk
    //CPT-185-A01
    //Lab 10

    public class DormMeal
    {
        //list of fields
        decimal dormCost;
        decimal mealCost;

        //constructor
        public DormMeal()
        {
            dormCost = 0m;
            MealCost = 0m;

        }

        //properties
        public decimal DormCost
        {
            get { return dormCost; }
            set { dormCost = value; }
        }

        public decimal MealCost
        {
            get { return mealCost; }
            set { mealCost = value; }
        }

        public decimal TotalCost
        {
            get { return dormCost + mealCost; }
        }
    }
}
