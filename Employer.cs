using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1
{
    internal class Employer
    {
        public string Name { get; set; }
        public static List<Student> employees = new List<Student>();

        public Employer(string name)
        {
            this.Name = name;
        }

        public void AddEmployee(Student student)
        {
            employees.Add(student);
        }
    }
}
