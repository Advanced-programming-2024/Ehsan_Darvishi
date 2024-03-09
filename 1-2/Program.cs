namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int Resualt = ((31 << x) - (17 << x)) + 5;

            Console.WriteLine(Resualt);
        }
    }
}