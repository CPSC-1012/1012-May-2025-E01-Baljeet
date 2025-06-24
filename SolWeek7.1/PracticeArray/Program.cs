namespace PracticeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // array of string : days of week
            // array of double: marks of student
            /*
            string[] dayOfWeek = new string[7] { "MON", "TUES", "WED", "THUS", "FRI", "SAT", "SUN" };
            double [] marksOfStudent = new double[5] ;

            

            Console.WriteLine($"4th day of the week is : {dayOfWeek[3]} and the marks of 4th student is :  {marksOfStudent[3]}");
            const int ARRAY_SIZE = 10;
            int[] someNumbers = new int[ARRAY_SIZE];
            Random keygen = new Random();

            for (int index = 0; index < someNumbers.Length; index++)
            {
                someNumbers[index] = keygen.Next(1, 11);
            }
            
            const int ARRAY_SIZE = 5;

            string[] studentNames = new string[ARRAY_SIZE];// { "Shane", "Alex", "Adam", "Pamela", "Catherine" }; 
            int[] studentID = new int[ARRAY_SIZE];

            for (int i = 0; i <= (ARRAY_SIZE -1) ; i++)
            {
                Console.Write($"Enter student ID {i} : ");
                studentID[i] = int.Parse(Console.ReadLine());
                Console.Write($" Enter student Name {i} ; ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

            }

            /// array loop for printing the elements 
            /// 
            for (int j = 0; j < studentNames.Length; j++)
            {
                Console.WriteLine($" Student ID is {studentID[j]}, and the student name is : {studentNames[j]}");
            }

            */

            string[] monthNames = new string[] { null, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int monthNumber;
            Console.WriteLine(monthNames.Length);

            Console.Write("Enter the number of the Month");
            monthNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"For Month number {monthNumber} name is : {monthNames[monthNumber]}");


        }
    }
}
