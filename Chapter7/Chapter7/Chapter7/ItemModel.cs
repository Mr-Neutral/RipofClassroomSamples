using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7
{
    public class ItemModel
    {
        public ItemModel(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
