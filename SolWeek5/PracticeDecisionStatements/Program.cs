//Purpose: To calculate area of a Circle using the formula Area = π * r^2
// Author: Baljeet Kaur
// Date: 2025 June 02


namespace PracticeDecisionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1: Calculate Area of Circle
            /*
            // Declaration of variables

            double radius, area;

            // taking input from user
            Console.WriteLine("This program calculates the area of a Circle");
            Console.Write("Enter the value of radius: ");
            radius = double.Parse(Console.ReadLine());

            // calculate area of the circle only if the radius is positive

            if (radius >= 0)
            {
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"Area of circle for given radius - {radius} is :{area:00.00} ");
            }
            else
            {
                Console.WriteLine("Invalid radius value. Please enter a positive number.");
            }
            */

            // Example 2

            // Declaration of variables

            double score1, score2, score3, average;

            // taking input from user

            Console.WriteLine("This program calculates the average of three scores");
            Console.Write("Enter the first score: ");
            score1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second score: ");
            score2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third score: ");
            score3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            // calculate average

            average = (score1 + score2 + score3) / 3;
            Console.WriteLine($"Average of Score1 {score1}, Score2 {score2}," +
                                        $" Score3 {score3} is : {average}");
            // Check if average is greater than or equal to 90, then congratulate the user

            if (average >= 90)
            {
                Console.WriteLine("Congratulations! You have an excellent average score.");
            }
            else
            {
                Console.WriteLine("You have scope for furthur improvement");
            }


        }
    }
}
