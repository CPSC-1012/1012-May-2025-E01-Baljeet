namespace SampleAssignmentWeek6Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // declarations

            const double GST_RATE = .05;
            const double DISCOUNT = .10;
            const double SURCHARGE = 5.0;

            double ticketPrice = 20, totalPrice, netPayment;
            bool groupValidity = false;
            bool validInput = true;
            int numPeople=0;
            string groupSize, specialVehcle;


            // check for group size
            do
            {
                Console.WriteLine("Enter your Group Size ");
                Console.WriteLine($" Enter B for BIG");
                Console.WriteLine($" Enter M for MEDIUM");
                Console.WriteLine($" Enter S for SMALL");
                groupSize = Console.ReadLine();

                switch (groupSize)
                {
                    case "B": groupValidity = true; break;
                    case "M": groupValidity = true; break;
                    case "S": groupValidity = true; break;
                    default: Console.WriteLine("Enter only valid group size : B, M, S"); break;
                }
            } while (groupValidity == false);

            Console.WriteLine();    
            Console.Write(" Do you want a special vehicle: y or n");
            specialVehcle = Console.ReadLine(); 

            // if additional fecilities are required

            if (specialVehcle.ToUpper() == "Y")
            {
                ticketPrice = ticketPrice + SURCHARGE;
            }

            // total no of people
            do
            {
                try
                {
                    Console.Write("Enter number of people visiting : ");
                    numPeople = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine(" Only whole numbers are accepted");
                    validInput = false;
                }
            } while (validInput == false);

            // calculate ticket price

            totalPrice = ticketPrice * ( 1 + DISCOUNT );
            netPayment = totalPrice * ( 1 + GST_RATE );

            Console.WriteLine($" the net ticket price for {numPeople} and group size {groupSize} with surcharge {SURCHARGE} after discount{DISCOUNT} % is : {netPayment}");












            }
    }
}
