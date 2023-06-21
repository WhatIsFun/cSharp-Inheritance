using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Inheritance
{
    internal class Person
    {
        public string name;
        public int age;

        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

    }
    internal class Student : Person
    {
        public int studentId;
        public string major;
        public Student(string name, int age, int studentId, string major) : base(name, age)
        {
            this.studentId = studentId;
            this.major = major;
        }
        public void PrintData()
        {
            Console.WriteLine($"Student name: {name}, Age: {age}, Student ID: {studentId}, Student Major: {major}");
        }
    }
}
