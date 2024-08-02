using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
	public class User : BaseClass
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
