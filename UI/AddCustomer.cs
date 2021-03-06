using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class AddCustomer:IMenu
    {
        private static Customer _cust =new Customer();
        private IModelBL _modBL;
        public AddCustomer(IModelBL p_cust){
            _modBL=p_cust;
        }
         public void Menu(){
          Console.WriteLine("Add Customer Menu");
          Console.WriteLine("[6] Main Menu");
          Console.WriteLine("[5] Enter customer name");
          Console.WriteLine("[4] Enter customer address");
          Console.WriteLine("[3] Enter customer phone number");
          Console.WriteLine("[2] Enter order");
          Console.WriteLine("[1] Add Customer");
          Console.WriteLine("[0] Go back Customer Menu");
         }
        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "6":
                return MenuType.MainMenu;
                case "5":
                Console.WriteLine("Enter Customer name");
               _cust.Name= Console.ReadLine();
                return MenuType.AddCustomer;
                case "4":
                Console.WriteLine("Enter Customer Address");
                _cust.Address=Console.ReadLine();
                return MenuType.AddCustomer;
                case "3":
                Console.WriteLine("Enter Customer Phone Number");
                _cust.Phone=Console.ReadLine();
                return MenuType.AddCustomer;
                case "2":
                Console.WriteLine("Enter Order");
                _cust.Orders=null;
                return MenuType.AddCustomer;
                case "1":
                _modBL.AddModel(_cust);
                return MenuType.AddCustomer;
                case "0":
                return MenuType.CustomerMenu;
                default:
                Console.WriteLine("What I don't understand. Try again!!");
                return MenuType.AddProduct;
            }

            
        }
    }
}