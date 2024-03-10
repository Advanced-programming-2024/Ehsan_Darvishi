using System.Security.Cryptography.X509Certificates;

namespace _2_11
{
    internal class Program
    {
        // Person class
        public class Person
        {
            public int Age { get; set; }
            public string Gender { get; set; }

            public Person(int age, string gender)
            {
                Age = age;
                Gender = gender;
            }
        }
        static void Main(string[] args)
        {
            // List to store the age and gender of people
            List<Person> people = new List<Person>();

            for (; ; )
            {
                // Read age
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age == -1)
                {
                    break;
                }

                // Read gender
                Console.Write("Enter gender (M/m for male)(F/f for fimale): ");
                string gender = Console.ReadLine().ToLower();

                // Check gender validity
                if (gender != "m" && gender != "f")
                {
                    Console.WriteLine("Invalid gender!");
                    continue;
                }

                // Add person to list
                people.Add(new Person(age, gender));
            }

            int maleCount = 0;

            // Calculate the number of males between 18 and 20 years old
            foreach (Person person in people)
            {
                if (person.Gender == "M" || person.Gender == "m" && person.Age >= 18 && person.Age <= 20)
                {
                    maleCount++;
                }
            }

            // Calculate the percentage of males between 18 and 20 years old
            double malePercentage = (double)maleCount / people.Count * 100;

            Console.WriteLine("Number of males between 18 and 20 years old: {0}", maleCount);
            Console.WriteLine("Percentage of males between 18 and 20 years old: {0:F2}%", malePercentage);

        }
    }
    
}