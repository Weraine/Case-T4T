using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Case_T4T_WebShop.cs
{
    public class Sandwich
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        

        public Sandwich(int id ,string name, string details, double price)
        {
            Id = id;
            Name = name;
            Details = details;
            Price = price;            
        }
    }
}