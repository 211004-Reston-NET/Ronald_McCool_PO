namespace Models
{
    public class LineItem
    {
         private Customer _product;
        private int _quantity;
        public LineItem() { }
        public LineItem(Customer product, int quntity)
        {
            _product=product;
            _quantity=quntity;
        }
        public Customer Products { get; set; }
        public int Quantity { get; set; }
        
        public override string ToString()
        {
            return $"Product {_product} Quanity {_quantity}";
        }

    }
}