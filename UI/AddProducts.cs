using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using RRBL;

namespace UI
{
    public class AddProducts:IMenu
    {
        private static Product _prod=new Product();
        private IModelBL _modBL;
        public AddProducts(IModelBL p_modBL){
            _modBL=p_modBL;
        }

      public void Menu(){
          Console.WriteLine("Add product Menu");
          Console.WriteLine("[5] Main Menu");
          Console.WriteLine("[4] Enter product name");
          Console.WriteLine("[3] Enter product price");
          Console.WriteLine("[2] Enter product description");
          Console.WriteLine("[1] Add product");
          Console.WriteLine("[0] Go back to Product Menu");
      }
   

        public MenuType YourCoice()
        {
            string choice=Console.ReadLine();
            switch(choice){
                case "5":
                return MenuType.MainMenu;
                case "4":
                Console.WriteLine("Enter Product name");
               _prod.Name= Console.ReadLine();
                return MenuType.AddProduct;
                case "3":
                Console.WriteLine("Enter product price");
                try{
                _prod.ProdPrice=decimal.Parse(Console.ReadLine());
                }
                catch(Exception )
                {
                    Console.WriteLine("Please enter valid price");
                }
                return MenuType.AddProduct;
                case "2":
                Console.WriteLine("Enter product description");
                _prod.Description=Console.ReadLine();
                return MenuType.AddProduct;
                case "1":
                _modBL.AddModel(_prod);
                return MenuType.AddProduct;
                case "0":
                return MenuType.ProductMenu;
                default:
                Console.WriteLine("What I don't understand. Try again!!");
                return MenuType.AddProduct;
            }

            
        }
    }
}