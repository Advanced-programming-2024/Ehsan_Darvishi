namespace _2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            List<int> households = new List<int>();
            List<int> monthlyCosts = new List<int>();
            List<int> annualCosts = new List<int>();

            // Read the number of households
            Console.WriteLine("Enter the number of households: ");
            int numberOfHouseholds = int.Parse(Console.ReadLine());

            // Read information for each household
            for (int i = 0; i < numberOfHouseholds; i++)
            {
                Console.WriteLine("Enter the household number: ");
                int householdNumber = int.Parse(Console.ReadLine());

                // Check for exit from program
                if (householdNumber == -99)
                {
                    break;
                }

                households.Add(householdNumber);

                // Read monthly cost
                Console.WriteLine("Enter the monthly cost of the household: ");
                int monthlyCostOfHousehold = int.Parse(Console.ReadLine());
                monthlyCosts.Add(monthlyCostOfHousehold);

                // Calculate annual cost
                int annualCostOfHousehold = monthlyCostOfHousehold * 12;
                annualCosts.Add(annualCostOfHousehold);
            }

            // Find household with minimum and maximum cost
            int minimumCost = annualCosts.Min();
            int maximumCost = annualCosts.Max();

            // Find the index of the household with minimum and maximum cost
            int minimumCostIndex = annualCosts.IndexOf(minimumCost);
            int maximumCostIndex = annualCosts.IndexOf(maximumCost);

            // Display information
            Console.WriteLine("Household with minimum cost:");
            Console.WriteLine("Number: {0}", households[minimumCostIndex]);
            Console.WriteLine("Monthly cost: {0}", monthlyCosts[minimumCostIndex]);
            Console.WriteLine("Annual cost: {0}", minimumCost);

            Console.WriteLine("Household with maximum cost:");
            Console.WriteLine("Number: {0}", households[maximumCostIndex]);
            Console.WriteLine("Monthly cost: {0}", monthlyCosts[maximumCostIndex]);
            Console.WriteLine("Annual cost: {0}", maximumCost);
        }
    }
}
//درسته مقادیر شماره خانوار با هزینه هاشون مرتبط به همدیگه نیستن ولی چون توی یک تایم ادد میشه،پس اندکس یکسانی دارن