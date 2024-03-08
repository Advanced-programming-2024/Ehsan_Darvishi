namespace _2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c : ");
            int c = int.Parse(Console.ReadLine());

            int Resualt = 0;

            if (a % 2 == 0)
            {
                a = (int)Math.Pow(a,3);
                b = (int)Math.Pow(b,3);
                c = (int)Math.Pow(c,3);

                Resualt = a+b+c;
            }
            else
            {
                a = (int)Math.Pow(a,2);
                b = (int)Math.Pow(b,2);
                c = (int)Math.Pow(c,2);

                Resualt = a+b+c;
            }

            Console.WriteLine(Resualt);
        }
    }
}