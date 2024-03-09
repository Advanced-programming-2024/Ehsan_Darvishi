using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your insurance capital : ");
            double input=double.Parse(Console.ReadLine());
            double increased_number = 0;

            for (int i = 0; i < 8; i++)
            {
                increased_number = input * 1.045;
                input = increased_number;
            }

            Console.WriteLine($"The insured's capital after 8 years is equal to : {input}");
        }
    }
}