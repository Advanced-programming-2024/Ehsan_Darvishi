namespace _2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the N : ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }

            Console.WriteLine($"Resualt = {sum}");
        }
    }
}