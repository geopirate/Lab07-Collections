using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab07George
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] product = new T[20];
        int counter = 0;

        // adds item and doubles the size of the array if full
        public void Add(T item)
        {
            if (counter == product.Length)
            {
                Array.Resize(ref product, product.Length * 2);
            }
            product[counter++] = item;
        }

        // removes and item and removes the hole from the array
        public void Remove(T item)
        {
            int removeAt = Array.IndexOf(product, item);
            
            bool remove = false;
            T[] newArray = new T[product.Length];

            for (int i = 0; i < counter; i++)
            {
                if(i == removeAt)
                {
                    remove = true;
                    Console.WriteLine($"Deleting requested product.");
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

        // iterates through the collection
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
