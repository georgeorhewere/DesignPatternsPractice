using System;

namespace Adapter
{
    public class Employee : IMonthlyWage
    {
        private double monthlyRate;
        private string name;

        public Employee(double rate, string employeeName)
        {
            name = employeeName;
            monthlyRate = rate;
        }


        public double getMonthlyWage()
        {
            return monthlyRate;
        }

        public string printMonthlyPaySlip()
        {
            return $"The monthly wage for {name} : {getMonthlyWage()}";
        }
    }
}
