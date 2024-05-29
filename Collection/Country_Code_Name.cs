using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Country_Code_Name
    {
        //Implement Country code And Country Name using Hastable
        static void Main(string[] args)
        {
            Hashtable Country = new Hashtable();
            Country.Add("+91", "India");
            Country.Add("105", "Pakistan");
            Country.Add("200", "England");
            Country.Add("150", "Japan");

            foreach(DictionaryEntry c in Country)
            {
                Console.WriteLine($"{c.Key}--> {c.Value}");
            }

        }
    }
}
