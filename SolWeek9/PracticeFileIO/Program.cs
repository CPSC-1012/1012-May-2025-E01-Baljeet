namespace PracticeFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Program to read and write from a file 

            // start with writing some content to a file

            StreamWriter fileWriter = new StreamWriter("cpscEO1.txt");
            fileWriter.WriteLine("This is first attempt to write in a file");
            fileWriter.Close();

        }
    }
}
