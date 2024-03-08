using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace _2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Enter number : ");
                int input=int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                else
                {
                    char[] chars = input.ToString().ToCharArray();

                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (chars[i] == '0')
                        {
                            Console.WriteLine("The input number contains 0.");
                            break;
                        }
                        if (i == chars.Length)
                        {
                            Console.WriteLine("The input number does not contain 0.");
                        }
                    }
                }
            }
        }
    }
}