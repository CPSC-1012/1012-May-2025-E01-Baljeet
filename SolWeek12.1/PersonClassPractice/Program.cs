using Person_Class_Example;

namespace PersonClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person bob = new Person(); // instantiate a new person using default constructor
            Person sally = new Person("Sally", "Anne", 23); // instantiate a new person using greedy constructor

            bob.FirstName = "Bob";
            bob.LastName = "Dole";
            bob.Age = 30;

            Console.WriteLine($"{bob.FirstName} {bob.LastName} is {bob.Age} years old.");
            Console.WriteLine($"{sally.FirstName} {sally.LastName} is {sally.Age} years old.");
        }
    }
}
