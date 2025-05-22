/*Purpose of program is to calculate intrest for give Principal amount,
 * Rate of Intrest, and time
 * Author: Baljeet Kaur
 * Last Modified: 21st May 2025
 */


namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            double principalAmount = 1000; // Principal amount
            double rateOfInterest = .05; // Rate of interest
            double time = 2; // Time in years
            double simpleInterest; // Variable to store calculated interest
            double compoundInterest; // Variable to store calculated interest
            // Calculation of simple interest
            simpleInterest = principalAmount * rateOfInterest * time;
            // Calculation of compound interest

            compoundInterest = principalAmount * Math.Pow((1 + rateOfInterest), time) - principalAmount;
            // Displaying the result
            Console.WriteLine("The simple interest is: " + simpleInterest);
            Console.WriteLine("The Compund interest is: " + compoundInterest);

            ////Example to display opertions using MATH.cs

            int x = 10;
            int y = 20;
            int z = 30;

            int result;

            result = Math.Max(x, y); // Find the maximum of x and y 

            Console.WriteLine("The maximum value is " + result);
            result = Math.Min(x, y); // Find the maximum of x and y 

            Console.WriteLine("The minimum value is " + result);

            int a = 2;
            int b = 3;
            double c = Math.Pow(a, b);
            Console.WriteLine("The Exponent value is " + c);
        }
    }
}
