using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class PurchaseOrder:IMenu
    {
            private IModelBL _porder;
            private int prod_qty;
             public static Store findStore=new Store();
             Customer newCust =new Customer();
            public static Customer findCust= new Customer();
            public PurchaseOrder(IModelBL p_po){
                _porder=p_po;
            }
      
        

        public void Menu()
        {
            System.Console.WriteLine("Welcome to place an Order");
            System.Console.WriteLine("[0] Place Order");
            System.Console.WriteLine("[1] Return main menu");
        }

        public MenuType YourCoice()
        {
            string choice = Console.ReadLine();
            switch(choice){
                case "0":
                System.Console.WriteLine("In the po class");
                var listOfOrders=_porder.GetAllOrder();
                  var listOfProd =_porder.GetAllProduct();
                foreach(Order orders in listOfOrders){
                    Store store=_porder.GetStore(orders.StoreId);
                    
                    Customer cust =_porder.GetCust(orders.CustId);
                       
                        foreach(LineItem l in orders.LineItems){
                            if(store.inventory.Find(x=>x.LineItemId==l.LineItemId)!=null){
                                if(store.inventory.Find(x=>x.LineItemId==l.LineItemId).Quantity > l.Quantity){
                                    store.inventory.Find(x=>x.LineItemId==l.LineItemId).Quantity-=l.Quantity;
                                    store.moneytracker +=l.ProId;
                                    cust.moneytrackercust-=l.Quantity * listOfProd.Find(x=>x.ProdId==l.ProId).ProdPrice;
                                    
                                }
                            }
                        }
                    

                }
               
                   List<Customer> custById =_porder.GetAllCustomer();
                   
                   foreach(Customer c in custById)
                   {
                       if(c.Id == findCust.Id){
                           
                           newCust=c;
                       }
                   }
                List<Order> order = _porder.getAllOrder(ShowOrder.findStore,ShowOrder.findCust);
                foreach(Order po in order){
                    Customer c = _porder.GetAllCustomer().Find(x => x.Id == po.CustId);
                    Store store=_porder.GetAllStore().Find(x=>x.ID==po.StoreId);
                }
                
                return MenuType.PurchaseOrder;
                case "1":
                return MenuType.MainMenu;
                default:
                return MenuType.PurchaseOrder;
            }
        
            
        }
            public void ListTheOrders(){
            List<Order> listOrders = _porder.getAllOrder(ShowOrder.findStore,ShowOrder.findCust);
            Console.WriteLine("List of Orders");
            foreach(Order orders in listOrders){
                Console.WriteLine("*****************************************");
                Console.WriteLine(orders);
                Console.WriteLine("*****************************************");
            }
        }
    }
}