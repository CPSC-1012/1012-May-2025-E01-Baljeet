using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassExample
{
    internal class Employee
    {

        // Data members

        private int _empID;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _department;

        // Methods

        public void DisplayEmployee()
        {
            Console.WriteLine($"Name of Employee is : {_firstName} , {_lastName}");

        }
        // constructor
        public Employee(int empID, string firstName, string lastName, int age, string department)
        {
            _empID = empID;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _department = department;

        }




    }
}
