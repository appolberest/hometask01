using System;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student() { Name = "Ben", Age = 18, IsLovingCoffe = true, ShcolarshipSizeUAH = 0, SalarySizeUSD = 350 };
            var employer = new Employer("Alexander");

        }
    }
    static class MyExtentions
    {

    }
    public class Student
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public uint ShcolarshipSizeUAH { get; set; }
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
            return timeOnRoad;
        }

        //подсчет времени в пути в университет, если ходит пешком 
        public int TimeGettingToUniversityMin(int timeOnFoot)
        {
            int timeOnRoad = timeOnFoot + TimeForCoffeMin();
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
    }
}
