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
            employer.AddEmployee(student1);
            
            
            

        }
    }
    
    

    
}
