using System;

namespace UI
{
    public class InventoryMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Inventory Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[0] Main Menu");
            Console.WriteLine("[1] Exit");

        }

        public MenuType YourCoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}