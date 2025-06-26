namespace PracticeMethodProblelemTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Buy Theater Ticket Program");

            // declarations

            int age;
            double ticketPrice;

            //Display Ticket price
            Console.WriteLine("Children 6 and under = FREE ($0.00)\r\n• Students 7 to 17 = $9.80\r\n• Adults 18 to 54 = $11.35\r\n• Seniors 55+ = $10.00\r\n");

            // prompt for input

            Console.WriteLine("Enter the age of Person");
            age = int.Parse(Console.ReadLine());

            ticketPrice = GetTicketPrice(age);

            Console.WriteLine($"The ticket price for person of age {age} is amount : ${ticketPrice}");


            // method definition

            double GetTicketPrice(int age)
            {

                double tPrice = 0;

                if (age <= 6)
                {
                    tPrice = 0;
                }
                else if (age > 6 && age <= 17)
                {
                    tPrice = 9.80;
                }
                else if (age > 17 && age <= 54)
                {
                    tPrice = 11.35;
                }
                else 
                {
                    tPrice = 10;
                }

                return tPrice;

            }



        }
    }
}
