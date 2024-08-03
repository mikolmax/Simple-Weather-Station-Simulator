namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherCondition = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++) 
            {
                temperature[i] = random.Next(-10, 40);
                weatherCondition[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine($"Average temperature is: {CalculateAverageTemperature(temperature)}");
            Console.WriteLine($"Minimum temperature is: {temperature.Min()}");
            Console.WriteLine($"Maximum temperature is: {temperature.Max()}");
            Console.WriteLine($"Most common weather condition is: {MostCommonCondition(conditions)}");
            //Console.WriteLine($"Minimum temperature is: {MinTemperature(temperature)}");
            //Console.WriteLine($"Maximum temperature is: {MaxTemperature(temperature)}");

            Console.ReadKey();
        }

        static string MostCommonCondition( string[] condition)
        {
            int count = 0;
            string mostCommon = condition[0];

            for(int i = 1; i < condition.Length; i++)
            {
                int tempCount = 0;
                for(int j = 0; j < condition.Length; j++)
                {
                    if(condition[j] == condition[i])
                    {
                        tempCount++;
                    }
                }

                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = condition[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverageTemperature(int[] temperature) 
        {
            double sum = 0;

            foreach (int i in temperature)
            {
                sum += i;
            }

            double average = sum / temperature.Length;

            return average;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if(temp < min) min = temp;
            } return min;
        }

        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp > max) max = temp;
            }
            return max;
        }
    }
}
