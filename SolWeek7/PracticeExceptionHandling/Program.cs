namespace PracticeExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int i = 5, j = 0;
            // error handling by code
            /*
            if (j != 0)
            {
                Console.WriteLine($" Result of {i} Divide by {j} is : {i / (double) j}");
            }
            else
            {
                Console.WriteLine("Can't Divide by Zero");
            }
            */

            // error handling by try catch block
            /*
            try
            {
                Console.WriteLine($" Result of {i} Divide by {j} is : {i / j}");
            }

            catch
            {
                Console.WriteLine("Can't Divide by Zero");
            }
            */
            // catch block for specific exception handling

            try
            {
                Console.WriteLine($" Result of {i} Divide by {j} is : {i / j}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
