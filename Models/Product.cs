using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;

        public Product() { }
        public Product(string name,double price,string description)
        {

        }
        public string  Name { get; set; }
        public double  Price { get; set; }
        public string Description { get; set; }
    }
}