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
            Console.WriteLine("[1] Customer Menu");
            Console.WriteLine("[2] Product Menu");
            Console.WriteLine("[3] Main Menu");
            Console.WriteLine("[4] Exit");
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
                    return MenuType.ProductMenu;
                case "3":
                    return MenuType.MainMenu;
                 case "4":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
                    break;
            }
        }
    }
}