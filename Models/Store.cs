using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
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

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set;}
    }
}
