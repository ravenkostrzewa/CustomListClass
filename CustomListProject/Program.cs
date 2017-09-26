using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> list3 = new CustomList<int>();

            list1.Add(12);
            list1.Remove(12);

            list3 = list1 + list2;

            Console.ReadLine();
        }
    }
}
