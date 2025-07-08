namespace ReadingCSVusingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading from a CSV using Array");

            //declaration

            string fileName;
            int recordCount = 0;
            string record;



            //input

            Console.Write(" Enter name of file");
            fileName = Console.ReadLine();

            // open file for reading

            StreamReader reader = new StreamReader(fileName);

            while (reader.EndOfStream == false) // read till the pointer reaches to end of file
            {

                recordCount++;
                record = reader.ReadLine();

                Console.WriteLine($" Record : {recordCount}");
                Console.WriteLine("--------------------" );

                string[] fields = record.Split(','); // splits string into string of array

                for (int idx = 0;  idx < fields.Length ; idx++)
                {
                    Console.WriteLine($" Field {idx+1} : {fields[idx]}");
                }

            }


        }
    }
}
