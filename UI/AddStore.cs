using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class AddStore:IMenu
    {
        private static Store _store =new Store();
        private ModelBL _modBL;

        public AddStore(ModelBL p_modBL){
            _modBL=p_modBL;
        }
         public void Menu(){
          Console.WriteLine("Add Store Menu");
          Console.WriteLine("[4] Enter Store Name");
          Console.WriteLine("[3] Enter Stor Address");
          Console.WriteLine("[2] Add store");
          Console.WriteLine("[0] Go back to StoreMenu");
         }
         public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "4":
                    Console.WriteLine("Enter store Name");
                    _store.Name = Console.ReadLine();
                    return MenuType.AddStore;
                case "3":
                    Console.WriteLine("Enter store Address");
                    _store.Address=Console.ReadLine();
                    return MenuType.AddStore;
                case "2":
                    _modBL.AddModel(_store);
                    return MenuType.AddStore;
                default:
                Console.WriteLine("What I don't understand. Try again!!");
                return MenuType.AddProduct;
            }

            
        }
        
    }
}