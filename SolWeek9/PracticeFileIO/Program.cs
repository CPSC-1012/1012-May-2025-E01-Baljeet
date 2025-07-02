namespace PracticeFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Program to read and write from a file 

            // start with writing some content to a file

            StreamWriter fileWriter = new StreamWriter("D://NAIT/cpscEO1.txt");
            fileWriter.WriteLine("This is my new attempt to write in a file");

            StreamWriter fileWriter2 = new StreamWriter("E://NAIT/cpscEO2.txt");
            fileWriter2.WriteLine("This is second attempt to write in a file");
           fileWriter.Close();
            fileWriter2.Close();

        }
    }
}
