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
        public Customer(String name, string address, string ph)
        {
            _name=name;
            _address=address;
            _ph=ph;

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    
      
        public override string ToString()
        {
            return $"Name {Name}\nAddress{Address}\nPhone {Phone}";
        }
    }
}