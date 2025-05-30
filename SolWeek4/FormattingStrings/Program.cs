﻿/* We are going to practice different ways of formatting strings in C#.
 * This includes using string interpolation, composite formatting, and verbatim strings.
 * We will also explore the use of format specifiers and culture-specific formatting.
 */
using System;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormattingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Let's more about formatting strings");

            //Let’s say I have two variables, an int called firstNum and a double called secondNum:
            
            int firstNum = 150;
            double secondNum = 1234.56789;
            decimal thirdNum = 45678.90m;

            //I can display the numbers are they are stored, either manually:  
            
            Console.WriteLine("firstNum: " + firstNum + "  secondNum: " + secondNum + "thirdNum: " + thirdNum);
            Console.WriteLine();
            //Or using substitution parameters:  

            Console.WriteLine("firstNum: {0}  secondNum: {1}  thirdNum: {2}" , firstNum, secondNum, thirdNum);

           //Or with string interpolation:  

            Console.WriteLine($"firstNum: {firstNum}  secondNum: {secondNum} thirdNum: {thirdNum}");
            Console.WriteLine();
            //Adjusting number precision

            /*If I’m using string interpolation or substitution parameters, I can add a format string inside the braces,
               after a: symbol.
                For example, let’s say I want my first number to be four digits long, no decimals, and my second number
                to be 1 digit before the decimal and 2 digits after the decimal.i.e.The first number would be in the
                format 0000 and the second number would be in the format 0.00.
             */
            // substitution parameters: 

            Console.WriteLine("firstNum: {0:0000}  secondNum: {1:0.00}", firstNum, secondNum);
            
            // string interpolation: 
            
            Console.WriteLine($"firstNum: {firstNum:0000}  secondNum: {secondNum:0.00}");
            Console.WriteLine();
            // Adding colour

            /*Another option I have is to adjust the colour of the text that is printed to the Console. 
            I can change the colour of the text by changing ForegroundColor:
            And I can highlight text by changing BackgroundColor. 
            I can then go back to the default colours by using ResetColor.
            Here’s what it’ll look like all together.Try copying this to VS and viewing the output!
            */

            // the following line will change the text colour to red: 

            Console.ForegroundColor = ConsoleColor.Yellow;

            // if I didn't like red, there are a few other options. The list follows: 
            // Black, Blue, Cyan, DarkBlue, DarkCyan, DarkGray,  
            // DarkGreen, DarkMagenta, DarkRed, DarkYellow, 
            // Gray, Green, Magenta, Red, White, and Yellow. 

            // any Console.WriteLine will now be in red text. 
            
            Console.WriteLine("Like this one is YELLOW.");

            // I can also highlight the text, using this: 
            Console.BackgroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Now this line will be yellow with a cyan highlight. Beautiful.");

            // at any point, I can reset back to the default colours using: 
            
            Console.ResetColor();

            Console.WriteLine("Now this line is in my regular colours again.");
            Console.WriteLine();

            // EXAMPLE 2: Custom string formatting to display numbers
            // 

            int number = 123;
            double temprature = 23.5;
            decimal perMile = 0.25m;
            long phoneNumber = 1234567890;

            Console.WriteLine($"You number in the queue is {number:#}");
            Console.WriteLine($"You number in the queue is {number:0}");
            Console.WriteLine();

            Console.WriteLine($"The ride costs {perMile: #.##}");
            Console.WriteLine($"The ride costs {perMile: 0.00}");
            Console.WriteLine();

            Console.WriteLine($"Ticket Number : {number:######}");
            Console.WriteLine($"Ticket Number : {number:000000}");
            Console.WriteLine();


            Console.WriteLine($"The temprature is {temprature:#.00} F.");
            Console.WriteLine($"The temprature is {temprature:0.##} F.");
            Console.WriteLine();

            Console.WriteLine($"The phone number is : {phoneNumber:### - ### - ####}");
            Console.WriteLine($"The phone number is : {phoneNumber:(000) - 000 - 0000}");
            Console.WriteLine();

            Console.WriteLine($" Your balance is {1234567.89 / 2:#,###}");
            Console.WriteLine($" Your total is {123456789.29 :0,000.000}");














        }
    }
}
