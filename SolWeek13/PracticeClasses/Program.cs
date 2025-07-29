using PHReading_Class_Example;

namespace PracticeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Individual variables
            /*
            Console.Write("Enter PH value");
            double PH = double.Parse(Console.ReadLine());

            Console.Write("Enter Date value");
            string date = Console.ReadLine();

            PhReading reading1 = new PhReading(PH, date);
            Console.WriteLine($"Reading for {reading1.Date} is {reading1.Ph:F1}");
            */
            // Using an array
            
            const int MAX_SIZE = 31;
            PhReading[] readings = new PhReading[MAX_SIZE];
            int count = 0; // count of the readings entered
            string again = "y";

            while (again == "y" && count < MAX_SIZE)
            {
                Console.Write($"Enter the date for the reading {count + 1} (MM-DD-YYYY): ");
                string date = Console.ReadLine();

                // TODO: exception handling
                Console.Write($"Enter the pH for the reading {count + 1}: ");
                double pH = double.Parse(Console.ReadLine());

                if (PhReading.IsValidDateFormat(date) && pH >= 0 && pH <= 14)
                {
                    readings[count] = new PhReading(pH, date);
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Sorry, date or pH value were invalid.");
                }

                Console.Write("Enter another (y/n): ");
                again = Console.ReadLine();
            }

            // Display the entries
            for (int i = 0; i < count; i += 1)
            {
                Console.WriteLine($"Reading for {readings[i].Date} is {readings[i].Ph:F1}");
            }

            


            /*
             * 
             * / Individual variables
//PhReading reading1 = new PhReading(7.0, "07-27-2023");
//Console.WriteLine($"Reading for {reading1.Date} is {reading1.Ph:F1}");

// Using an array
const int MAX_SIZE = 31;
PhReading[] readings = new PhReading[MAX_SIZE];
int count = 0; // count of the readings entered
string again = "y";

while (again == "y" && count < MAX_SIZE)
{
    Console.Write($"Enter the date for the reading {count + 1} (MM-DD-YYYY): ");
    string date = Console.ReadLine();

    // TODO: exception handling
    Console.Write($"Enter the pH for the reading {count + 1}: ");
    double pH = double.Parse(Console.ReadLine());

    if (PhReading.IsValidDateFormat(date) && pH >= 0 && pH <= 14)
    {
        readings[count] = new PhReading(pH, date);
        count += 1;
    }
    else
    {
        Console.WriteLine("Sorry, date or pH value were invalid.");
    }

    Console.Write("Enter another (y/n): ");
    again = Console.ReadLine();
}

// Display the entries
for (int i = 0; i < count; i += 1)
{
    Console.WriteLine($"Reading for {readings[i].Date} is {readings[i].Ph:F1}");
}

             * 
             * 
             */




        }
    }
}
