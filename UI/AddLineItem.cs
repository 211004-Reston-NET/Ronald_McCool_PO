using System;
using System.Collections.Generic;
using Models;
using RRBL;
namespace UI
{
    public class AddLineItem:IMenu
    {
        private static LineItem _lineItem=new LineItem();
        private IModelBL _modBL;
        public AddLineItem(IModelBL p_modBL){
            _modBL=p_modBL;
        }

        public void Menu()
        {
            Console.WriteLine("Add LineItem Menu");
            Console.WriteLine("[0} Main Menu");
            Console.WriteLine("[1} Enter Product");
            Console.WriteLine("[2] Enter Quntity");
            Console.WriteLine("[3] Add LineItem");
            Console.WriteLine("[4] LineItem Menu");
            
        }

        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "0":
                    return MenuType.MainMenu;
                case "1":
                     Product product=new Product();
                     Console.WriteLine("Enter product name");
                     product.Name=Console.ReadLine();
                     Console.WriteLine("Enter product price");
                     product.Price=double.Parse(Console.ReadLine());
                     Console.WriteLine("Enter product description");
                     product.Description=Console.ReadLine();
                     _lineItem.Products=product.ToString();
                    return MenuType.AddLineItem;
                case "2":
                     Console.WriteLine("Enter LineItem Quantity");
                     try{
                     _lineItem.Quantity=int.Parse(Console.ReadLine());
                     }catch(FormatException ){
                         Console.WriteLine("Invalid input");
                     }
                     return MenuType.AddLineItem;
                case "3":
                      _modBL.AddModel(_lineItem);
                      return MenuType.AddLineItem;
                case "4":
                     return MenuType.LineItemMenu;
                default:
                      Console.WriteLine("What I don't understand re-select");
                      return MenuType.AddLineItem;



            }
        }
    }
}