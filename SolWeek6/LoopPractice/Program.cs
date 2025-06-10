namespace LoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int table, i=1; //initial value of iteration


            Console.Write("Which Number table you want to print : ");
            table = int.Parse(Console.ReadLine());

            while(i<=10) // final value of iteration
            {
                Console.WriteLine($" {table} * {i} = {table * i}");
                i = i + 1; //update iteration value

            }
            

        }
    }
}
