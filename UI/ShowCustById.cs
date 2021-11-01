using RRBL;
using System;
using System.Collections.Generic;
using Models;
namespace UI
{
    public class ShowCustById : IMenu
    {
        private IModelBL _cust;
        private int custId;
        public ShowCustById(IModelBL p_cust){
            _cust=p_cust;
        }
        public void Menu()
        {
            System.Console.WriteLine("Welcome to Show Customer By ID menu");
            System.Console.WriteLine("[0] Show Customer By ID");
            System.Console.WriteLine("[1] Show Customer Menu");
           
            
            
        }

        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "0":
                 System.Console.WriteLine("Enter customer id");
                 try
                 {
                    custId=int.Parse(Console.ReadLine()); 
                 }
                 catch (System.Exception ex)
                 {
                      System.Console.WriteLine("Not a valid customer ID number");
                      return MenuType.ShowCustById;
                 }
                    
                    List<Customer> custById =_cust.GetAllCustomer();
                    foreach(Customer c in custById)
                    {
                        if(c.Id==custId){
                            System.Console.WriteLine("*****************************");
                            System.Console.WriteLine(c);
                            System.Console.WriteLine("*****************************");
                        }
                    }
                return MenuType.ShowCustById;
                case "1":
                return MenuType.ShowCustomer;
                default:
                return MenuType.ShowCustById;
            }
            
        }
    }
}