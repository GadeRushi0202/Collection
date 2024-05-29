using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class List_Product
    {
        protected int Id {  get; set; }
        protected string Name { get; set; }
        protected int Price { get; set; }

        static void Main(string[] args)
        {
            List<List_Product> Product = new List<List_Product>()
            {
                new List_Product {Id=1,Name="Iphone",Price=750000},
                new List_Product{Id=2,Name="Redmi",Price=6500},
                new List_Product{Id=3,Name="Keyboard",Price=500},
                new List_Product{Id=4,Name="Mouse",Price=400},
                new List_Product{Id=5,Name="Pen",Price=15}
            };

            Console.WriteLine("Product Price Less than 2000");
            foreach(var item in Product)
            {
                if(item.Price < 2000)
                {
                    Console.WriteLine($"{item.Id} : {item.Name}  : {item.Price}");
                }
            }
        }
    }
    
}
