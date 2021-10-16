using System.Collections.Generic;
namespace Models
{
    public class Store
    {
        private string _name;
        private string _address;
        private List<Customer> _products;
        private List<Order> _orders;
        public Store() { }
        public Store(string name, string address, List<Customer> products, List<Order> orders)
        {
            _name=name;
            _address=address;
            _products=products;
            _orders=orders;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Customer> Products { get; set; }
        public List<Order> Orders { get; set;}
        public List<Customer> GetAllProduct(){
            return _products;
        }
        public List<Order> GetAllOrders(){
            return _orders;
        }
        public override string ToString()
        {
            return $"Name {_name} Address {_address} Product {_products} Oorder {_orders}";
        }
    }
}
