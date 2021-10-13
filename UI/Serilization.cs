using Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
namespace UI{
    public class Serilization{
        public string _filePath="./Cust.json";
     
        public void SerialMain(){
        
        Customer cust =new Customer(){
            Name="Joskes",
            City="San Antonio",
            State="Texas"
        };
        Customer cust2 =new Customer(){
            Name="Mighty Bens",
            City="Corpus Christi",
            State="Texas"
        };
        List<Customer> listOfCust =new List<Customer>();
        listOfCust.Add(cust);
        listOfCust.Add(cust2);
            string _jsonString=JsonSerializer.Serialize(listOfCust, new JsonSerializerOptions{WriteIndented=true});
            //System.Console.WriteLine(_jsonString);
            File.WriteAllText(_filePath,_jsonString);
            _jsonString=File.ReadAllText(_filePath);
            List<Customer> custList=JsonSerializer.Deserialize<List<Customer>>(_jsonString);
            foreach(Customer item in listOfCust){
                System.Console.WriteLine(item);
            }
            
        }
    }
}