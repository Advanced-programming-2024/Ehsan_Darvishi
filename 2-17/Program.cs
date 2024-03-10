namespace _2_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // متغیر برای ذخیره تعداد صفرها
            int count = 0;

            // بررسی تمام اعداد چهار رقمی
            for (int i = 1000; i <= 9999; i++)
            {
                // بررسی هر رقم
                for (int j = 0; j < 4; j++)
                {
                    // اگر رقم برابر 0 باشد، تعداد صفرها را افزایش دهید
                    if (i % 10 == 0)
                    {
                        count++;
                    }
                    // تقسیم عدد بر 10 برای بررسی رقم بعدی
                    i /= 10;
                }
            }

            // نمایش تعداد صفرها
            Console.WriteLine("The number of zeros in all four-digit numbers: {0}", count);
        }
    }
}