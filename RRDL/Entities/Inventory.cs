using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Inventory
    {
        public int InvenId { get; set; }
        public int StoreId { get; set; }
        public int LineitemId { get; set; }

        public virtual Lineitem Lineitem { get; set; }
        public virtual Store Store { get; set; }
    }
}
