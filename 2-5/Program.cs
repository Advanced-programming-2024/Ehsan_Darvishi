namespace _2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintSequence(int start, int end, bool ascending)
            {
                if (ascending)
                {
                    for (int i = start; i <= end; i *= 2)
                    {
                        Console.WriteLine("{0} ", i);
                    }
                    for (int i = end; i >= start; i /= 2)
                    {
                        Console.WriteLine("{0} ", i);
                    }
                }
            }

            PrintSequence(1, 64, true);

            //for (int i=1; i <= 64; i *= 2)
            //{
            //    Console.WriteLine(i);
            //    for (int j = 64; j >= 1; j /= 2)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
        }
    }
}