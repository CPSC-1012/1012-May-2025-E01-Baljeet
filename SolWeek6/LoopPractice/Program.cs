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
            

            // Example : print values from 1 to 100
            
            // declarations

            int i = 0; // intitialize loop variable

            while (i <= 100) // checking for condition
            {
                Console.WriteLine($" {i} ");
                i = i + 1;

            }
            
            for (int i = 1; i <= 100 ; i++)
            {
                Console.WriteLine($" {i} ");
            }

            */
            //Example : Calculate factorial of a given number using for loop
            /*
            // declaration

            int count, num, fact = 1;

            // input

            Console.Write(" Enter the number to calculate factorial");
            num = int.Parse(Console.ReadLine());
            count = num;// intialization of condition variable

            if (count == 1)
                fact = 1;

            for (int i = count; count > 1; count--) // intialization; ckecking condition; updating counter
            {
                fact = fact * count;
            }

            Console.WriteLine($" factorial value of {num} is: {fact}");

            */

            //Example : Calculate factorial of a given number using while loop
            /*
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

            */


            // example : Fibonacci dseries 1,1,2,3,5,8,13.....

            int f1 = 1, f2 = 2, f3=0;

            while (f3 <= 89)
            {
                f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                
                Console.WriteLine(f3);

            }


        }
    }
}
           
        
    