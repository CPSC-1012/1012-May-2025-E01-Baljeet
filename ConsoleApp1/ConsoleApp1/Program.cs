namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "joan,coupling";
            // Console.WriteLine("Hello, World!");

            string subs1 = name.Substring(0, name.IndexOf(','));

            Console.WriteLine($" sunbstring value is : {subs1} ");
        }
    }
}
