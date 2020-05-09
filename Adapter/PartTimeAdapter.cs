using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PartTimeAdapter : Employee, IWeeklyWage
    {

        public PartTimeAdapter(string name, double montlyWage):base(montlyWage,name)
        {

        }

        public double GetWeeklyWage()
        {
            return GetMonthlyWage() / 4;
        }

        public string PrintWeeklyPaySlip()
        {
            return $"The weekly wage for {Name} : {GetWeeklyWage()}";
        }
    }
}
