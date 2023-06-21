using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class Employee
    {
        public string name;
        public string employeeId;

        public Employee(string name, string employeeId)
        {
            this.name = name;
            this.employeeId = employeeId;

        }
    }

    internal class Manager : Employee 
    {
        public string department;
        public double salary;

        public Manager(string name, string employeeId, string department, double salary) : base(name, employeeId)
        {
            this.department = department;
            this.salary = salary;

        }
        public void EmployeeData()
        {
            Console.WriteLine($"Employee Name: {name}" +
                $" Id: {employeeId} " +
                $"Department: {department} " +
                $"Salary: {salary}");
        }
    }
}
