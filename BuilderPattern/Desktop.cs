using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Desktop : ComputerBuilder
    {

        public Desktop(string model):base(model)
        {

        }

        public override void AddHardDisk()
        {
            product.Add("HDD : 1TB");
        }

        public override void AddProcessor()
        {
            product.Add($"AMD Ryzen 9 3900X" +
                        $"12-Core CPU 24-Threads");
        }

        public override void AddRAM()
        {
            product.Add(" DDR3 RAM : 20GB");
        }
    }
}
