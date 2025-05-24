/*  * This is a simple C# program that converts Celsius to Fahrenheit.
 * It takes a temperature in Celsius as input and
 *  outputs the equivalent temperature in Fahrenheit.
 * Author: Baljeet Kaur
 * Last updated: May 23, 2025
 */

namespace CelsiusToFahrenheit
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

            degreeFahrenheit = degreeCelsius * 9 / 5 + 32;

            //Output

            Console.WriteLine(degreeCelsius+" Celsius is equal to :"+ degreeFahrenheit + "F");
            // sring interpolation variable substitution
            Console.WriteLine($"{degreeCelsius} Celsius is equal to : {degreeFahrenheit} F ");
            // string interpolation expression substitution
            Console.WriteLine($"{degreeCelsius} Celsius is equal to : {degreeCelsius * 9 /5  +32} F ");

            //// Calculate HYPOTENUSE of a right triangle
            ///
            // declare variables

            double baset, height, hypotenuse;
            // input  and width
            Console.Write("Enter the Base of the right triangle: ");
            baset = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the right triangle: ");
            height = double.Parse(Console.ReadLine());

            // calculate hypotenuse using Pythagorean theorem
            hypotenuse = Math.Sqrt(baset * baset + height * height);

            // output the result
            Console.WriteLine("The hypotenuse of the right triangle is: " + hypotenuse);
            // string interpolation variable substitution
            Console.WriteLine($"The hypotenuse of the right triangle is: {hypotenuse}");
            // string interpolation expression substitution
            Console.WriteLine($"The hypotenuse of the right triangle is: {Math.Sqrt(baset * baset + height * height)}");
        }
    }
}
