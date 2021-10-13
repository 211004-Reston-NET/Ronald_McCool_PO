using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI
{
      public class InventoryMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Inventory Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[0] Store Front");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Order");
            Console.WriteLine("[3] Inventory");
            Console.WriteLine("[4] Main Menu");
            Console.WriteLine("[5] Exit");

        }

        public MenuType YourCoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreMenu;
                case "1":
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.OrderMenu;
                case "3":
                    return MenuType.Inventory;
                case "4":
                    return MenuType.MainMenu;
                case "5":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}