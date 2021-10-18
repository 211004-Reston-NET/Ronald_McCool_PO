using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class ShowStore:IMenu
    {
          private IModelBL _storeBL;
        //we are defining the dependecies this class needs to operate
        //we do this it this way because we can easily switch out which implementation details we will be using
        //But later we will be able to switch our RRDL proj to point to an actual database in the cloud 
        // without touching anything else to have that implementation
      
        public ShowStore(IModelBL p_modBl){
            _storeBL=p_modBl;
        }
        
        public void Menu()
        {
            ListTheStores();
            System.Console.WriteLine("[0] Main Menu");
            System.Console.WriteLine("[1] Show Store Again");
            System.Console.WriteLine("[2] Exit");
        }
        
        public MenuType YourCoice()
        {
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;      
                case "1":
                    ListTheStores();
                    return MenuType.ShowStore;
                case "2":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
         public void ListTheStores(){
             System.Console.WriteLine("List of Products");
            List<Store> listOfStores=_storeBL.GetAllStore(); 
            foreach(Store store in listOfStores){
                System.Console.WriteLine("==============================================================");
                System.Console.WriteLine(store);
                System.Console.WriteLine("==============================================================");
            }
        }

    }
}