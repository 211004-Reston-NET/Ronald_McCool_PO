using Models;
using RRDL;
using System.Collections.Generic;
namespace RRBL
{
    public class ProductBL
    {
        private Repository _repo;
        public ProductBL(Repository p_repo){
            _repo=p_repo;
        }
        public List<Product> GetAllProducts(){
            return _repo.GetAllProduct();
        }
    }
}
