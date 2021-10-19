using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowLineItems : IMenu
    {

        private IModelBL _lineItem;
        public ShowLineItems(IModelBL p_lineItem){
            _lineItem=p_lineItem;
        }
        public void Menu(){
           
            ListTheLineItems();
            System.Console.WriteLine("[1] Show Customer Again");
            System.Console.WriteLine("[2] Go Back Line Item Menu");
        }
        public  MenuType YourCoice(){
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                  
                case "1":
                     ListTheLineItems();
                    return MenuType.ShowLineItem;
                case "2":
                    return MenuType.LineItemMenu;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
        public void ListTheLineItems(){
            List<LineItem> listLineItems = _lineItem.GetAllLineItem();
            Console.WriteLine("List of LineItems");
            foreach(LineItem lineitems in listLineItems){
                Console.WriteLine("*****************************************");
                Console.WriteLine(lineitems);
                Console.WriteLine("*****************************************");
            }
        }
    }
}