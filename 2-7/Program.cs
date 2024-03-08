namespace _2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user
            int number = int.Parse(Console.ReadLine());

            // Define a variable to store the product
            int product = 1;

            // Check if the number is zero
            if (number != 0)
            {
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
            }

            // Print the product
            Console.WriteLine("Multiplication of non-zero digits: {0}", product);
        }
    }
}