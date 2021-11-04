using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Store
    {
        public Store()
        {
            Inventories = new HashSet<Inventory>();
            Orders = new HashSet<Order>();
        }

        public int StoreId { get; set; }
        public string StoreAddress { get; set; }
        public string StoreName { get; set; }
        public decimal Moneytraker { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
