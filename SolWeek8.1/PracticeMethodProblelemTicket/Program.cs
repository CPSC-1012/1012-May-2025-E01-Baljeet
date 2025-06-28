namespace PracticeMethodProblelemTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // the value has changed!

            /*
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
                
                    tPrice = 0;
                   
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

*/

            // EXAMPLE 2
            // 

            // variable 

            double income, taxValue;

            //

            Console.Write(" Enter amount of Income");
            income = double.Parse(Console.ReadLine());

            // 

            taxValue = CalculateTax(income);

            Console.WriteLine($" the Tax value for income {income} is : {taxValue}");




                     
            // method definition

            double CalculateTax( double income)
            {
                double tax;
                double taxableIncome1;

                if (income <= 50000)
                {
                    tax = 0;
                }
                else if (income > 50000 && income <= 100000)
                {
                    taxableIncome1 = income - 50000;
                    tax = 2500 + (taxableIncome1 * .07);
                                        
                }
                else
                {
                    taxableIncome1 = income - 100000;
                    tax = 6000 + (taxableIncome1 * .09);
                }

                return tax;


            }

        }
    }
}
