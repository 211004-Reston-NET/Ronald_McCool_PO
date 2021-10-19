using System;
namespace UI
{
    public class LineItemMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to LineItem Menu");
            Console.WriteLine("[0] Main Menuu");
            Console.WriteLine("[1] Add LineItem");
            Console.WriteLine("[2] Show LineItem");
        }

        public MenuType YourCoice()
        {
            String choice=Console.ReadLine();
            switch(choice){
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    return MenuType.AddLineItem;
                case "2":
                    return MenuType.ShowLineItem;
                default:
                    Console.WriteLine("What I don't understand re-select");
                    return MenuType.LineItemMenu;
            }
        }
    }
}