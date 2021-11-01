using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using RRBL;
using RRDL;
using RRDL.Entities;

namespace UI{

        /// <summary>
        /// Designed to create menu objects
        /// </summary>
    public  class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetting.json")
            .Build();
           DbContextOptions<qasvkiagContext> options = new DbContextOptionsBuilder<qasvkiagContext>()
            .UseNpgsql(configuration.GetConnectionString("Reference2DB")).Options;

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
                        return new ShowProduct(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))) );
                    case MenuType.AddProduct:
                        return new AddProducts(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.ShowCustomer:
                        return new ShowCustomer(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))) );
                    case MenuType.AddCustomer:
                        return new AddCustomer(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.AddStore:
                        return new AddStore(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.ShowStore:
                        return new ShowStore(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.CurrentStore:
                        return new CurrentStore(new ModelBL(new Repository()));
                    case MenuType.AddLineItem:
                        return new AddLineItem(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.ShowLineItem:
                        return new ShowLineItems(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.ShowOrder:
                        return new ShowOrder(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.AddOrder:
                        return new AddOrder(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.CurrentCustomer:
                        return new CurrentCustomer(new ModelBL(new Repository()));
                    case MenuType.CurrentProduct:
                        return new CurrentProduct(new ModelBL(new Repository()));
                    case MenuType.ShowCustById:
                        return new ShowCustById(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    case MenuType.ShowStoreById:
                        return new ShowStoreById(new ModelBL(new RepositoryDataBase(new qasvkiagContext(options))));
                    default:
                        return null;
                      
           }
        }

        
    }

}