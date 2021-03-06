using System;

namespace UI
{
    public class CustomerMenu:IMenu
    {
         public void Menu()
        {
            Console.WriteLine("Welcome to customer Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[1] Main Menu");
            Console.WriteLine("[2] Show Customer");
            Console.WriteLine("[3] Add Customer");
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
                    return MenuType.ShowCustomer;
                case "3":
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}