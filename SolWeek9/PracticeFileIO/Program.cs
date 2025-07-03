namespace PracticeFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Program to read and write from a file 

            // start with writing some content to a file

            //StreamWriter fileWriter = new StreamWriter("D://NAIT/cpscEO1.txt");
           // fileWriter.WriteLine("This is my old attempt to write in a file");

           // StreamWriter fileWriter2 = new StreamWriter("E://NAIT/cpscEO2.txt");
           // fileWriter2.WriteLine("This is second attempt to write in a file");
           //fileWriter.Close();
          //  fileWriter2.Close();

            // reading from a file

            StreamReader fileReader = new StreamReader("D://NAIT/cpscEO1.txt");
            // StreamWriter fileWriter = new StreamWriter("D://NAIT/cpscEO1.txt");
            // fileWriter.WriteLine("This is my old attempt to write in a file");

            while (fileReader.EndOfStream == false)
            {
                string capturedData = fileReader.ReadLine();
                Console.WriteLine(capturedData);
            }
            fileReader.Close();
        }
    }
}
