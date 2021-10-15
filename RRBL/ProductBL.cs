using Models;
using RRDL;
using System.Collections.Generic;
namespace RRBL
{
    //Handles alll the business logic for are store application
    //They are in charge of further processing/sanitizing/further validatio 
    //of dats. Any Logic
    public class ProductBL:IProductBL
    {
        private IRepository _repo;
        public ProductBL(IRepository p_repo){
            _repo = p_repo;
        }
        public Product AddProduct(Product p_prod){
            return _repo.AddProduct(p_prod);
        }
        public List<Product> GetAllProduct(){
          
            return _repo.GetAllProduct();
        }
    }
}
