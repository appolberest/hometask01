using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1
{
    static class MyExtentions
    {
        public static uint StudentsSalary(this Student student)
        {
            return student.SalarySizeUSD + student.ScholarshipSizeUSD;
        }
    }
}
