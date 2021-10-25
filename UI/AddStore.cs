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
          Console.WriteLine("[5] Enter Store Name");
          Console.WriteLine("[4] Enter Stor Address");
          Console.WriteLine("[3] Enter Products");
          Console.WriteLine("[2] Ebter Orders");
          Console.WriteLine("[1] Add store");
          Console.WriteLine("[0] Go back to StoreMenu");
         }
         public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "5":
                    Console.WriteLine("Enter store Name");
                    try
                    {
                        _store.Name = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                         Console.WriteLine("Name cannot have numbers");
                         Console.WriteLine("Press any key to continue");
                         Console.ReadLine();
                        return MenuType.AddStore;
                    }
                    //_store.Name = Console.ReadLine();
                    return MenuType.AddStore;
                case "4":
                    Console.WriteLine("Enter store Address");
                    _store.Address=Console.ReadLine();
                    return MenuType.AddStore;
                case "3":
                     Console.WriteLine("Enter Products");
                     _store.Products=null;
                     return MenuType.AddStore;
                case "2":
                      Console.WriteLine("Enter Order");
                      _store.Orders=null;
                      return MenuType.AddStore;
                case "1":
                try
                {
                    _modBL.AddModel(_store);
                }
                catch (System.Exception)
                {
                     Console.WriteLine("Please enter stores name");
                     Console.WriteLine("Press any key to continue");
                     Console.ReadLine();
                     return MenuType.AddStore;
                }
                  
                    return MenuType.StoreMenu;
                case "0":
                     return MenuType.StoreMenu;
                default:
                Console.WriteLine("What I don't understand. Try again!!");
                return MenuType.AddProduct;
            }

            
        }
        
    }
}