namespace QueryHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            string[] colors = new string[7];
            string fileName = "cpscFriday";
            // StreamWriter writer = new StreamWriter(fileName);
            //   




            for (int i = 0; i < 7; i++)
            {

                Console.Write($" entre color for day {days[i]} : ");
                colors[i] = Console.ReadLine();

            }

            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine($" entre color for day {days[i]} is {colors[i]} ");


            }



            //  StreamReader reader = new StreamReader(fileName);

            Console.Write($" entre day for which you want to change color ");
            string day = Console.ReadLine();
            Console.Write($" entre color ");
            string color = Console.ReadLine();

            for (int i = 0; i < 7; i++)
            {

                if (days[i] == day)
                {
                    colors[i] = color;
                }
            }


            for (int i = 0; i < 7; i++)
            {

                Console.WriteLine($" entre color for day {days[i]} is {colors[i]} ");


            }


        }
    } 
}
