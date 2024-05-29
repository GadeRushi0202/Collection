using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Dept_Id_Name
    {
        static void Main(string[] args)
        {
            SortedList Dept = new SortedList();
            Dept.Add("101", "Information Technology");
            Dept.Add("102", "Computer Engineering");
            Dept.Add("103", "Civil Engineering");
            Dept.Add("104", "Electric Engineering");

            foreach(DictionaryEntry D in Dept)
            {
                Console.WriteLine($"{D.Key}--> {D.Value}");
            }
        }
    }
}
