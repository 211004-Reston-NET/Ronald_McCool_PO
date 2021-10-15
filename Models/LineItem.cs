namespace Models
{
    public class LineItem
    {
         private Product _product;
        private int _quantity;
        public LineItem() { }
        public LineItem(Product product, int quntity)
        {
            _product=product;
            _quantity=quntity;
        }
        public Product Products { get; set; }
        public int Quantity { get; set; }
        
        public override string ToString()
        {
            return $"Product {_product} Quanity {_quantity}";
        }

    }
}