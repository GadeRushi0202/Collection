using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class SortedList1
    {
        static void Main(string[] args)
        {
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
