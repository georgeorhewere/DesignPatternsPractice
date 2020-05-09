using Adapter;
using BuilderPattern;
using System;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practicing Design Patterns");
            // Builder
            //ComputerDirector director = new ComputerDirector();
            //director.Create();

            //Adapter
            Console.WriteLine("Adapter Pattern : Weekly / Monthly wager earners");
            IMonthlyWage earner = new Employee(45000, "James Dean");
            Console.WriteLine(earner.PrintMonthlyPaySlip());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Use Adapter for part time employee");          
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Sandra Bullock", 2300);
            earner = new EmployeeAdapter(partTimeEmployee);
            Console.WriteLine(earner.PrintMonthlyPaySlip());
            Console.WriteLine("--------------");

            Console.WriteLine("Use part time adapter for employee");
            PartTimeAdapter partTimeAdapter = new PartTimeAdapter("Frank Grimwall", 34768);
            IWeeklyWage weeklyEarner = partTimeAdapter;
            Console.WriteLine($"Wage from Interface : {weeklyEarner.GetWeeklyWage()}");
            Console.WriteLine($"Wage from Adapter : Weekly -> {partTimeAdapter.PrintWeeklyPaySlip()} Monthly -> {partTimeAdapter.GetMonthlyWage()}");
            Console.WriteLine("--------------");

            Console.ReadLine();
        }
    }
}
