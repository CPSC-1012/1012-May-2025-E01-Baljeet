namespace EmployeeClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Employee Class Example");
            // Declaration

            Employee e1 = new Employee(1,"Baljeet", "Kaur", 35, "DMIT");
            Employee e2 = new Employee(1, "Jon", "Deago", 45, "JRShaw");

            e1.DisplayEmployee();
            e2.DisplayEmployee();


            
        }
    }
}
