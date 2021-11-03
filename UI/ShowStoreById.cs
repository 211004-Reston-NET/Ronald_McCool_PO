using RRBL;
using System;
using System.Collections.Generic;
using Models;
namespace UI
{
    public class ShowStoreById : IMenu
    {
        private IModelBL _store;
        private int _storeId;
        public ShowStoreById(IModelBL p_store){
            _store=p_store;
        }
        public void Menu()
        {
            System.Console.WriteLine("Welcome to Show Store By ID menu");
            System.Console.WriteLine("[0] Show Store By ID");
            System.Console.WriteLine("[1] Show Store Menu");
        }

        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "0":
                System.Console.WriteLine("Enter Store Id");
                 try
                 {
                    
                    _storeId=int.Parse(Console.ReadLine());
                  
                 }
                 catch (System.Exception ex)
                 {
                      System.Console.WriteLine("Not a valid Store ID number");
                      return MenuType.ShowStoreById;
                 }
                    List<Store> storeById =_store.GetAllStore();
                    foreach(Store s in storeById)
                    {
                        if(s.ID==_storeId){
                            System.Console.WriteLine("*****************************");
                            System.Console.WriteLine(s);
                            System.Console.WriteLine("*****************************");
                        }
                    } 
                    
                return MenuType.ShowStoreById;
                case "1":
                return MenuType.ShowStore;
                default:
                return MenuType.ShowCustById;
            }
        }
    }
}