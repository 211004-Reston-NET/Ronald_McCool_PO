using System;

namespace UI
{
    public class MainMenu: IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to MainMenu");
            Console.WriteLine("What's your choice?");
            Console.WriteLine("[0] Main Menu");
            Console.WriteLine("[1] Customer Menu");
            Console.WriteLine("[2] Product Menu");
            Console.WriteLine("[3] Store Menu");
            Console.WriteLine("[4] LineItem Menu");
            Console.WriteLine("[5] Order Menu");
            Console.WriteLine("[6] Exit");
            Console.WriteLine("[7} Purchase Order");
            
        }



        public MenuType YourCoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.CustomerMenu;
                case "2":
                    return MenuType.ProductMenu;
                case "3":
                    return MenuType.StoreMenu;
                case "4":
                    return MenuType.LineItemMenu;
                case "5":
                    return MenuType.OrderMenu;
                case "6":
                    return MenuType.Exit;
                case "7":
                    return MenuType.PurchaseOrder;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}