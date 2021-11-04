using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Lineitem
    {
        public Lineitem()
        {
            Inventories = new HashSet<Inventory>();
            OrdersLineitems = new HashSet<OrdersLineitem>();
        }

        public int LineitemId { get; set; }
        public int LineitemQty { get; set; }
        public int ProdId { get; set; }
        public int OrderId { get; set; }

        public virtual Product Prod { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<OrdersLineitem> OrdersLineitems { get; set; }
    }
}
