using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Maslyanchuk_Eric
{
    public class State
    {
        //properties and fields
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int StatePopulation { get; set; }
        public string FlagDescription { get; set; }
        public string StateFlower { get; set; }
        public string StateBird { get; set; }
        public string StateColor { get; set; }
        public string LargestCity1 { get; set; }
        public string LargestCity2 { get; set; }
        public string LargestCity3 { get; set; }
        public string StateCapital { get; set; }
        public decimal StateMedianIncome { get; set; }
        public decimal StateComputerJobsPercentage { get; set; }

        //parameterless constructor
        public State()
        {

        }

        //parameterized constructor
        public State(string stateName, int statePopulation, string flagDescription, string stateFlower, string stateBird, string stateColor, string largestCity1, string largestCity2, string largestCity3, decimal medianIncome, decimal computerJobsPercentage, string stateCapital)
        {
            this.StateName = stateName;
            this.StatePopulation = statePopulation;
            this.FlagDescription = flagDescription;
            this.StateFlower = stateFlower;
            this.StateBird = stateBird;
            this.StateColor = stateColor;
            this.LargestCity1 = largestCity1;
            this.LargestCity2 = largestCity2;
            this.LargestCity3 = largestCity3;
            this.StateCapital = stateCapital;
            this.StateMedianIncome = medianIncome;
            this.StateComputerJobsPercentage = computerJobsPercentage;
        }

        //override ToString method
        public override string ToString()
        {
            return $"State ID: {StateID}\n" +
                   $"State Name: {StateName}\n" +
                   $"Population: {StatePopulation}\n" +
                   $"Flag Description: {FlagDescription}\n" +
                   $"State Flower: {StateFlower}\n" +
                   $"State Bird: {StateBird}\n" +
                   $"State Color: {StateColor}\n" +
                   $"Largest City 1: {LargestCity1}\n" +
                   $"Largest City 2: {LargestCity2}\n" +
                   $"Largest City 3: {LargestCity3}\n" +
                   $"State Capital: {StateCapital}\n" +
                   $"Median Income: {StateMedianIncome:C}\n" +
                   $"Computer Jobs Percentage: {StateComputerJobsPercentage}%";

        }
    }
}

