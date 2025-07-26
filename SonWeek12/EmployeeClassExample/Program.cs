namespace EmployeeClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Employee Class Example");
            // Declaration

            int id, age;
            string fName, lName, department;
            Employee e1 = new Employee(1,"Baljeet", "Kaur", 35, "DMIT");
            Employee e2 = new Employee(1, "Jon", "Deago", 45, "JRShaw");

            Console.Write(" Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.Write(" Enter Age");
            age = int.Parse(Console.ReadLine());

            Console.Write(" Enter fName");
            fName = Console.ReadLine();

            Console.Write(" Enter lName");
            lName = Console.ReadLine();

            Employee e3 = new Employee(id,  fName, lName, age, "DMIT");

            e1.DisplayEmployee();
            e2.DisplayEmployee();
            e3.DisplayEmployee();


            
        }
    }
}
