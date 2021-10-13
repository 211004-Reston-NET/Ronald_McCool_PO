using System;
using System.Collections.Generic;
using RRDL;
using Models;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! How are you");
            //Serilization serilization=new Serilization();
            //serilization.SerialMain();
            Product p=new Product(){
                Name= "Widget",
                Price=300.00,
                Description =" just a gismo"

            };
            Repository repository=new Repository();
            repository.AddProduct(p);
            List<Product> listP=repository.GetAllProduct();
            foreach(Product prod in listP)
            {
                System.Console.WriteLine(prod);
            }
            Store store=new Store(){
                Name="HEB",
                Address="1212 Huebner",
               // List<Product> Products =new List<Product>(),
                
               // List<Order> Orders= new List<Order>()
               };
            repository.AddStore(store);

            Order order=new Order(){
               //List<LineItem> lineItem=new List<LineItem>(),
                StoreLocation ="San Antonio",
                Price = 230.00

            };
            repository.AddOrder(order);

            Customer customer =new Customer(){
                Name="John Doe",
                Address = "111 Doe st",
                Phone="915-344-5523"
                //List<Order> order=new List<Order>()
            };
            repository.AddCustomer(customer);

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
                    case MenuType.Inventory:
                        page = new InventoryMenu();
                        break;
                    case MenuType.OrderMenu:
                        page = new OrderMenu();
                        break;
                    case MenuType.CustomerMenu:
                        page = new CustomerMenu();
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
