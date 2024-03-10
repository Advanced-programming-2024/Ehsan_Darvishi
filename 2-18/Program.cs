namespace _2_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // برنامه ای برای خواندن 3 عدد و نمایش اعداد بین اعداد اول و دوم که مجموع ارقام آنها برابر عدد سوم باشد

            // تابع برای محاسبه مجموع ارقام
            static int SumOfDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            Console.Write("Enter the first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number : ");
            int c = int.Parse(Console.ReadLine());

            // بررسی اعداد بین a و b
            for (int i = a + 1; i < b; i++)
            {
                // بررسی مجموع ارقام
                if (SumOfDigits(i) == c)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}