using System.Collections.Specialized;

namespace _2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int ProductOfNonZeroDigits(int number)
            {
                // Define a variable to store the product
                int product = 1;

                // Extract the digits of the number
                while (number > 0)
                {
                    // Extract the last digit
                    int digit = number % 10;

                    // Check if the digit is not zero
                    if (digit != 0)
                    {
                        // Multiply the product by the digit
                        product *= digit;
                    }

                    // Remove the last digit from the number
                    number /= 10;
                }

                // Return the product
                return product;
            }

            for (int i = 100;i<1000;i++)
            {
                if (ProductOfNonZeroDigits(i) > i / 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}