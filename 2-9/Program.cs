namespace _2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n : ");
            int input=int.Parse(Console.ReadLine());

            List<int> EmployeesOvertime = new List<int>();

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Enter the employee's overtime : ");
                int Overtime = int.Parse(Console.ReadLine());
                EmployeesOvertime.Add(Overtime);
            }

            //Variable to store the lowest 3 values
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int min3 = int.MaxValue;

            foreach (int number in EmployeesOvertime)
            {
                if (number < min1)
                {
                    min3 = min2;
                    min2 = min1;
                    min1 = number;
                }
                else if (number < min2)
                {
                    min3 = min2;
                    min2 = number;
                }
                else if (number < min3)
                {
                    min3 = number;
                }
            }

            Console.WriteLine("Lowest 3 values : ");
            Console.WriteLine(min1);
            Console.WriteLine(min2);
            Console.WriteLine(min3);
        }
    }
}