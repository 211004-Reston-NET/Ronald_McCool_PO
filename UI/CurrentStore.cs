using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class CurrentStore : IMenu
    {
        private IModelBL _curStoreBL;

        public CurrentStore(IModelBL p_curStoreBL)
        {
            _curStoreBL=p_curStoreBL;
        }
        public void Menu()
        {
            List<Store> listOfStore =_curStoreBL.GetStore(ShowStore._findStoreName);
            Console.WriteLine("ThEe search result");
            foreach(Store store in listOfStore){
                Console.WriteLine("*******************************");
                Console.WriteLine(store);
                Console.WriteLine("********************************");
            }
            Console.WriteLine("[0] Go back to Show Store");
        }

        public MenuType YourCoice()
        {
                string choice=Console.ReadLine();
                switch(choice){
                    case "0":
                        return MenuType.ShowStore;
                    default:
                        Console.WriteLine("Hay enter o to go bak to the show store");
                        return MenuType.CurrentStore;
                }
                
        }
    }
}