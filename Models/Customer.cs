using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _address;
        private string _ph;
        private List<Order> _listOrders;

        public Customer() { }
        public Customer(int id,String name, string address, string ph, List<Order> listOrder)
        {
            _id=id;
            _name=name;
            _address=address;
            _ph=ph;
            _listOrders=listOrder;

        }

        public int Id { get; set; }
        public string Name {  
            get{return _name;} 
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")){
                    throw new System.Exception("Name cannot have numbers");
                }
                _name=value;
                
            }  }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal moneytrackercust { get; set; }
        public List<Order> Orders { get; set; }
    
      
        public override string ToString()
        {
            return $"CustId {Id}\nName {Name}\nAddress{Address}\nPhone {Phone}\nMoney {moneytrackercust}";
        }
    }
}