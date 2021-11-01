using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowStore:IMenu
    {
          private IModelBL _storeBL;
          public static string _findStoreName;
        //we are defining the dependecies this class needs to operate
        //we do this it this way because we can easily switch out which implementation details we will be using
        //But later we will be able to switch our RRDL proj to point to an actual database in the cloud 
        // without touching anything else to have that implementation
      
        public ShowStore(IModelBL p_modBl){
            _storeBL=p_modBl;
        }
        
        public void Menu()
        {
           // ListTheStores();
            Console.WriteLine("[4] Main Menu");
            Console.WriteLine("[3] List Stores");
            Console.WriteLine("[2] Search for Store");
            Console.WriteLine("[1] Search for Store By ID");
            Console.WriteLine("[0] Go back to store menu");
        }
        
        public MenuType YourCoice()
        {
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    return MenuType.MainMenu;      
                case "3":
                    ListTheStores();
                    return MenuType.ShowStore;
                case "2":
                    Console.WriteLine("Enter store you want to locate");
                    _findStoreName=Console.ReadLine();
                    return MenuType.CurrentStore;
                case "1":
                    return MenuType.ShowStoreById;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
         public void ListTheStores(){
             System.Console.WriteLine("List of Stores");
            List<Store> listOfStores=_storeBL.GetAllStore(); 
            foreach(Store store in listOfStores){
                System.Console.WriteLine("==============================================================");
                System.Console.WriteLine(store);
                System.Console.WriteLine("==============================================================");
            }
        }

    }
}