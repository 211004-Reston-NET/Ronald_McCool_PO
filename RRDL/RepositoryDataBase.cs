using System.Collections.Generic;
using System;
using System.Linq;
using mod = Models;
using Entity=RRDL.Entities;
using Models;

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
                    Moneytrackercust=_mod.moneytrackercust
                    
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
                    LineitemId=_mod.LineItemId,
                    LineitemQty=_mod.Quantity,
                    ProdId=_mod.ProId,
                    OrderId=_mod.OrderId

                }

            );
            _contex.SaveChanges();
            return _mod;
        }

        public mod.Order AddModel(mod.Order _mod)
        {
        var entity = 
                new Entity.Order()
                {
                    OrderId=_mod.OrderId,
                    OrderPrice=_mod.Price,
                    StoreId=_mod.StoreId,
                    CustId=_mod.CustId
                };
            
           _contex.Orders.Add(entity);
            _contex.SaveChanges();
           foreach(var lineI in _mod.LineItems) {
               _contex.OrdersLineitems.Add(new Entity.OrdersLineitem(){
                   OrderId= entity.OrderId,
                   LineitemId=lineI.LineItemId,
            
                   
               });
           }
           _mod.OrderId=entity.OrderId;
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
                    StoreAddress=_mod.Address,
                    Moneytraker=_mod.moneytracker
                    
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
                    moneytrackercust=cust.Moneytrackercust,
                    Orders=cust.Orders.Select(ord=> new mod.Order(){
                    Price=ord.OrderPrice,
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
        public List<mod.Order> GetAllOrder(){
             return _contex.Orders.Select(order =>
           
                new mod.Order()
                {
                    OrderId=order.OrderId,
                    Price=order.OrderPrice,
                    StoreId=order.StoreId,
                    CustId=order.CustId,
                    LineItems=
                        (from LI in _contex.Lineitems
                        join oli in _contex.OrdersLineitems on LI.LineitemId equals oli.LineitemId
                        where oli.OrderId==order.OrderId select 
                        new mod.LineItem(){
                            LineItemId=LI.LineitemId,
                            Quantity=LI.LineitemQty,
                            ProId=LI.ProdId,
                        }).ToList()
                }).ToList();
                
        }

        public mod.Store GetStore(int p_storeId){
            return GetAllStore().Find(id => id.ID==p_storeId);
        }
        public mod.Customer GetCust(int p_custId){
            return GetAllCustomer().Find(id => id.Id==p_custId);
        }
       /* public List<mod.Order> GetAllOrder(mod.Store p_store,mod.Customer p_cust)
        {


            var result=(from ord in _contex.Orders 
            join store in _contex.Stores on ord.StoreId equals p_store.ID
            join cust in _contex.Customers on ord.CustId equals p_cust.Id    select ord);
        
             List<mod.Order> orderList = new List<mod.Order>();
             foreach(Entities.Order ord in result){
                 orderList.Add(new mod.Order(){
                     OrderId=ord.OrderId,
                     StoreId=ord.StoreId,
                     CustId=ord.CustId
                 });
             } 
            return _contex.Orders.Select(order =>
           
                new mod.Order()
                {
                    OrderId=order.OrderId,
                    Price=order.OrderPrice,
                    StoreId=order.StoreId,
                    CustId=order.CustId
                }
                
            ).ToList();
            return orderList;
        }*/

        public List<Order> getAllOrder(mod.Store p_store,mod.Customer p_cust)
        {
            //store in _contex.Stores on  cust in _contex.Customers on
            
            var result=(from ord in _contex.Orders 
            where  ord.StoreId==p_store.ID 
            where  ord.CustId==p_cust.Id    select ord);
        
             List<mod.Order> orderList = new List<mod.Order>();
             foreach(Entities.Order ord in result){
                 orderList.Add(new mod.Order(){
                     OrderId=ord.OrderId,
                     StoreId=ord.StoreId,
                     CustId=ord.CustId,
                     /*LineItems=(from li in _contex.Lineitems
                      where li.OrderId==ord.OrderId
                      select new mod.LineItem(){
                          LineItemId=li.LineitemId,
                          Quantity=li.LineitemQty,
                          ProId=li.ProdId,
                          OrderId=li.OrderId
                      }).ToList()*/
                     
                 });
             } 
            //throw new NotImplementedException();
             return orderList;
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
                    Address=store.StoreAddress,
                    moneytracker=store.Moneytraker,
                    inventory=(from p in _contex.Lineitems
                    join inv in _contex.Inventories on p.LineitemId equals inv.LineitemId
                    where inv.StoreId == store.StoreId
                    select new mod.LineItem(){
                        LineItemId=p.LineitemId,
                        Quantity=p.LineitemQty,
                        ProId=p.ProdId
                        
                    }).ToList()
                    
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