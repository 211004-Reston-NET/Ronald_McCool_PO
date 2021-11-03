using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Lineitem
    {
        public int LineitemId { get; set; }
        public int LineitemQty { get; set; }
        public int ProdId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Prod { get; set; }
    }
}
