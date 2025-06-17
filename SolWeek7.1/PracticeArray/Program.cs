namespace PracticeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // array of string : days of week
            // array of double: marks of student

            string[] dayOfWeek = new string[7] { "MON", "TUES", "WED", "THUS", "FRI", "SAT", "SUN" };
            double [] marksOfStudent = new double[5] ;

            

            Console.WriteLine($"4th day of the week is : {dayOfWeek[3]} and the marks of 4th student is :  {marksOfStudent[3]}");


        }
    }
}
