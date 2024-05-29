using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;   //Non-generic collections

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int [] arr = new int[] {4,5,6,7};
            ArrayList list = new ArrayList();
            list.Add(1);//0index
            list.Add(2);
            list.Add(3);

            list.Insert(1, 1.5);
            list.AddRange(arr);//add multiple values at a time
           *//* list.Remove(1.5);
            list.RemoveAt(0);//remove the elements based on index
            list.RemoveRange(2, 3);//remove multiple elements at once 
            list.Clear();//remove all elments*//*
          // list.Sort();
            list.Reverse();
            Console.WriteLine("Count (Total Element):-  "+list.Count);
            Console.WriteLine("Capacity"+list.Capacity);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }*/

            ///////////////Stack////////////////////
           /* Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            Console.WriteLine("Remove Top element"+stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }*/

            ///////////////////////Queue//////////////////
            /*Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

           queue.Dequeue();
            Console.WriteLine("First Element in thr queue"+queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }*/
            ///////////////HashTable/////////////////

            SortedList st = new SortedList();
            st.Add(".docx", "World File");
            st.Add(".xlsx", "Exel File");
            st.Add(".cs", "Source code");
            st.Add(".Html", "Web Page");
            st.Remove(".Html");
            foreach (DictionaryEntry item in st)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
