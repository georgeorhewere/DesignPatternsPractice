using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ComputerProduct
    {

        private List<string> Specifications;
        public ComputerProduct()
        {
            Specifications = new List<string>();
        }

        public void Add(string spec)
        {
            Specifications.Add(spec);
        }

        public void Show()
        {
            Console.WriteLine($"Specifications ");
            foreach (var item in Specifications)
            {
                Console.WriteLine($"{Specifications.IndexOf(item) +1 }. {item}");
            }
        }


    }
}
