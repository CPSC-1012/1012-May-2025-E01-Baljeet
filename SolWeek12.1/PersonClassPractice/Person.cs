using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class_Example
{
    /// <summary>
    /// Represents a real person.
    /// </summary>
    internal class Person
    {

        /// <summary>
        /// Creates a person with emtpty string first name and last name, and
        /// an age of zero.
        /// </summary>
        public Person()
        {
            _firstName = "XXXXX";
            _lastName = "XXXXX";
            _age = 0;
        }

        /// <summary>
        /// Creates a person with the supplied first name, last name, and age
        /// </summary>
        /// <param name="firstName">Person first name</param>
        /// <param name="lastName">Person last name</param>
        /// <param name="age">Person age</param>
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Initialize here to avoid non-nullable warning in greedy constructor
        private string _firstName = "";
        private string _lastName = "";
        private int _age = 0;

        /// <summary>
        /// Used to set and get the person's first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new Exception("First name cannot be empty.");
                }
                _firstName = value;
            }
        }

        /// <summary>
        /// Used to set and get the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if(value == null || value.Length == 0)
                {
                    throw new Exception("Last name cannot be empty.");
                }
                _lastName = value;
            }
        }

        /// <summary>
        /// Used to set and get the person's age
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
                _age = value;
            }
        }
    }
}
