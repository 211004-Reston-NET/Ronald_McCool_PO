using System;
using System.Collections.Generic;
namespace Models
{
    public class LineItem
    {
        private Product _product;
        private Order _order;
        private int _quantity;
        
        public LineItem(){}
        public LineItem(Product product, int quntity, List<LineItem> lineItemList)
        {
            _product=product;
            _quantity=quntity;
        }



        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public int ProId{ get; set; }
        public int OrdrId { get; set; }
        public virtual  Order  order { get; set; }
        public virtual Product Products { get; set; }
        
        
        public override string ToString()
        {
            return $"LineItemID {LineItemId}\nQuanity {Quantity}\nProductId {ProId}\nOrderId {OrdrId}";
        }

    }
}