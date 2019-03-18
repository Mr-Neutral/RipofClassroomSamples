using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6
{
    public class MenuItem
    {
        public MenuItem(int id, string item, decimal price)
        {
            Id = id;
            Item = item;
            Price = price;
        }

        public int Id { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
    }
}
