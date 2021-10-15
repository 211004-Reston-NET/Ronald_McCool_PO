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
        public Customer(String name, string address, string ph, List<Order> orders)
        {
            _name=name;
            _address=address;
            _ph=ph;
            _listOrders=Orders;

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
        public List<Order> GetAllOrders(){
            return _listOrders;
        }
        public override string ToString()
        {
            return $"Name {_name} Address {_address} Phone {_ph} Orders {_listOrders}";
        }
    }
}