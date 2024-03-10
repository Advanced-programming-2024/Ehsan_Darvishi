namespace _2_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Enter the water consumption : ");
                float watherConsumption = float.Parse(Console.ReadLine());

                if(watherConsumption < 0) 
                {
                    break;
                }

                Console.WriteLine("Enter the consumption type (H/I/F) : ");
                string cunsumptionType = Console.ReadLine().ToLower();
                float waterBill = 0;

                if (cunsumptionType == "h")
                {
                    waterBill = watherConsumption * 5;
                }
                else if(cunsumptionType == "i")
                {
                    if (watherConsumption < 4000)
                    {
                        waterBill = (float)(watherConsumption * 0.75);
                    }
                    else
                    {
                        waterBill = (float)(watherConsumption * 0.75025);
                    }
                }
                else if(cunsumptionType == "f")
                {
                    if (watherConsumption < 2000000)
                    {
                        waterBill = (float)(watherConsumption * 4);
                    }
                    else
                    {
                        waterBill = (float)(watherConsumption * 4.00004);
                    }
                }

                Console.WriteLine($"The bill amount is {waterBill} Rial.");

            }
        }
    }
}