using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace RRBL
{
    public interface IModelBL
    {
        //tHIS WILL RETURN A LIST OF PRODUCTS STORED IN THE DATABASE
        //It will return a list of Products
         List<Product> GetAllProduct();
        List<Customer> GetAllCustomer();
        List<LineItem> GetAllLineItem();
        List<Order> GetAllOrder();
        List<Store> GetAllStore();
        //Add Product to the database
        //p_prod is the product we are adding
        //It twill rturn the (Product) p_prod 
        Product AddModel(Product _mod);
        Customer AddModel(Customer _mod);
        LineItem AddModel(LineItem _mod);
        Order AddModel(Order _mod);
        Store AddModel(Store _mod);
    }
}