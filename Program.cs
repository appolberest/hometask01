using System;
using System.Collections.Generic;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student() { Name = "Ben", Age = 18, IsLovingCoffe = true, ScholarshipSizeUSD = 0, SalarySizeUSD = 350 };
            student1.TimeGettingToUniversityMin(20, 30);
            uint salary1 = student1.StudentsSalary();
            Console.WriteLine("зарплата+стипендии: "+ salary1+" USD\n");
           

            var student2 = new Student() { Name = "Ann", Age = 19, IsLovingCoffe = false, ScholarshipSizeUSD = 200, SalarySizeUSD = 300 };
            student2.TimeGettingToUniversityMin(15);
            uint salary2 = student2.StudentsSalary();
            Console.WriteLine("зарплата+стипендии: " + salary2 + " USD\n");

            var employer = new Employer("Alexander");
            employer.AddEmployee();
            var employee = Employer.employees[0];
            employee.Name = "Yaroslav";
            employee.SalarySizeUSD = 500;
            Console.WriteLine("работник года - " + employee.Name + "\nзарплата работника года - " + employee.SalarySizeUSD);
            

        }
    }
    static class MyExtentions
    {
        public static uint StudentsSalary(this Student student)
        {
            return student.SalarySizeUSD + student.ScholarshipSizeUSD;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public uint ScholarshipSizeUSD { get; set; }
        public bool IsLovingCoffe { get; set; }
        public uint SalarySizeUSD { get; set; }

        private int TimeForCoffeMin()
        {
            return IsLovingCoffe ? 20 : 0;
        }
        //подсчет времени в пути в университет, если ходит пешком и едет на транспорте
        public int TimeGettingToUniversityMin(int timeOnFoot, int timeOnTransport)
        {
            int timeOnRoad = timeOnFoot + timeOnTransport + TimeForCoffeMin();
            Console.WriteLine("время на дорогу в университет у "+Name + " : "+timeOnRoad +" минут");
            return timeOnRoad;
        }

        //подсчет времени в пути в университет, если ходит пешком 
        public int TimeGettingToUniversityMin(int timeOnFoot)
        {
            int timeOnRoad = timeOnFoot + TimeForCoffeMin();
            Console.WriteLine("время на дорогу в университет (только пешком) у "+Name + " : " + timeOnRoad+" минут");
            return timeOnRoad;
        }
    }

    internal class Employer
    {
        private string Name { get; set; }
        public Employer(string name)
        {
            this.Name = name;
        }

        public static List<Student> employees = new List<Student>();
        public void AddEmployee() 
        {
            employees.Add(new Student());
        }
    }
}
