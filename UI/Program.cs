using System;
using System.Collections.Generic;
using RRDL;
using Models;
using RRBL;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
          

            IMenu page = new MainMenu();
            bool repeat = true;
            while (repeat)
            {

                page.Menu();
                MenuType currentPage = page.YourCoice();
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuType.StoreMenu:
                        page = new StoreFrontMenu();
                        break;
                    case MenuType.CustomerMenu:
                        page = new CustomerMenu();
                        break;
                    case MenuType.ProductMenu:
                        page=new ProductMenu();
                        break;
                    case MenuType.ShowProduct:
                        page=new ShowProduct(new ModelBL(new Repository()) );
                        break;
                    case MenuType.AddProduct:
                        page=new AddProducts(new ModelBL(new Repository()));
                        break;
                    case MenuType.ShowCustomer:
                        page=new ShowCustomer(new ModelBL(new Repository()) );
                        break;
                    case MenuType.AddCustomer:
                        page=new AddCustomer(new ModelBL(new Repository()));
                        break;
                    case MenuType.Exit:
                        Console.WriteLine("BYE");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        repeat = false;
                        break;

                }
            }
        
           
        }
    }
   
}
