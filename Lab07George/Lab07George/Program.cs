using System;

namespace Lab07George
{
    class Program
    {
        static void Main(string[] args)
        {
            // all my product objects
            Product soap = new Product("soap") { ProductType = Category.Cosmetics };
            Product playstation = new Product("playstation") { ProductType = Category.Electronics };
            Product shampoo = new Product("shampoo") { ProductType = Category.Cosmetics };
            Product broom = new Product("broom") { ProductType = Category.Housewares };
            Product mop = new Product("mop") { ProductType = Category.Housewares };
            Product towel = new Product("towel") { ProductType = Category.Housewares };
            Product apple = new Product("apple") { ProductType = Category.Grocery };
            Product melon = new Product("melon") { ProductType = Category.Grocery };
            Product xbox = new Product("xbox") { ProductType = Category.Electronics };
            Product hammer = new Product("hammer") { ProductType = Category.Hardware };
            Product screwdriver = new Product("screwdriver") { ProductType = Category.Hardware };

            Console.WriteLine("This is my collection of products.");

            Inventory<Product> myProducts = new Inventory<Product>()
            {
                soap,
                playstation,
                xbox,
                hammer,
                screwdriver,
                apple,
                melon
            };
            myProducts.Add(shampoo);
            myProducts.Add(broom);
            myProducts.Add(mop);
            myProducts.Add(towel);

            foreach (Product p in myProducts)
            {
                Console.WriteLine(p.Name + " is a " + p.ProductType);
            }

            myProducts.Remove(soap);

            myProducts.ViewAll();

            Console.Read();
        }
    }
}
/* 
 * * Create a custom generic list for an e-commerce store to hold their inventory of products 
 * * Hint: Your generic collection should be Inventory<Product>
 * * Include an enum in your Product
 * * Make sure the generic has the functionality to use a foreach loop.
 * Your generic collection should Add(), Remove() items in the collection
 * Stretch - if there is time, make it so you can ViewAll and create a method to output all items to the console
 * * Add at least 10 items to your List, and output them to the console. 
 * * Add some items through the Add() Method, and others through a collection initializer */