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
        
        Customers cust =new Customers(){
            Name="Joskes",
            City="San Antonio",
            State="Texas"
        };
        Customers cust2 =new Customers(){
            Name="Mighty Bens",
            City="Corpus Christi",
            State="Texas"
        };
        List<Customers> listOfCust =new List<Customers>();
        listOfCust.Add(cust);
        listOfCust.Add(cust2);
            string _jsonString=JsonSerializer.Serialize(listOfCust, new JsonSerializerOptions{WriteIndented=true});
            //System.Console.WriteLine(_jsonString);
            File.WriteAllText(_filePath,_jsonString);
            _jsonString=File.ReadAllText(_filePath);
            List<Customers> custList=JsonSerializer.Deserialize<List<Customers>>(_jsonString);
            foreach(Customers item in listOfCust){
                System.Console.WriteLine(item);
            }
            
        }
    }
    
}