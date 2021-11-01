using System.Collections.Generic;
using System;
using System.Linq;
using mod = Models;
using Entity=RRDL.Entities;

namespace RRDL{
    public class RepositoryDataBase : IRepository
    {
        private Entity.qasvkiagContext _contex; 
        public RepositoryDataBase(Entity.qasvkiagContext p_contex){
            _contex=p_contex;
        }
        public mod.Product AddModel(mod.Product _mod)
        {

            _contex.Products.Add(
                new Entity.Product()
                {
                    ProdName=_mod.Name,
                    ProdPrice=_mod.ProdPrice,
                    ProdDesc=_mod.Description                   
                }
            );
            _contex.SaveChanges();
            return _mod;
        }

        public mod.Customer AddModel(mod.Customer _mod)
        {
            _contex.Customers.Add(
                new Entity.Customer()
                {
                    CustName=_mod.Name,
                    CustAddress=_mod.Address,
                    CustPhone=_mod.Phone,
                    
                }
            );
            _contex.SaveChanges();
            return _mod;
        }

        public mod.LineItem AddModel(mod.LineItem _mod)
        {
            _contex.Lineitems.Add(
                new Entity.Lineitem()
                {
                    LineitemQty=_mod.Quantity
                }

            );
            _contex.SaveChanges();
            return _mod;
        }

        public mod.Order AddModel(mod.Order _mod)
        {
            _contex.Orders.Add(
                new Entity.Order()
                {
                    OrderPrice=(decimal)_mod.Price
                }
            );
            _contex.SaveChanges();
            return _mod;
        }

        public mod.Store AddModel(mod.Store _mod)
        {
            _contex.Stores.Add(
                new Entity.Store()
                {
                    StoreId=_mod.ID,
                    StoreName=_mod.Name,
                    StoreAddress=_mod.Address
                    
                }
            );
            _contex.SaveChanges();
            return _mod;
        }

        public List<mod.Customer> GetAllCustomer()
        {
              return _contex.Customers.Select(cust=>
                new mod.Customer
                {
                    Id=cust.CustId,
                    Name=cust.CustName,
                    Address=cust.CustAddress,
                    Phone=cust.CustPhone,
                    Orders=cust.Orders.Select(ord=> new mod.Order(){
                    Price=(double)ord.OrderPrice,
                   // CustId=cust.CustId,
                    StoreId=(int)ord.StoreId
                    }).ToList()
                }
                //  Reviews = restToFind.Reviews.Select(rev => new Model.Review(){ 
                //    Id = rev.RevId,
                //    Rating = rev.RevRating
            ).ToList();
         
        }

        public List<mod.LineItem> GetAllLineItem()
        {
            return _contex.Lineitems.Select(line => 
            new mod.LineItem()
            {
                Quantity=(int)line.LineitemQty
            }
            ).ToList();
            
        }

        public List<mod.Order> GetAllOrder()
        {
            return _contex.Orders.Select(order =>
                new mod.Order()
                {
                    Price=(double)order.OrderPrice
                }
                
            ).ToList();
        }

        public List<mod.Product> GetAllProduct()
        {
            //methos systax
            return _contex.Products.Select(prod=>
                new mod.Product()
                {
                    ProdId=prod.ProdId,
                    Name=prod.ProdName,
                    ProdPrice=(decimal)prod.ProdPrice,
                    Description=prod.ProdDesc
                    
                }
            ).ToList();
        }

        public List<mod.Store> GetAllStore()
        {
            return _contex.Stores.Select( store =>
                new mod.Store()
                {
                    ID=store.StoreId,
                    Name=store.StoreName,
                    Address=store.StoreAddress
                }
            ).ToList();
        }
        public mod.Customer GetCustomerById(int p_id){
            Entity.Customer custToFind = _contex.Customers.Find(p_id);
            return new mod.Customer(){
                Id=custToFind.CustId,
                Name=custToFind.CustName,
                Address=custToFind.CustAddress,
                Phone=custToFind.CustPhone
            };
        } 
        public mod.Store GetStoreById(int p_id){
            Entity.Store storeToFind =_contex.Stores.Find(p_id);
            return new mod.Store(){
                ID=storeToFind.StoreId,
                Name=storeToFind.StoreName,
                Address=storeToFind.StoreAddress
            };
        }
    }
}