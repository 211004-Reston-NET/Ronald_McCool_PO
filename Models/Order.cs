using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        private List<LineItem> _lineItem;
        private Store _store;
        private Order _order;
        private decimal _price;
        private int _orderId;

        public Order() { }
        
        
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public int CustId { get; set; }
        public int StoreId { get; set; }

        public Customer Cust { get; set; }
        public Store Store { get; set; }
         public List<LineItem> LineItems { get; set; }
        
      


        public override string ToString()
        {
            return $"LineItems {LineItems}\nStoreLocation {Store}\nPrice {Price}";
        }
    }
}