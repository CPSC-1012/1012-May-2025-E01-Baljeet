using System.Xml.Serialization;

namespace ReadWriteToCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Declaration

            string firstName;
            string lastName;
            string id;
            string fileName;
            string choice;

            // 
            Console.WriteLine("Program to raad and write to a CSV file ");

            // input from user
            do
            {
                Console.Write(" Enter File Name: ");
                fileName = Console.ReadLine();

                Console.Write(" Enter First Name: ");
                firstName = Console.ReadLine();

                Console.Write(" Enter Last Name: ");
                lastName = Console.ReadLine();

                Console.Write(" Enter ID: ");
                id = Console.ReadLine();

                // Write record ito file

                // open a file with file name


                try
                {
                    StreamWriter writer = new StreamWriter(fileName, append: true);
                    writer.WriteLine($"{firstName},{lastName},{id}");
                    writer.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine($" File can't be opened: {e.Message} ");
                }

                Console.Write("Do you want to enter more records: Y or N");
                choice = Console.ReadLine();

            } while(choice.ToUpper() == "Y");
            
            
        }
    }
}
