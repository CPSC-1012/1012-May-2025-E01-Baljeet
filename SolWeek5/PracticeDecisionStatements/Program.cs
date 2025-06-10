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
            /*
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
            

            //Example 3: Displaying grade of a student based on the score of student

            // Declaration of variables
            double score;
            char grade;

            // taking input from user
            
            Console.WriteLine("Please enter the score of the student");
            score = double.Parse(Console.ReadLine());
            
            if (score < 50)
            {
                grade = 'F';
                //Console.WriteLine(" The student has failed the exam.");
            }
            else if (score < 60)
            {
                grade = 'D';
                //Console.WriteLine("The student has received a grade of D.");
            }
            else if (score < 70)
            {

                grade = 'C';
               // Console.WriteLine("The student has received a grade of C.");
            }
            else if (score < 80)
            {
                grade = 'B';
              //  Console.WriteLine("The student has received a grade of B.");
            }
            else
            {
                grade = 'A';
              //  Console.WriteLine("The student has received a grade of A.");
            }

            // out of if else nested structure

            Console.WriteLine($"The student has received a grade of {grade} for the score {score}.");

            

            if (score > 80)
            {
                grade = 'A';
                //Console.WriteLine(" The student has failed the exam.");
            }
            else if (score > 70)
            {
                grade = 'B';
                //Console.WriteLine("The student has received a grade of D.");
            }
            else if (score > 60)
            {

                grade = 'C';
                // Console.WriteLine("The student has received a grade of C.");
            }
            else if (score >= 50)
            {
                grade = 'D';
                //  Console.WriteLine("The student has received a grade of B.");
            }
            else
            {
                grade = 'F';
                //  Console.WriteLine("The student has received a grade of A.");
            }

            // out of if else nested structure

            Console.WriteLine($"The student has received a grade of {grade} for the score {score}.");
            
            
            //Example : SWITCH statement

            // Declaration of variables

            int dayNumber;

            // taking input from user

            Console.Write("Enter alphabet for color : ");
            //dayNumber = int.Parse(Console.ReadLine());
            char letterColor = char.Parse(Console.ReadLine());

            // using switch statement to display day of the week

            switch (letterColor)
            {
                case 'r':
                case 'R':
                    Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("RED");
                        break;
                case 'b':
                case 'B':
                    Console.WriteLine("BLACK");
                        break;
                case 'g':
                case 'G':
                    Console.WriteLine("GREEN");
                        break;
                case 'y':
                case 'Y':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("YELLOW");
                        break;

                        
                default:
                        Console.WriteLine("Invalid alphabet. No color specified.");
                        break;
            }

            
            // Example Switch 2

            int anyNumber;

            // taking input from user
            Console.Write("Enter a number between 1 and 10: ");
            anyNumber = int.Parse(Console.ReadLine());

            switch (anyNumber)
            {
                case int x when anyNumber < 5 && anyNumber > 0:
                    Console.WriteLine("The number is less than 5 and greater than 0.");
                    break;
                case int x when anyNumber >= 5 && anyNumber <= 10:
                    Console.WriteLine("The number is between 5 and 10.");
                    break;

            }
            

            // Example : Conditional Operator

            // Declaration of variables
            double num1, num2, maxNumber;

            // taking input from user

            Console.Write("Enter First Number.");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number.");
            num2 = double.Parse(Console.ReadLine());

            // maxNumber = (condition) ? value if condtion is true : value if condition is false
            maxNumber = (num2 > num1) ? num2 : num1;

            Console.WriteLine($"Maximum of {num1} and {num2} is : {maxNumber}");
            */

            //Calculator using Else if nested block OR using Switch statement

            // Declaration of Vaiables

            double num1, num2, result=0;// operands
            int choice;                 // number to determine operator choice

            // input from user

            Console.WriteLine(" Enter two numbers for binary operation ");
            Console.Write("num1 :");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("num2 :");
            num2 = double.Parse(Console.ReadLine());



            // prompt user to give choice for operation

            Console.WriteLine("Press 1 for ADDITION ");
            Console.WriteLine("Press 2 for SUBTRACTION ");
            Console.WriteLine("Press 3 for MULTIPLICATION ");
            Console.WriteLine("Press 4 for DIVISION ");
            Console.WriteLine();
            choice = int.Parse(Console.ReadLine());
            /*
            if (choice == 1)
            {
                result = num1 + num2;
            }
            else if (choice == 2)
            {
                result = num1 - num2;
            }
            else if (choice == 3)
            {
                result = num1 * num2;
            }
            else if (choice == 4)
            {
                result = num1 / num2;
            }
            */

            //SWITCH

            switch(choice)
            {
                case 1: result = num1 + num2;
                     break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine(" Enter operation choice between 1 to 4 only");
                    break;
            }

            Console.WriteLine($"For the selected operation on {num1} and {num2} the result is {result}");
        }
    }
}
