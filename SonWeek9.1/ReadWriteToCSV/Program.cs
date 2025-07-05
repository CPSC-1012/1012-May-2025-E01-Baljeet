using System.Xml.Serialization;

namespace ReadWriteToCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Declaration
            /* Writing to file 
             
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
            
            */


            // reading from a file
            // declaration

            string fileName, record;
            int recordCount = 0;
            int fieldCount = 0;

            // input

            Console.Write("Enter file name: ");
            fileName = Console.ReadLine();

            // open the file for reading

            StreamReader reader = new StreamReader(fileName);

            // read from file till the end of file

            while (reader.EndOfStream == false)
            {
                recordCount++;                      // recordCount += 1
                record = reader.ReadLine();
                Console.WriteLine($" Record {recordCount} ");
                Console.WriteLine($" =========================== ");
                // display the record with field number
                Console.WriteLine(record);
               /*
                while (record.Length > 0 )
                {
                    fieldCount++;

                    Console.WriteLine($" field {fieldCount} : {record.Substring(0,record.IndexOf(','))}");
                }
               */
            }


        }
    }
}
