using Models;
using RRDL;

using System.Collections.Generic;
using System.Linq;
using System;
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
          if(p_mod.Name == null){
              throw new Exception("You must enter a name for resteraunt");
          }
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

     
        //Search for individual Store
        public List<Store> GetStore(string p_name){
            List<Store> listOfStore =_repo.GetAllStore();
            return listOfStore.Where(stor => stor.Name.Contains(p_name)).ToList();
        }

        //Search for individual Customer
        public List<Customer> GetCust(string p_name)
        {
            List<Customer> ListOfCust =_repo.GetAllCustomer();
            return ListOfCust.Where(cust => cust.Name.Contains(p_name)).ToList();
        }

        //Search for individual Product
        public List<Product> GetProd(string p_name)
        {
            List<Product> ListOfProd =_repo.GetAllProduct();
            return ListOfProd.Where(prod => prod.Name.Contains(p_name)).ToList();
        }
        public Customer GetCustomerById(int p_id)
        {
            Customer custFound =_repo.GetCustomerById(p_id);
            if(custFound==null)
            {
                return null;
            }
            return custFound;
        }
        public Store GetStoreById(int p_id)
        {
            Store storeFound =_repo.GetStoreById(p_id);
            if(storeFound==null)
            {
                //throw new Exception("Store not found");
                return null;
            }
            return storeFound;
        }

        public List<Order> getAllOrder(Store s, Customer c)
        {
            return _repo.getAllOrder(s,c);
        }
        public Customer GetCust(int p_custId){
            return _repo.GetCust(p_custId);

        }

        public Store GetStore(int p_storeId)
        {
            return _repo.GetStore(p_storeId);
        }
    }
}
