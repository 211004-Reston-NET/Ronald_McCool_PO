using System.Collections.Generic;
using Models;

namespace RRDL
{
    public interface IRepository
    {
      //It will add a product to our database
      //p_prod will be the Product added to the database
      //it will return the Product we are adding
        Product AddModel(Product _mod);
        Customer AddModel(Customer _mod);
        LineItem AddModel(LineItem _mod);
        Order AddModel(Order _mod);
        Store AddModel(Store _mod);
        //This will return a list of Products stored in the database
        //Returns a list of Products
        List<Product> GetAllProduct();
        List<Customer> GetAllCustomer();
        List<LineItem> GetAllLineItem();
        List<Order> GetAllOrder();
        List<Store> GetAllStore();
    }
}