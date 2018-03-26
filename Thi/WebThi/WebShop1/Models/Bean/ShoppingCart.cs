using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop1.Models.Bean
{
    public class ShoppingCart
    {
        public List<ItemCart> ListItem = new List<ItemCart>();
        public void Add(int id, string name,double price, int quantity)
        {
            bool check = false;
            foreach(var item in ListItem)
            {
                if (item.id == id)
                {
                    item.quantity += quantity;
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                ItemCart item = new ItemCart();
                item.id = id;
                item.name = name;
                item.price = price;
                item.quantity = quantity;
                ListItem.Add(item);
            }
        }
        public void Update(int id, int quantity)
        {
            foreach (var item in ListItem)
            {
                if (item.id == id)
                {
                    if (quantity != 0)
                        item.quantity = quantity;
                    else
                        ListItem.Remove(item);
                }
            }
        }
        public void Delete(int id)
        {
           for(int i = ListItem.Count - 1; i >= 0; i--)
            {
                if (ListItem[i].id == id)
                {
                    ListItem.Remove(ListItem[i]);
                }
            }
        }
        public int getQuantity()
        {
            int quantity = 0;
            foreach(var item in ListItem)
            {
                quantity += item.quantity;
            }
            return quantity;
        }
        public double getTotal()
        {
            double  Total = 0;
            foreach (var item in ListItem)
            {
                Total += item.getMoney();
            }
            return Total;
        }
    }
}