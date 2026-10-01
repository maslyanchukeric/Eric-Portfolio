namespace WeatherStationSimulator
{
    internal class Program
    {
       //array
       //random
       //loops
       //methods
       //check for highest value in array
       //compare string to each other
       //calulate average temp
       //get highest temp
       //get lowest temp
       //get common condition


        static void Main(string[] args)
        {
            //user is asked to enter an amount of days
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine()); //reads what was entered

            //user enters the amount of days and that fills the array
            int[] temperature = new int[days];
            
            //array of holds conditions that can happen
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };

            //array of actual weather conditions for the different days
            string[] weatherConditions = new string[days];

            //create a random object 
            Random random = new Random();

            //generate the weather data
            for (int i = 0; i < days; i++)
            {
                //give me a random temperature at the specific element from -10-39
                temperature[i] = random.Next(-10, 40);

                //diplay the temp
                Console.WriteLine("Temperature: " + temperature[i]);

                //get a random condition from the condition array
                weatherConditions[i] = conditions[random.Next(conditions.Length)];

                //display the condition
                Console.WriteLine("Condition is: " + weatherConditions[i] + "\n");
            }

            //display the average temp
            Console.WriteLine($"The average Temp: {CalculateAverageTemp(temperature)}");
            Console.WriteLine($"The Max Temp: {MaxTemp(temperature)}");
            Console.WriteLine($"The Min Temp: {MinTemp(temperature)}");
            Console.WriteLine($"The Common Condition: {CommonCondition(conditions)}");

        }

        //method to get the average of the temp
        static double CalculateAverageTemp(int[] temperature)
        {
            //holds the sum of temps
            double sum = 0;

            //holds the average of temps
            double average = 0;

            //loop to itterate thru the elements
            for (int i = 0; i < temperature.Length; i++)
            {
                //calculates the sum of the temp
                sum  += temperature[i];
            }

            //gets and returns the average of temps
            return average = sum / temperature.Length;

        }


        //calculate the highest temp
        static double MaxTemp(int[] temperature)
        {
            double max = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                if(temperature[i] > max)
                {
                    max = temperature[i];
                }
            }

            return max;
        }


        //calculate the lowest temp
        static double MinTemp(int[] temperature)
        {
            double min = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] < min)
                {
                    min = temperature[i];
                }
            }

            return min;
        }

        //most common condition
        static string CommonCondition(string[] conditions)
        {
            //holds the count 
            int count = 0;

            //holds the common condition and starts at element 0
            string commonCondition = conditions[0];

            //loop thru the coditions and counts the temps
            for(int i = 0 ; i < conditions.Length ; i++) 
            {
                int tempCount = 0;

                //nested loop to itterate thru conditions again 
                for (int j = 0; j < conditions.Length; j++)
                {
                    if(conditions[j] == conditions[i])
                    {
                        //count go up 
                        tempCount++;
                    }

                }

                //compares the temp count to count 
                if (tempCount > count)
                {
                    //count goes up
                    tempCount = count;

                    //sets the condition
                    commonCondition = conditions[i];
                }
            }

            return commonCondition;

        }
    }
}
