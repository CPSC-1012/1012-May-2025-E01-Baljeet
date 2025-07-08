using System.Security.Cryptography.X509Certificates;
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
                Console.WriteLine($" ----------------------- ");
                // display the record with field number
                //Console.WriteLine(record);




                while (record.Length > 0)
                {
                    fieldCount++;

                    ///  checking for presence of "," , in absence of , display the whole record as it is the last part of the record
                    if (record.IndexOf(',') < 0)
                    {
                        Console.WriteLine($" field {fieldCount} : {record}");
                        record = "";
                    }
                    else
                    {


                        string f1;
                        f1 = record.Substring(0, record.IndexOf(','));
                        Console.WriteLine($" field {fieldCount} : {f1}");
                        record = record.Remove(0, record.IndexOf(',') + 1);
                    }
                }


            }
        }
    }
}
