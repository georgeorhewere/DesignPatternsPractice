using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ComputerDirector
    {
        


        public void Create()
        {
            ComputerBuilder builder = new Laptop($"HP");
            builder.AddHardDisk();
            builder.AddRAM();
            builder.AddProcessor();
            builder.GetSpecifications();
            Console.WriteLine("-----------");
            
            builder = new Desktop("Dell");
            builder.AddHardDisk();
            builder.AddRAM();
            builder.AddProcessor();
            builder.GetSpecifications();
            Console.WriteLine("-----------");
        }
    }
}
