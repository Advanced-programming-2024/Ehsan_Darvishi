namespace _2_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsOddSum(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;//برای خارج کردن کم مرتبه ترین عدد
                    number /= 10;//برای حذف کم مرتبه ترین عدد
                }
                return sum % 2 == 1;//اگر 1 برگردد یعنی sum فرد است و خروجی true خواهد داد
                //صحت درستی (sum % 2 == 1) رو چک می کنه
            }

            for (int i = 1000; i <= 9999; i++)
            {
                if (IsOddSum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}