using Models;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
namespace RRDL
{
    public class Repository
    {
        //referene from startup proj RRUI pick up folder and drill into the RRDL
        private const string _filePath="./../RRDL/Database/Product_Data.json";
        private string _jsonString;

       
        public Product AddProduct(Product p_newProd){
             List<Product> ListOfProducts=GetAllProduct();
             ListOfProducts.Add(p_newProd);
             _jsonString=JsonSerializer.Serialize(ListOfProducts, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath,_jsonString);
              return p_newProd;

        }
         public List<Product> GetAllProduct(){

             _jsonString=File.ReadAllText(_filePath);
             return JsonSerializer.Deserialize<List<Product>>(_jsonString);
             }

        public Store AddStore(Store p_newStore){
             List<Store> ListOfStore=GetAllStore();
             ListOfStore.Add(p_newStore);
             _jsonString=JsonSerializer.Serialize(ListOfStore, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath,_jsonString);
              return p_newStore;
              }
         public List<Store> GetAllStore(){

             _jsonString=File.ReadAllText(_filePath);
             return JsonSerializer.Deserialize<List<Store>>(_jsonString);
             }

        public Order AddOrder(Order p_newOrder){
             List<Order> ListOfOrder=GetAllOrder();
             ListOfOrder.Add(p_newOrder);
             _jsonString=JsonSerializer.Serialize(ListOfOrder, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath,_jsonString);
              return p_newOrder;
              }
        public List<Order> GetAllOrder(){

             _jsonString=File.ReadAllText(_filePath);
             return JsonSerializer.Deserialize<List<Order>>(_jsonString);
             }
         public Customer AddCustomer(Customer p_newCust){
             List<Customer> ListOfCust=GetAllCustomer();
             ListOfCust.Add(p_newCust);
             _jsonString=JsonSerializer.Serialize(ListOfCust, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath,_jsonString);
              return p_newCust;
              }
        public List<Customer> GetAllCustomer(){

             _jsonString=File.ReadAllText(_filePath);
             return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
             }



    }
}