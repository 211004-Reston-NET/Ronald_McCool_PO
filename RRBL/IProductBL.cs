using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace RRBL
{
    public interface IProductBL
    {
        //tHIS WILL RETURN A LIST OF PRODUCTS STORED IN THE DATABASE
        //It will return a list of Products
        List<Product> GetAllProduct();
        //Add Product to the database
        //p_prod is the product we are adding
        //It twill rturn the (Product) p_prod 
        Product AddProduct(Product p_prod);
    }
}