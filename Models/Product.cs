using System;
using System.Collections.Generic;
namespace Models
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;
        private decimal _prodId;
        private List<LineItem> _listOfLineItems;

        public Product() { }
        public Product(string name,decimal price,string description)
        {
            _name=name;
            //_price=price;
            _description=description;

        }
        public int ProdId { get; set; }
        public string  Name { get; set; }
        public decimal  ProdPrice { get; set; }
        public string Description { get; set; }
        public List<LineItem> LineItems { get; set; }

        public override string ToString()
        {
            return $"ProdID: {ProdId}\nName: {Name}\nPrice: {ProdPrice}\nDescription: {Description}";
        }
    }
}