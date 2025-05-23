/*  * This is a simple C# program that converts Celsius to Fahrenheit.
 * It takes a temperature in Celsius as input and
 *  outputs the equivalent temperature in Fahrenheit.
 * Author: Baljeet Kaur
 * Last updated: May 23, 2025
 */


namespace CeciusToFarenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations

            double degreeCelsius, degreeFahrenheit;

            //Input
            Console.Write("Enter the temperature in Celsius: ");
            degreeCelsius = double.Parse(Console.ReadLine());

            //Conversion formula

            degreeFahrenheit = (degreeCelsius * 9 / 5) + 32;

            //Output

            Console.WriteLine(" Celsius is equal to :"+ degreeFahrenheit + "F");



        }
    }
}
