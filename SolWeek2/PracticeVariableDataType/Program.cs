// This is a single line comment! It is for humans, Compile doesn't execute these statements
// This program is used to parctice different Data Types
// Author : Baljeet Kaur
// Last updated: 14th May 2015

/* This is also a comment: Multiline comment
              I'm still in the comment
              the comment can go on
              and on
              and on
*/


namespace PracticeVariableDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine is a method in C# used to print text or data to the console.
            //It's part of the System namespace,
            //WriteLine adds a newline after the output.

            Console.WriteLine("Welcome to CPSC1012: Programming Fundamentals");
            Console.WriteLine("This is our first program");
            Console.WriteLine();

            //Console.Write is used to write text to the console without appending a newline at the end.
            //The cursor remains at the end of line.
            //So, any next output would be displayed in the same line as previous output. 

            Console.Write("Output 1");
            Console.Write("Output 2 is printed on the same line as Output1");

            /* 
                \n creates a new line
                \t is "tab": this indents the output
                \" prints the " in output message
               
            */

            Console.Write("Hello, Baljeet Kaur \n");
            Console.Write("Hello, \" Baljeet Kaur \" \n ");
            Console.Write("Here is List of Classes:");
            Console.Write("Class 1: \t Class 2: \t  Class 3: ");

            //VARIABLES//
            /*  Variables are named storage locations in memory that hold data.
                They allow you to store, retrieve, and manipulate values during the execution of a program.
                To use a variable, you must first DECLARE it with a DATA TYPE and a NAME.

                Create a console application that takes input about a student’s details : 
                name, age, and marks in 4 subjects and calculates the average marks.
                Also display the percentage of marks.
                This example helps in practicing data types and type conversion

            // SEQUENCE:
            // declare variables Name, age, marks, total, average, percentage
            // ask the user to input their name, age, and marks in 4 subjects
            // calculate total marks
            // calculate their average marks 
            // display results with student information)

            /************* CODING TIME ************/
            // declare & assign variables

            /* string name = "Rayan";
            int age = 19,
                subjMark1 = 67,
                subjMark2 = 76,
                subjMark3 = 87,
                subjMark4 = 56,
                totalMarks;
            double averageMarks;
            double percMarks;
            bool isStudent= true;
            */

            string name;
            int age, subjMark1, subjMark2, subjMark3, subjMark4, totalMarks;
            double averageMarks, percMarks;
            bool isStudent = true;


            // take input from user
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your Subject 1 Marks: ");
            subjMark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Subject 2 Marks: ");
            subjMark2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Subject 3 Marks: ");
            subjMark3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Subject 4 Marks: ");
            subjMark4 = int.Parse(Console.ReadLine());

            // calculate total # of Marks
            totalMarks = subjMark1 + subjMark2 + subjMark3 + subjMark4;

            // calculate Average Marks
            // this line is doing integer division: will result into 0
            averageMarks = totalMarks / 4;

            Console.WriteLine(" 1. The average Marks stored by student is: " + averageMarks);


            // fix #1: incorporate a double into the equation
            averageMarks = totalMarks * 1.0 / 4;
            Console.WriteLine(" 2. The average Marks stored by student is: " + averageMarks);
            //OR
            averageMarks = totalMarks / 4.0;
            Console.WriteLine("3.  The average Marks stored by student is: " + averageMarks);

            // or fix #2: cast as a double
            averageMarks = (double)totalMarks / 4;

            Console.WriteLine(" 4. The average Marks stored by student is: " + averageMarks);

            //  results as a percent (not decimal)

            percMarks = averageMarks;

            Console.WriteLine();
            Console.WriteLine("Student Information:\nName: " + name + "\nAge: " + age
                                + "\nAverage Marks in 4 Subjects: " + averageMarks
                                + "\n Percentage of Marks: " + percMarks + "%");
            Console.WriteLine();

            // let's play around with the cast operator

            // let's try casting an int to a double
            int x = 21;
            Console.WriteLine("Interger x is :" + x);
            // typecast x as double

            double myDouble = (double)x;
            // this is a cast operator: it converts x to a double
            // the value of x is unchanged
            // the value of myDouble is 21.0
            // the type of myDouble is double

            Console.WriteLine("myDouble is double value of x " + myDouble);


            // let's try casting a double to an int
            int myInt = (int)21.7;
            Console.WriteLine("myInt is " + myInt);
            // ints cannot store decimals, so those values are lost

            // weird things can happen when we cast to a "smaller" data type: be careful!!!
            //typecasting an int to a byte requires an explicit cast,
            //because int (32-bit signed) has a much larger range than byte (8-bit unsigned).
            //This cast may result in data loss if the integer value is outside the range of a byte (0 to 255).

            int i = 300;
            byte b = (byte)i;  // Explicit cast
            Console.WriteLine(b); // Output: 44

            /*
             * Why Output is 44?
             * The value 300 exceeds the byte max value (255).
             * C# uses modulo 256 behavior for such casts:
             * 300 % 256 = 44
             * So the value wraps around and you get 44.
            */

            // other types of variables:

            char multipleChoice = '¿'; // can be letters, digits, punctuation, spaces....


        }
    }
}
