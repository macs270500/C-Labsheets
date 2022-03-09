using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class clsEmployee
    {
        public struct Employee
        {
            public int EmpID;
            public string EmpName;
            public string EmpCategory;
            public DateTime timeIn;
            public DateTime timeOut;
            public double SalaryPerHr;
            public double SalaryPerDay;
        }
        public static Employee[] EmpArray = new Employee[15];
        public static bool EmpBool = false;
        public static int EmpIndex = 10;
    }
}
