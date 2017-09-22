using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomListProject
{
    public class CustomList<T>
    {
        T[] items;
        int capacity;
        int count;
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 5;
            items = new T[capacity];
        }
        public void Add(T item)
        {
            if (count > capacity / 2)
            {
                doubleArraySize();
            }
            items[count] = item;
            count++;
        }

        private void doubleArraySize()
        {
            //Make a new array double the size of the original 
            //Transfer all the items from the old array to the new array
            //replace the old array with the new array
            // Your array's name is items
            T[] newArray;
            capacity = capacity * 2;
            newArray = new T[capacity];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
        public bool Remove(T item)
        {
            return false;
        }
    }
}

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(4);
    //        Numbers.Add(7);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(9);
    //        Numbers.Add(4);
    //        Numbers.Add(10);
    //        Numbers.Add(13);
    //        Numbers.Add(2);
    //        Numbers.Add(0);
    //        Numbers.Add(6);
    //        Numbers.Add(3);
    //        Numbers.Add(17);
    //        Numbers.Add(5);
    //        Numbers.Add(19);
    //        Numbers.Add(12);
    //        Numbers.Add(7);
    //        Numbers.Add(8);
    //        Numbers.Add(14);
    //        Numbers.Add(1);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(-5);
    //    }
        
    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(.19);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<string> Letters = new List<string>();
    //        Letters.Add("x");
    //        Letters.Add("y");
    //        Letters.Add("z");
    //    }

    //    public void Remove(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(8);
    //        Numbers.Add(11);
            
    //        Numbers.Remove(8);
    //        Numbers.Remove(11);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(.19);

    //        Numbers.Remove(.19);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(-.1);
    //        Numbers.Add(-.6);

    //        Numbers.Remove(-.6);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<int> Numbers = new List<int>();
    //        Numbers.Add(-4.6);
    //        Numbers.Add(-.3);
    //        Numbers.Add(-.05);

    //        Numbers.Remove(-4.6);
    //        Numbers.Remove(-.3);
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<string> Letters = new List<string>();
    //        Letters.Add("q");
    //        Letters.Add("y");

    //        Letters.Remove("q");
    //    }

    //    public void Add(T item)
    //    {
    //        items = new T[];
    //        List<string> LettersAndNumbers = new List<string>();
    //        LettersAndNumbers.Add("4");
    //        LettersAndNumbers.Add("7");
    //        LettersAndNumbers.Add("k");
    //        LettersAndNumbers.Add("i");

    //        LettersAndNumbers.Remove("4");
    //        LettersAndNumbers.Remove("7");
    //        LettersAndNumbers.Remove("k");
    //    }
    //}
        
