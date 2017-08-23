using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Case_T4T_WebShop.cs
{
    public class Order
    {
        public int Amount { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }

        public Order(int amount,string product,double price) {
            Amount = amount;
            Product = product;
            Price = price * amount;
        }
    }
}