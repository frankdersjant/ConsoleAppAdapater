using ConsoleAppAdapater.Models.Interfaces;
using System;

namespace ConsoleAppAdapater.Models
{
    public class Employee : IEmployee
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public double Salary { get; private set; }

        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Salary = salary;
        }

        public string FullName()
        {
            return lastName + " " + firstName;
        }

        public void PaySalary()
        {
            Console.WriteLine("Paying the Employee");
        }
    }
}
