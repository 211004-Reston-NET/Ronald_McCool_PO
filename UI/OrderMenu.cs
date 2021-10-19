using System;

namespace UI
{
    public class OrderMenu: IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Order Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[1] Main Menu");
            Console.WriteLine("{2} Add Order");
            Console.WriteLine("[3] Show Order");
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
                     return MenuType.AddOrder;
                case "3":
                      return MenuType.ShowOrder;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}