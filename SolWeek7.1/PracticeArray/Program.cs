namespace PracticeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            */
            const int ARRAY_SIZE = 10;

            string[] studentNames = new string[ARRAY_SIZE] { "Shane", "Alex", "Adam", "Pamela", "Catherine", "Hushly", "Remy", "Jerry", "A","b" }; ;
            int[] studentID = new int[ARRAY_SIZE];

            for (int i = 0; i <= (ARRAY_SIZE -1) ; i++)
            {
                Console.WriteLine($"Enter student ID {i} : ");
                studentID[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($" Enter student Name {i} ;");
                studentNames[i] = Console.ReadLine();
            }

           
  
        }
    }
}
