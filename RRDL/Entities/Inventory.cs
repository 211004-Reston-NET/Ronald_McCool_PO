using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Inventory
    {
        public int? ProdId { get; set; }
        public int? StoreId { get; set; }
        public int? ProdQty { get; set; }

        public virtual Product Prod { get; set; }
        public virtual Store Store { get; set; }
    }
}
