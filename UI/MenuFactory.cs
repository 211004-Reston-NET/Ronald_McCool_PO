using System;
using Models;
using RRBL;
using RRDL;
namespace UI{

        /// <summary>
        /// Designed to create menu objects
        /// </summary>
    public  class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
           switch(p_menu){
               case MenuType.MainMenu:
                        return new MainMenu();
                    case MenuType.StoreMenu:
                        return new StoreMenu();
                    case MenuType.CustomerMenu:
                        return new CustomerMenu(); 
                    case MenuType.ProductMenu:
                        return new ProductMenu();
                    case MenuType.LineItemMenu:
                        return new LineItemMenu();
                    case MenuType.OrderMenu:
                        return new OrderMenu();
                    case MenuType.ShowProduct:
                        return new ShowProduct(new ModelBL(new Repository()) );
                    case MenuType.AddProduct:
                        return new AddProducts(new ModelBL(new Repository()));
                    case MenuType.ShowCustomer:
                        return new ShowCustomer(new ModelBL(new Repository()) );
                    case MenuType.AddCustomer:
                        return new AddCustomer(new ModelBL(new Repository()));
                    case MenuType.AddStore:
                        return new AddStore(new ModelBL(new Repository()));
                    case MenuType.ShowStore:
                        return new ShowStore(new ModelBL(new Repository()));
                    case MenuType.CurrentStore:
                        return new CurrentStore(new ModelBL(new Repository()));
                    case MenuType.AddLineItem:
                        return new AddLineItem(new ModelBL(new Repository()));
                    case MenuType.ShowLineItem:
                        return new ShowLineItems(new ModelBL(new Repository()));
                    case MenuType.ShowOrder:
                        return new ShowOrder(new ModelBL(new Repository()));
                    case MenuType.AddOrder:
                        return new AddOrder(new ModelBL(new Repository()));
                    case MenuType.CurrentCustomer:
                        return new CurrentCustomer(new ModelBL(new Repository()));
                    case MenuType.CurrentProduct:
                        return new CurrentProduct(new ModelBL(new Repository()));
                    default:
                        return null;
                      
           }
        }
    }

}