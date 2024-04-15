using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WS_8_OO
{
    internal class PartTimeEmployee : Employee
    {
        private int _hoursWorked;
        public PartTimeEmployee() : base()
        {
        }

        public PartTimeEmployee(string name, string gender, 
            double rate, int hoursWorked) : base(name, gender, rate)
        {
            HoursWorked = hoursWorked;
        }

        public int HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public override double CalcPay()
        {
            return HoursWorked * HourlyRate;

        }

        //public override double CalcTax()
        //{
        //    return HoursWorked * HourlyRate * .4;

        //}

        public override string ToString()
        {
            return base.ToString() + " Hourly Rate " + HourlyRate;
        }

    }
}
