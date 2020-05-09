using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PartTimeEmployee : IWeeklyWage
    {

        public string Name { get; set; }
        private double rate;

        public PartTimeEmployee(string name, double weeklyRate)
        {
            Name = name;
            rate = weeklyRate;
        }

        public double GetWeeklyWage()
        {
            return rate;
        }
    }
}
