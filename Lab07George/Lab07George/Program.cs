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

            Console.WriteLine("This is my collection of products.");

            //Console.WriteLine(Category.Electronics);

            Inventory<Product> myProducts = new Inventory<Product>()
            {
                soap,
                playstation
            };
            myProducts.Add(shampoo);

            myProducts.Remove(soap);

            foreach(Product p in myProducts)
            {
                Console.WriteLine(p.Name + " is a " + p.ProductType);
            }
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
 * Add at least 10 items to your List, and output them to the console. 
 * Add some items through the Add() Method, and others through a collection initializer */