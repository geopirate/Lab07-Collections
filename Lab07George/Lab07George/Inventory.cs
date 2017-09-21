using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07George
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] product = new T[20];
        int counter = 0;

        public void Add(T item)
        {
            if (counter == product.Length)
            {
                Array.Resize(ref product, product.Length * 2);
                // int index = count * 2;
                // T[] extension = new T[index];
                // Array.Copy(students, extension, index);
                // students = extension;
            }
            product[counter++] = item;
            // students[counter] =student;
            // counter++;
        }

        public void Remove(T item)
        {
            Console.WriteLine($"Deleting {item}");
            int removeAt = Array.IndexOf(product, item);
            bool remove = false;
            T[] newArray = new T[product.Length];

            for (int i = 0; i < counter; i++)
            {
                if(i == removeAt)
                {
                    remove = true;
                }
                else if (remove)
                {
                    newArray[i - 1] = product[i];
                }
                else
                {
                    newArray[i] = product[i];
                }
            }
            product = newArray;
            counter--;
        }

        public void ViewAll()
        {
            /*foreach (Product p in this)
            {
                Console.WriteLine(p.Name + " is a " + p.ProductType);
            }
            Console.Read();*/
            


            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Thing {product[i].Name}");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return product[i];
            }
        }

        // calls the generic enumerator if the non-generic one is called
        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
