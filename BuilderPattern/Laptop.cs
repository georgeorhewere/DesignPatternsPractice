using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Laptop : ComputerBuilder
    {

        public Laptop(string model): base(model)
        {
            
        }
        public override void AddHardDisk()
        {
            product.Add("SSD : 500GB");
        }

        public override void AddProcessor()
        {
            product.Add($"Intel Core i9-9900K" +
                    " 8-Core CPU 16-Threads"); 
        }

        public override void AddRAM()
        {
           
            product.Add("DDR4 RAM : 16GB");
        }
    }
}
