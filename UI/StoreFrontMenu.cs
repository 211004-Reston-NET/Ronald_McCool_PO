using System;

namespace UI
{
    public class StoreFrontMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Store Front Menu");
            Console.WriteLine("What do you do?");
            
            Console.WriteLine("[1] Main Menu");
            Console.WriteLine("[2] Add Store");
            Console.WriteLine("[3] Show Store");
            Console.WriteLine("[0] Exit");

        }

        public MenuType YourCoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
                case "1":
                    return MenuType.MainMenu;
                case "2":
                    return MenuType.AddStore;
                case "3":
                    return MenuType.ShowStore;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}