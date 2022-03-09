using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Q1
{
    class CalcSemGrade
    {
        private string _name;
        private int _id;
        private double _midterm;
        private double _final;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public double MidTerm
        {
            get
            {
                return _midterm;
            }
            set
            {
                _midterm = value;
            }
        }

        public double Final
        {
            get
            {
                return _final;
            }
            set
            {
                _final = value;
            }
        }

        public string CalSemGrade()
        {
            double grade = (_midterm + _final) / 2;
            string result;
            switch (grade)
            {
                case double mk when (mk >= 70):
                    result = "A";
                    break;
                case double mk when (mk >= 60):
                    result = "B";
                    break;
                case double mk when (mk >= 50):
                    result = "C";
                    break;
                case double mk when (mk >= 40):
                    result = "D";
                    break;
                default:
                    result = "F";
                    break;
            }
            return result;
        }
    }
}
