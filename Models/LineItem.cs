using System;
using System.Collections.Generic;
namespace Models
{
    public class LineItem
    {
        private Product _product;
        private int _quantity;
        
        public LineItem(){}
        public LineItem(Product product, int quntity, List<LineItem> lineItemList)
        {
            _product=product;
            _quantity=quntity;
        }
        public string Products { get; set; }
        public int Quantity { get; set; }
        
        public override string ToString()
        {
            return $"Product {Products}\nQuanity {Quantity}";
        }

    }
}