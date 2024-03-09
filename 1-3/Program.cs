namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs
            double salary = 5000; // Example: Monthly salary
            int deductionType = 1; // Example: 1, 2, or 3
            double taxPercentage = 5; // Example: 5%

            // Calculations
            double insurance = (deductionType == 1) ? 0.07 * salary : (deductionType == 2) ? 0.085 * salary : 0.1 * salary;
            double tax = taxPercentage / 100 * salary;
            double netSalary = salary - insurance - tax;

            // Displaying results
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Insurance: {insurance}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Net Salary: {netSalary}");
        }
    }
}