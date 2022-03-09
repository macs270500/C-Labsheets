using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Q1
{
    class clsStudent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }
        private string grade;
        public string CalcGrade()
        {
            double result = (Midterm + Final) / 2;
            switch (result)
            {
                case double rslt when (rslt >= 70):
                    grade = "A";
                    break;
                case double rslt when (rslt >= 60):
                    grade = "B";
                    break;
                case double rslt when (rslt >= 50):
                    grade = "C";
                    break;
                case double rslt when (rslt >= 40):
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            return grade;
        }
    }
}
