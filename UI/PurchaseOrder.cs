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
                Console.WriteLine("Enter how many you want");
                try{
                prod_qty=Int32.Parse(Console.ReadLine());
                }catch(FormatException f){
                    Console.WriteLine("Hay enter whole number quantity");
                    return MenuType.PurchaseOrder;
                }
                Console.WriteLine("Enter store ID");
                findStore.ID=Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Customer ID");
                findCust.Id=Int32.Parse(Console.ReadLine());
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