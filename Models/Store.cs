using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Models
{
    public class Store
    {
        private string _name;
        private string _address;
        private List<Product> _products;
        private List<Order> _orders;
        public Store() { }
        public Store(string name, string address, List<Product> products, List<Order> orders)
        {
            _name=name;
            _address=address;
            _products=products;
            _orders=orders;
        }
        public string Name 
        { 
            get{return _name;} 
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")){
                    throw new System.Exception("Name cannot have numbers");
                }
                _name=value;
                
            } 
        }
        public string Address { get; set; }
        public List<Product> Products { get; set;}
        public List<Order> Orders { get; set; }

        
      
        public override string ToString()
        {
            return $"Name {Name}\nAddress {Address}\nProducts {Products}\nOrders {Orders}";
        }
    }
}
