using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowCustomer:IMenu
    {

        //IModelBL object used to achieve dependency injection uses abstraction that 
        //are implemented in ModelBL where a the RRDL uses it own dependency injection to access the DB 
        private IModelBL _cust;

        //static string var to pass to CurrentCustomer


        public static string _findCustName;
        public ShowCustomer(IModelBL p_cust){
            _cust=p_cust;
        }
        public void Menu(){
           
            ListTheCustomers();
            System.Console.WriteLine("[0] Search FOR Customer");
            System.Console.WriteLine("[1] Show Customer Again");
            System.Console.WriteLine("[2] Go Back Customer Menu");
        }
        public  MenuType YourCoice(){
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    Console.WriteLine("Enter Customer you want to locate");
                    _findCustName=Console.ReadLine();
                    return MenuType.CurrentCustomer;
                case "1":
                     ListTheCustomers();
                    return MenuType.ShowCustomer;
                case "2":
                    return MenuType.CustomerMenu;
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