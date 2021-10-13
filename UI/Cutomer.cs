using System;
namespace UI{
    public class Customer{
        public override string ToString()
        {
            return $"Name: {_name} City: {_city} State: {_state}";
        }
        private string _name;
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        
        
    }
}