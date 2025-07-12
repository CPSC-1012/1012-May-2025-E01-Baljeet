using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SampleAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sample prog to store datewise stock investment value  in a file


            // declaration

            //araay size

            const int MONTH_SIZE = 31;

            // array for date and stock investment

            string[] dates = new string [MONTH_SIZE];
            double[] sInvestment = new double [MONTH_SIZE];
            // variable requied in operation of application
            char option;

            // call method to display Main Menu

            DisplayMainMenu();

            // ask user to enter option

            option = char.Parse (Console.ReadLine());

            switch(option)
            {
                case 'a':
                case 'A': AcceptUserData();
                    break;

                default: break;

            }




















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

            static void AcceptUserData()
            {
                int year = 0;
                int month = 0;
                string selectedMonth = null;
                bool validYear = false;
                bool validMonth = false;

                string[] months = { "", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
                Console.Write(" Enter Year : ");


                while (validYear != true)
                {
                    year = int.Parse(Console.ReadLine());

                    if (year <= 0000 && year >= 9999)
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

                    if (month <= 0 && month >= 13)
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
            }

            // Saving data to file





            // Loading data from file





        }
    }
}
