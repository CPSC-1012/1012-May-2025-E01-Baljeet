using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO.Enumeration;

namespace SampleAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sample prog to store datewise stock investment value  in a file


            // declaration

            //araay size

            const int MONTH_SIZE = 4;
            int count = 0;

            // array for date and stock investment

            string[] dates = new string [MONTH_SIZE];
            double[] sInvestment = new double [MONTH_SIZE];
            // variable requied in operation of application
            char option;
            string choice;
            // call method to display Main Menu

            DisplayMainMenu();

            do
            {

                // ask user to enter option

                option = char.Parse(Console.ReadLine());

                switch (option)
                {
                    case 'a':
                    case 'A':

                        count = AcceptUserData(sInvestment, dates);
                        Console.WriteLine($"User entered {count} records in temporary memory");
                        break;

                    case 's':
                    case 'S':
                        string fileName;
                        Console.Write("Enter filename");
                        fileName = Console.ReadLine();

                        SaveToFile(fileName, sInvestment, dates, count);
                        break;

                    default: break;

                }

                Console.Write("Do you want to continue Y or N");
                choice = Console.ReadLine();

            } while (choice.ToUpper() == "Y");


















            //METHODs

            /// Display Menu
            /// 
            static void DisplayMainMenu()
            {
                Console.WriteLine("[A]ccept user data to store in file");
                Console.WriteLine("[S]ave data to store in file");
                Console.WriteLine("[L]oad user data ");
                Console.WriteLine("[E]dit in file");

            }

            //Accept user data
            // check for year value between 0000-9999, month value between (1-12)

            static int AcceptUserData( double[] sInvestment, string[] dates)
            {
                int year = 0;
                int month = 0;
                int count = 0;
                string date= null;
                string selectedMonth = null;
                bool validYear = false;
                bool validMonth = false;

                string[] months = { "", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
                Console.Write(" Enter Year : ");


                while (validYear != true)
                {
                    year = int.Parse(Console.ReadLine());

                    if (year <= 0000 || year >= 9999)
                    { 
                        validYear = false;
                        Console.WriteLine(" Enter correct value for Year");

                    }
                    else
                    {
                        validYear = true;
                    }
                }
                
                Console.Write(" Enter Month : ");
                while (validMonth != true)
                {
                    month = int.Parse(Console.ReadLine());

                    if (month <= 0 || month >= 13)
                    {
                        validMonth = false;
                        Console.WriteLine(" Enter correct value for Month (1-12)");

                    }
                    else
                    {
                        validMonth = true;
                        selectedMonth = months[month];
                    }
                }

                Console.WriteLine($" user want to store data for year : {year} and Month : {selectedMonth}");

                for ( int i = 0; i < MONTH_SIZE; i++ )

                {
                    int day = i + 1;
                    double investment= 0;

                    Console.Write($"Enter the investment amount for day {day} ");
                    investment = double.Parse( Console.ReadLine() );
                    date = $"{year}-{selectedMonth}-{day}";
                    dates[i] = date ;
                    sInvestment[i] = investment ;
                    count ++;

                }

                return count;




                
            }

            // Saving data to file

            static void SaveToFile( string fileName, double[] sInvestment, string[] dates, int count)
            {
                const string HEADER = "Dates, Stock Investment";

                try
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    writer.WriteLine(HEADER);

                    for ( int i = 0; i < count ; i++ )
                    {
                        writer.WriteLine($"{dates[i]},{sInvestment[i]}");
                    }

                    writer.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" There is problem in opening the file {ex.Message}");
                }
                

            }




            // Loading data from file





        }
    }
}
