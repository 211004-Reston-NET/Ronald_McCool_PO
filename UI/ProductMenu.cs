using System;
namespace UI
{
    public class ProductMenu:IMenu
    {
          public void Menu()
        {
            Console.WriteLine("Welcome to Product Menu");
            Console.WriteLine("What do you do?");
            Console.WriteLine("[1] Main Menu");
            Console.WriteLine("[2] Show Product");
            Console.WriteLine("[3] Add Product");
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
                    return MenuType.ShowProduct;
                case "3":
                    return MenuType.AddProduct;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
    }
}