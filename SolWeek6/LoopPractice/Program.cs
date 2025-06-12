namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int table, i=1; //initial value of iteration


            Console.Write("Which Number table you want to print : ");
            table = int.Parse(Console.ReadLine());

            while(i<=10) // final value of iteration
            {
                Console.WriteLine($" {table} * {i} = {table * i}");
                i = i + 1; //update iteration value

            }
            
*/
            // Example : print values from 1 to 100
            /*
            // declarations

            int i = 0; // intitialize loop variable

            while (i <= 100) // checking for condition
            {
                Console.WriteLine($" {i} ");
                i = i + 1;

            }
            */

            //Example : Calculate factorial of a given number

            // declaration

            int count, num, fact =1;

            // input

            Console.Write(" Enter the number to calculate factorial");
            num = int.Parse(Console.ReadLine());
            count = num ;// intialization of condition variable

            if (count == 1)
                fact = 1;
            else
            {
                while (count > 1) // ckecking condition
                {
                    fact = fact * count;
                    count = count - 1; // updation in condition variable
                    
                 //   Console.WriteLine($" factorial value of {count} is: {fact}");
                }

            }

            Console.WriteLine($" factorial value of {num} is: {fact}");

                


















        }
    }
}
