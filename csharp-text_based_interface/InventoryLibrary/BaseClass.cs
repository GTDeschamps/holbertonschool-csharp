using System;

namespace InventoryLibrary
{
    public abstract class BaseClass
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        protected BaseClass()
        {
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}
