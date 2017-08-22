using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Case_T4T_WebShop.cs
{
    public class Sandwich
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        

        public Sandwich(string name, string details, double price)
        {
            Name = name;
            Details = details;
            Price = price;            
        }
    }
}