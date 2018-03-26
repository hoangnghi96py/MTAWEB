using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop1.Models.Bean
{
    public class ItemCart
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double getMoney()
        {
            return quantity * price;
        }
    }
}