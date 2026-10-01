using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_Repair_Shop
{
    internal class RepairJob
    {
        //Properties for the RepairJob class
        public string CustomerName { get; set; }
        public string Vehicle { get; set; }
        public string RepairType { get; set; }
        public int LaborHours { get; set; }
        public int HourlyRate { get; set; }
        public decimal PartsCost { get; set; }
        public decimal TotalCost { get; set; }


        //Constructor for the RepairJob class
        public RepairJob(string customerName, string vehicle, string repairType, int laborHours, int hourlyRate, decimal partsCost)
        {
            CustomerName = customerName;
            Vehicle = vehicle;
            RepairType = repairType;
            LaborHours = laborHours;
            HourlyRate = hourlyRate;
            PartsCost = partsCost;
        }

        //Method to calculate the total cost of the repair job
        public decimal CalculateTotal(double discount = 0)
        {
            decimal total = 0;
            decimal laborCost = LaborHours * HourlyRate;

            total = laborCost + PartsCost;

            total = total - (total * (decimal)discount / 100);

            return total;
        }
    }
}
