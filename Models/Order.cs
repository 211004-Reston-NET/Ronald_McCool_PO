using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        }
        public List<LineItem> LineItems { get; set; }
        public string StoreLocation { get; set; }
        public double Price { get; set; }
    }
}