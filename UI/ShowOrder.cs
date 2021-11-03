using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowOrder:IMenu
    {
          private IModelBL _order;
        public ShowOrder(IModelBL p_order){
            _order=p_order;
        }
        public static Store findStore=new Store();
        public static Customer findCust= new Customer();
        public void Menu(){
           
           
            Console.WriteLine("[2] Go back Main Menu");
            Console.WriteLine("[1] Show Order by Store and Customer");
            Console.WriteLine("[0] Go Back Order Menu");
        }
        public  MenuType YourCoice(){
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "2":
                    return MenuType.MainMenu;  
                case "1":
                try{
                    System.Console.WriteLine("Enter store ID");
                     findStore.ID=Int32.Parse(Console.ReadLine());
                     System.Console.WriteLine("Enter Customer ID");
                     findCust.Id=Int32.Parse(Console.ReadLine());
                }catch (FormatException e){
                    System.Console.WriteLine("ID number's only");
                    return MenuType.ShowOrder;
                }
                   ListTheOrders();
                    return MenuType.ShowOrder;
                case "0":
                    return MenuType.OrderMenu;
                default:
                    Console.WriteLine("You have to enter a choice Main Menu");
                    return MenuType.MainMenu;
            }
        }
        public void ListTheOrders(){
            List<Order> listOrders = _order.getAllOrder(ShowOrder.findStore,ShowOrder.findCust);
            Console.WriteLine("List of Orders");
            foreach(Order orders in listOrders){
                Console.WriteLine("*****************************************");
                Console.WriteLine(orders);
                Console.WriteLine("*****************************************");
            }
        }
    }
}