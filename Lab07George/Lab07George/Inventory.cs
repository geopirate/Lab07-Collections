using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07George
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] inventory = new T[20];
        int counter = 0;

        public void Add(T item)
        {
            if (counter == inventory.Length)
            {
                Array.Resize(ref inventory, inventory.Length * 2);
            }
            inventory[counter++] = item;
        }

        public void Remove(T item)
        {
            //inventory GetEnumerator()
            Console.WriteLine("Sorry Lynn, This is not removing anything.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return inventory[i];
            }
        }

        // calls the generic enumerator if the non-generic one is called
        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
