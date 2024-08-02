using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Tags { get; set; }

        public Item(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
