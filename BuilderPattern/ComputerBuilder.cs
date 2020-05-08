using System;

namespace BuilderPattern
{
    public abstract class ComputerBuilder
    {
        protected string model;
        private ComputerProduct product;

        public ComputerBuilder(string _model)
        {
            model = _model;
            product = new ComputerProduct();
        }
        public abstract void AddHardDisk();
        public abstract void AddRAM();
        public abstract void AddProcessor();
        public ComputerProduct GetProduct() {
            return product;
        }

    }
}
