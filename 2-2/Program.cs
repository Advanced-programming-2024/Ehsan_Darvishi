namespace _2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y : ");
            int y = int.Parse(Console.ReadLine());

            int result = x ^ y;

            Console.WriteLine(result);
        }
    }
}