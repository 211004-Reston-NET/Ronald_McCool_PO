using System.Collections.Generic;
using Models;

namespace RRDL
{
    public interface IRepository
    {
      //It will add a product to our database
      //p_prod will be the Product added to the database
      //it will return the Product we are adding
        Product AddProduct(Product p_prod);
        //This will return a list of Products stored in the database
        //Returns a list of Products
        List<Product> GetAllProduct();
    }
}