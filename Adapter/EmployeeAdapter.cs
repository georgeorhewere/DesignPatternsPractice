using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class EmployeeAdapter : IMonthlyWage
    {
        private PartTimeEmployee employee;
        public EmployeeAdapter(PartTimeEmployee _employee)
        {
            employee = _employee;
        }

        public double GetMonthlyWage()
        {
            return employee.GetWeeklyWage() * 4;
        }

        public string PrintMonthlyPaySlip()
        {
            Console.WriteLine($"Part Time Adapter : Weekly wage {employee.GetWeeklyWage()}");
            return $"The monthly wage for {employee.Name} : {GetMonthlyWage()}";
        }
    }
}
