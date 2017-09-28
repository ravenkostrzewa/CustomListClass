using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] items;
        int capacity;
        int count;
        public int Count { get; set; }
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
                DoubleArraySize();
            }
            items[count] = item;
            count++;
        }

        private void DoubleArraySize()
        {
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
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    while (i < count)
                    {
                        items[i] = items[i + 1];
                        i++;
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i];
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            {
                for (int i = 0; i < list1.count; i++)
                {
                    newList.Add(list1[i]);
                }
                for (int i = 0; i < list2.count; i++)
                {
                    newList.Add(list2[i]);
                }
                return newList;
            }
        }

        public static CustomList<T> operator -(CustomList<T> List1, CustomList<T> List2)
        {
            CustomList<T> List3 = new CustomList<T>();
            int i;
            {
                for (i = 0; i <= List1.count; i++)
                    if (List2[0].Equals(List1[i]))
                        {
                            List1.Remove(List2[0]);
                        }
            }
            return List1;
            {
                for (i = 0; i <= List1.count; i++)
                    if (List2[1].Equals(List1[i]))
                    {
                        List1.Remove(List2[1]);
                    }
            }
            return List3;
        }

        public CustomList<T> ZipTwoListsTogether(CustomList<T> zipList1)
        {           
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < count; i++)
            {
                newList.Add(items[i]);
                newList.Add(zipList1[i]);
            }           
                return newList;
        }
    }
}