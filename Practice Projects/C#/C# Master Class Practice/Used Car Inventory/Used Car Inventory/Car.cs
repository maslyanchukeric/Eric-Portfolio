using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Used_Car_Inventory
{
    internal class Car
    {
        //properties
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public double Price { get; set; }

        //constructor that accepts all 5 properties
        public Car(string year, string make, string model, int mileage, double price)
        {
            Year = year;
            Make = make; 
            Model = model;
            Mileage = mileage;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Year} {Make} {Model}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"Price: {Price:F2}");
        }
    }
}
