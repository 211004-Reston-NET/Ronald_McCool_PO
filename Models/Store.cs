using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Models
{
    public class Store
    {
        private string _name;
        private string _address;
        private int _storeId;
        private List<Order> _orders;
        public Store() { }
        public Store(int id,string name, string address, List<Order> orders)
        {
            _storeId=id;
            _name=name;
            _address=address;
           
            _orders=orders;
        }
        public int ID { get; set; }
         public string Address { get; set; }
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
            
        public decimal moneytracker { get; set; }   
        public List<Order> Orders { get; set; }
        public List<LineItem> inventory { get; set; }
      
        public override string ToString()
        {
            return $"StoreId {ID}\nName {Name}\nAddress {Address}\nOrders {Orders}\nMoney {moneytracker}";
        }
    }
}
