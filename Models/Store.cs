using System;
using System.Text.RegularExpressions;

namespace Models
{
    public class Store
    {
        private string _city;
        public string City
        {
            get { 
                return _city; 
                }
            set {
                //regex expression will find numer inside strin
                if(!Regex.IsMatch(value,@"^[A-Za-z,]+$"))
                //Throws exception if number found
                throw new Exception("Invalid City Name");
                 _city = value;
                } 
            
        }
        
        public string State { get; set; }
        public string Name { get; set; }
        
        
    }
}
