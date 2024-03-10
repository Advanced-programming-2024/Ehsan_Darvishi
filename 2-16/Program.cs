namespace _2_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // تابع برای بررسی تام بودن عدد
            bool IsPerfectNumber(int number)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum == number;
            }

            // تابع برای محاسبه حاصلضرب ارقام
            int GetProductOfDigits(int number)
            {
                int product = 1;
                while (number > 0)
                {
                    product *= number % 10;
                    number /= 10;
                }
                return product;
            }

            // چاپ تمام اعداد چهار رقمی با حاصل ضرب ارقام تام
            for (int i = 1000; i <= 9999; i++)
            {
                int product = GetProductOfDigits(i);
                if (IsPerfectNumber(product))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}