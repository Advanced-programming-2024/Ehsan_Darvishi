namespace _2_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Excellent = 0;
            float Good = 0;
            float Nurmal = 0;
            float Poor = 0;

            int Indexer = 0;

            for (; ; )
            {
                Console.WriteLine("Enter the student's grade : ");
                float studentsGrade = float.Parse(Console.ReadLine());

                Indexer++;

                if(studentsGrade<=20 && studentsGrade >= 18)
                {
                    Excellent++;
                }
                else if(studentsGrade<18 && studentsGrade >= 15)
                {
                    Good++;
                }
                else if (studentsGrade<15 && studentsGrade >= 12)
                {
                    Nurmal++;
                }
                else if(studentsGrade < 12 && studentsGrade >= 0)
                {
                    Poor++;
                }

                float excellentPercent = (Excellent / Indexer) * 100;
                float goodPercent = (Good / Indexer) * 100;
                float nurmalPercent=(Nurmal/Indexer)*100;
                float poorPercent=(Poor/Indexer)*100;

                if (studentsGrade < 0)
                {
                    Console.WriteLine($"Percentage of excellent students %{excellentPercent}");
                    Console.WriteLine($"Percentage of good students %{goodPercent}");
                    Console.WriteLine($"Percentage of nurmal students %{nurmalPercent}");
                    Console.WriteLine($"Percentage of poor students %{poorPercent}");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}