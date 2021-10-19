using Models;
using RRDL;
using System.Collections.Generic;
using System.Linq;
namespace RRBL
{
    //Handles alll the business logic for are store application
    //They are in charge of further processing/sanitizing/further validatio 
    //of dats. Any Logic
    public class ModelBL:IModelBL
    {
        private IRepository _repo;
        public ModelBL(IRepository p_repo){
            _repo = p_repo;
        }
        public Product AddModel(Product p_mod){
            return _repo.AddModel(p_mod);
        }
        
         public Customer AddModel(Customer p_mod){
            return _repo.AddModel(p_mod);
        }
         public LineItem AddModel(LineItem p_mod){
            return _repo.AddModel(p_mod);
        }
         public Order AddModel(Order p_mod){
            return _repo.AddModel(p_mod);
        }
         public Store AddModel(Store p_mod){
            return _repo.AddModel(p_mod);
        }
        public List<Product> GetAllProduct(){
          
            return _repo.GetAllProduct();
        }
        public List<Customer> GetAllCustomer(){
            return _repo.GetAllCustomer();
        }
        public List<LineItem> GetAllLineItem(){
            return _repo.GetAllLineItem();
        }
        public List<Order> GetAllOrder(){
            return _repo.GetAllOrder();
        }
        public List<Store> GetAllStore(){
            return _repo.GetAllStore();
        }


        //Search for individual store
        public List<Store> GetStore(string p_name){
            List<Store> listOfStore =_repo.GetAllStore();
            return listOfStore.Where(stor => stor.Name.Contains(p_name)).ToList();
        }
    }
}
