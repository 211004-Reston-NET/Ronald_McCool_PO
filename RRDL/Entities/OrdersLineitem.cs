using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class OrdersLineitem
    {
        public int OrderLineitem { get; set; }
        public int OrderId { get; set; }
        public int LineitemId { get; set; }

        public virtual Lineitem Lineitem { get; set; }
        public virtual Order Order { get; set; }
    }
}
