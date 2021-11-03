using System;
using RRBL;
using Models;
using System.Collections.Generic;
namespace UI
{
    public class CurrentProduct:IMenu
    {
        private IModelBL _curProdBL;

        public CurrentProduct(IModelBL p_model)
        {
            _curProdBL=p_model;
        }

        public void Menu()
        {
         System.Console.WriteLine("Welcome to find product by ID");
         System.Console.WriteLine("[1] Show Product BY id");
         System.Console.WriteLine("[0] Show Product menu");
            
        }

        public MenuType YourCoice()
        {
             string choice=Console.ReadLine();
            switch(choice)
            {
                case "1":
                   ListProdById();
                return MenuType.CurrentProduct;
                case "0":
                return MenuType.ShowProduct;
                default:
                    System.Console.WriteLine("What did you enter");
                    return MenuType.CurrentProduct;
            }
        }
        public void ListProdById(){
            System.Console.WriteLine("Enter product ID to search");
            int id=Int32.Parse(Console.ReadLine());
            System.Console.WriteLine(id);
            List<Product> byID =_curProdBL.GetAllProduct();
            foreach(Product p in byID){
                System.Console.WriteLine("hello");
                //if(p.ProdId==id){
                    Console.WriteLine("***********************");
                    Console.WriteLine(p);
                    Console.WriteLine("***********************");
               // }

            }
        }
    }
}