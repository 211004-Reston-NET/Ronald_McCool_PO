using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class AddOrder:IMenu
    {
        private static Order _order =new Order();
        private IModelBL _modBL;

        public AddOrder(IModelBL p_modBL){
            _modBL=p_modBL;
        }
         public void Menu(){
          Console.WriteLine("Add Order Menu");
          Console.WriteLine("[5] Main Menu");
          Console.WriteLine("[4] Enter LineItem");
          Console.WriteLine("[3] Enter store location");
          Console.WriteLine("[2] Enter price");
          Console.WriteLine("[1] Add Order");
          Console.WriteLine("[0] Go back Order Menu");
         }
         public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "5":
                    return MenuType.MainMenu;
                case "4":
                    Console.WriteLine("Enter LineItem");
                    Console.WriteLine("Line Item Entered");
                    _order.LineItems=null;
                    return MenuType.AddOrder;
                case "3":
                    Console.WriteLine("Enter store Location");
                    _order.StoreLocation=Console.ReadLine();
                    return MenuType.AddOrder;
                case "2":
                    Console.WriteLine("Enter Price");
                     _order.Price=double.Parse(Console.ReadLine());
                     return MenuType.AddOrder;
                case "1":
                    _modBL.AddModel(_order);
                    return MenuType.AddOrder;
                case "0":
                    return MenuType.OrderMenu;
                default:
                Console.WriteLine("What I don't understand. Try again!!");
                return MenuType.AddOrder;
            }

            
        }
    }
}