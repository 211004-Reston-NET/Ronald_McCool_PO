using System;
using System.Collections.Generic;

namespace Models
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _ph;
        private List<Order> _listOrders;

        public Customer() { }
        public Customer(String name, string address, string ph, List<Order> listOrder)
        {
            _name=name;
            _address=address;
            _ph=ph;
            _listOrders=listOrder;

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    
      
        public override string ToString()
        {
            return $"Name {Name}\nAddress{Address}\nPhone {Phone}\nOrder List {Orders}";
        }
    }
}