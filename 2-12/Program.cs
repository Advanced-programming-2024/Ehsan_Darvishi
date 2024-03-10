namespace _2_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Specify the day of the week : ");
                string DayOfTheWeek = Console.ReadLine();

                Console.WriteLine("Enter the start time of the conversation(HH:MM) : ");
                string startTime = Console.ReadLine();

                Console.WriteLine("Enter the duration of your conversation in minutes : ");
                int duration = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of conversation pulses : ");
                int pulseNumber=int.Parse(Console.ReadLine());

                //سوال ناقصه چون میزان هزینه تماس گفته نشده
            }
        }
    }
}