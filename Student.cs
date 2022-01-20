using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1
{
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
            Console.WriteLine("время на дорогу в университет у " + Name + " : " + timeOnRoad + " минут");
            return timeOnRoad;
        }

        //подсчет времени в пути в университет, если ходит пешком 
        public int TimeGettingToUniversityMin(int timeOnFoot)
        {
            int timeOnRoad = timeOnFoot + TimeForCoffeMin();
            Console.WriteLine("время на дорогу в университет (только пешком) у " + Name + " : " + timeOnRoad + " минут");
            return timeOnRoad;
        }
    }
}
