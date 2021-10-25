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
        public void Menu(){
           
            ListTheOrders();
            Console.WriteLine("[2] Go back Main Menu");
            Console.WriteLine("[1] Show Order Again");
            Console.WriteLine("[0] Go Back Order Menu");
        }
        public  MenuType YourCoice(){
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {

                case "2":
                    return MenuType.MainMenu;  
                case "1":
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
            List<Order> listOrders = _order.GetAllOrder();
            Console.WriteLine("List of Orders");
            foreach(Order orders in listOrders){
                Console.WriteLine("*****************************************");
                Console.WriteLine(orders);
                Console.WriteLine("*****************************************");
            }
        }
    }
}