namespace Models
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;

        public Product() { }
        public Product(string name,double price,string description)
        {
            _name=name;
            _price=price;
            _description=description;

        }
        public string  Name { get; set; }
        public double  Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price} Description: {Description}";
        }
    }
}