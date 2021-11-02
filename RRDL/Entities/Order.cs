using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Order
    {
        public Order()
        {
            Lineitems = new HashSet<Lineitem>();
        }

        public int OrderId { get; set; }
        public decimal OrderPrice { get; set; }
        public int CustId { get; set; }
        public int StoreId { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Lineitem> Lineitems { get; set; }
    }
}
