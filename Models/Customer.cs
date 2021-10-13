using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        private string _name;
        private string _address;
        private string _ph;
        private List<Order> _orders;

        public Customer() { }
        public Customer(String name, string address, string ph, List<Order> orders)
        {

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}