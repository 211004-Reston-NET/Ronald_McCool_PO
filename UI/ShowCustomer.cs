using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowCustomer:IMenu
    {
        private IModelBL _cust;
        public ShowCustomer(IModelBL p_cust){
            _cust=p_cust;
        }
        public void Menu(){
           
            ListTheCustomers();
            System.Console.WriteLine("[1] Show Customer Again");
            System.Console.WriteLine("[2] Go Back");
        }
        public  MenuType YourCoice(){
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                  
                case "1":
                     ListTheCustomers();
                    return MenuType.ShowCustomer;
                case "2":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
        public void ListTheCustomers(){
            List<Customer> listCustomers = _cust.GetAllCustomer();
            Console.WriteLine("List of Customers");
            foreach(Customer cust in listCustomers){
                Console.WriteLine("*****************************************");
                Console.WriteLine(cust);
                Console.WriteLine("*****************************************");
            }
        }
    }
}