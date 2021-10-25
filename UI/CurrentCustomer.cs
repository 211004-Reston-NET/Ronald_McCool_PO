using System;
using RRBL;
using Models;
using System.Collections.Generic;
namespace UI
{
    public class CurrentCustomer:IMenu
    {
        private IModelBL _curCustBL;
        public CurrentCustomer(IModelBL p_model){
         
            _curCustBL = p_model;

        }

        public void Menu()
        {
           // Console.WriteLine(ShowCustomer._findCustName);
             List<Customer> listOfCust =_curCustBL.GetCust(ShowCustomer._findCustName);
            Console.WriteLine("The search result");
            foreach(Customer cust in listOfCust){
                Console.WriteLine("*******************************");
                Console.WriteLine(cust);
                Console.WriteLine("********************************");
            }
            Console.WriteLine("[0] Go back to Show Store");
        }

        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice)
            {
                case "0":
                return MenuType.ShowCustomer;
                default:
                    System.Console.WriteLine("What did you enter");
                    return MenuType.CurrentCustomer;
            }
        }
    }
}