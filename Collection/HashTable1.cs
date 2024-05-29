using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(".docx", "World File");
            ht.Add(".xlsx", "Exel File");
            ht.Add(".cs", "Source code");
            ht.Add(".Html", "Web Page");
            ht.Remove(".Html");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
