using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ArrayListExample
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 40, 50, 60, 70, 2, 12, 56, 89, 78, 93 };
            //int[] arr1 = new int[] { 40, 50, 60, 70,2,12,56,89,78,93 };
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //list.Insert(1, 1.5);
            list.AddRange(arr);//Add Multiple Values at a Time
            //list.Remove(1.5);
           //list.RemoveAt(0);//Remove the element based on index
            //list.RemoveRange(2,3);
           // list.Clear();
            list.Sort();
            list.Reverse();
            Console.WriteLine("count(Total element"+list.Count);
            Console.WriteLine("Capacity "+list.Capacity);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
