using System;

namespace UI
{
    public class MainMenu: IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to MainMenu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[0] Store Front");
            Console.WriteLine("[1] Customer");
            Console.WriteLine("[2] Order");
            Console.WriteLine("[3] Inventory");
            Console.WriteLine("[4] Main Menu");
            Console.WriteLine("[5] ShowProduct");
            Console.WriteLine("[6] Exit");
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
                    return MenuType.MainMenu;
                case "5":
                    return MenuType.ShowProduct;
                 case "6":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}