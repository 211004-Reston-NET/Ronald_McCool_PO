using Models;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
namespace RRDL
{
    public class Repository:IRepository
    {
        //referene from startup proj RRUI pick up folder and drill into the RRDL
        private const string _filePath="./../RRDL/Database/";
        private string _jsonString;

       
        public Product AddModel(Product p_model){
             List<Product> ListOfModels=GetAllProduct();
             ListOfModels.Add(p_model);
             _jsonString=JsonSerializer.Serialize(ListOfModels, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath + "Product_Data.json",_jsonString);
              return p_model;

        }
           public Customer AddModel(Customer p_model){
             List<Customer> ListOfModels=GetAllCustomer();
             ListOfModels.Add(p_model);
             _jsonString=JsonSerializer.Serialize(ListOfModels, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath + "Customer_Data.json",_jsonString);
              return p_model;

        }
           public LineItem AddModel(LineItem p_model){
             List<LineItem> ListOfModels=GetAllLineItem();
             ListOfModels.Add(p_model);
             _jsonString=JsonSerializer.Serialize(ListOfModels, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath + "LineItem_Data.json",_jsonString);
              return p_model;

        }
           public Order AddModel(Order p_model){
             List<Order> ListOfModels= GetAllOrder();
             ListOfModels.Add(p_model);
             _jsonString=JsonSerializer.Serialize(ListOfModels, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath + "Order_Data.json",_jsonString);
              return p_model;

        }
           public Store AddModel(Store p_model){
             List<Store> ListOfModels=GetAllStore();
             ListOfModels.Add(p_model);
             _jsonString=JsonSerializer.Serialize(ListOfModels, new JsonSerializerOptions{WriteIndented=true});
              File.WriteAllText(_filePath + "Store_Data.json",_jsonString);
              return p_model;

        }
            public List<Product> GetAllProduct(){

             _jsonString=File.ReadAllText(_filePath+"Product_Data.json");
             return JsonSerializer.Deserialize<List<Product>>(_jsonString);
             }
             public List<Customer> GetAllCustomer(){

             _jsonString=File.ReadAllText(_filePath+"Customer_Data.json");
             return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
             }

             public List<LineItem> GetAllLineItem(){

             _jsonString=File.ReadAllText(_filePath+"LineItem_Data.json");
             return JsonSerializer.Deserialize<List<LineItem>>(_jsonString);
             }

             public List<Order> GetAllOrder(){

             _jsonString=File.ReadAllText(_filePath+"Order_Data.json");
             return JsonSerializer.Deserialize<List<Order>>(_jsonString);
             }

             public List<Store> GetAllStore(){

             _jsonString=File.ReadAllText(_filePath+"Store_Data.json");
             return JsonSerializer.Deserialize<List<Store>>(_jsonString);
             }
             public Customer GetCustomerById(int p_id){
                   return null;
             }
             public Store GetStoreById(int p_id){
                   return null;
             }
             public List<Order> GetAllOrder(Store store, Customer customer){
                   return null;
             }

        public List<Order> getAllOrder(Store store, Customer cust)
        {
            return null;
        }

        public Customer GetCust(int p_custId)
        {
            return GetAllCustomer().Find(id => id.Id==p_custId);
        }

        public Store GetStore(int p_storeId)
        {
             return GetAllStore().Find(id => id.ID==p_storeId);
        }
    }
}