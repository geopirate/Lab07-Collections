using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07George
{
    class Product
    {
        public Category ProductType { get; set; }
        public String Name { get; set; }
        public String Color { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public void Buy()
        {
            Console.WriteLine("${Name} sold!");
        }
    }

    enum Category
    {
        Housewares,
        Hardware,
        Electronics,
        Grocery,
        Cosmetics
    }
}
