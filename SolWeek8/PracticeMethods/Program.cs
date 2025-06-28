using System.ComponentModel;

namespace PracticeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ///Example : Calculator Methods 
            ///
            double a , b, result=0;
            int choice;
            char option;

            //input
            do
            {
                Console.Write(" Enter two values for operation : ");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(" Press 1 for addition");
                Console.WriteLine(" Press 2 for subtraction");
                Console.WriteLine(" Press 3 for Multiplication");
                Console.WriteLine(" Press 4 for Division");
                Console.WriteLine(" Press 5 to update the value of variables");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        result = Addition(a, b);
                        break;
                    case 2:
                        result = Subtraction(a, b);
                        break;
                    case 3:
                        result = Multiplication(a, b);
                        break;
                    case 4:
                        result = Division(a, b);
                        break;
                   /* case 5:
                        VarUpdate(a,  b); // call by value
                        break;
                   */
                    case 5:
                        VarUpdate(ref a,ref b); // call by reference
                        break;
                    default:
                        Console.WriteLine("Please enter value between 1 - 4 ");
                        break;

                }

                Console.WriteLine($" For operation {choice} on input values {a} , {b} the result is : {result}");

                Console.WriteLine("do you want to continue: Y or N ");
                option = char.Parse(Console.ReadLine());

            }while ( option == 'Y' || option == 'y');

            double Addition (double x, double y)
            { 
                return (x + y);
            }

            double Subtraction(double x, double y)
            {
                return (x - y);

            }

            double Multiplication(double x, double y)
            {
                return (x * y);
            }

            double Division(double x, double y)
            {
                return (x / y);
            }

            void VarUpdate (ref double x,ref double y)
            {
                x = x + 5; 
                y = y + 5;

            }
        }
    }
}
