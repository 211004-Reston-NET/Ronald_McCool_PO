using System;
using System.Collections.Generic;

#nullable disable

namespace RRDL.Entities
{
    public partial class Product
    {
        public Product()
        {
            Lineitems = new HashSet<Lineitem>();
        }

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal? ProdPrice { get; set; }
        public string ProdDesc { get; set; }

        public virtual ICollection<Lineitem> Lineitems { get; set; }
    }
}
