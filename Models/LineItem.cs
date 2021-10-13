using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class LineItem
    {
         private Product _product;
        private int _quntity;
        public LineItem() { }
        public LineItem(Product product, int quntity)
        {

        }
        public Product Products { get; set; }
        public int Quantity { get; set; }
    }
}