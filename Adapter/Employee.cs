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


        public double GetMonthlyWage()
        {
            return monthlyRate;
        }

        public string PrintMonthlyPaySlip()
        {
            return $"The monthly wage for {name} : {GetMonthlyWage()}";
        }
    }
}
