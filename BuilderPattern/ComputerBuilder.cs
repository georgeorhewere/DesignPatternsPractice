using System;

namespace BuilderPattern
{
    public abstract class ComputerBuilder
    {
        protected string model;
        protected ComputerProduct product;

        public ComputerBuilder(string _model)
        {
            model = _model;
            product = new ComputerProduct();
        }
        public abstract void AddHardDisk();
        public abstract void AddRAM();
        public abstract void AddProcessor();
        public void GetSpecifications() {
            Console.WriteLine($"Model : {model}");
            product.Show();
        }

    }
}
