using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        private List<LineItem> _lineItem;
        private string _storeLocation;
        private double _price;

        public Order() { }
        public Order(List<LineItem> lineItems, string storeLocation, double price)
        {
            _lineItem=lineItems;
            _storeLocation=storeLocation;
            _price=price;
        }
        public List<LineItem> LineItems { get; set; }
        public string StoreLocation { get; set; }
        public double Price { get; set; }
        public List<LineItem> GetAllLineItems(){
            return _lineItem;
        }
        public override string ToString()
        {
            return $"LineItems {_lineItem} StoreLocation {_storeLocation} Price {_price}";
        }
    }
}