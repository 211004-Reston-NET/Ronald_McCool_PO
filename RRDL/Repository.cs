using Models;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
namespace RRDL
{
    public class Repository:IRepository
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

       



    }
}