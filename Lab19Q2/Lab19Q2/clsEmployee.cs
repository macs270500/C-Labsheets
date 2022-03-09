using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Q2
{
    class clsEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double PayRate { get; set; }
        public double HrsWrkd { get; set; }

        public double GrossPay()
        {
            double grosspay = 0;
            if (HrsWrkd > 40)
            {
                grosspay = (40 * PayRate) + ((HrsWrkd - 40) * (PayRate * 1.5));
            }
            else
            {
                grosspay = HrsWrkd * PayRate;
            }
            return grosspay;
        }
    }
}
