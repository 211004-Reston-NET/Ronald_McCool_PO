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
             List<Product> listOfProd =_curProdBL.GetProd(ShowProduct._findProdName);
            Console.WriteLine("The search result");
            foreach(Product prod in listOfProd){
                Console.WriteLine("*******************************");
                Console.WriteLine(prod);
                Console.WriteLine("********************************");
            }
           
            
        }

        public MenuType YourCoice()
        {
             string choice=Console.ReadLine();
            switch(choice)
            {
                case "0":
                return MenuType.ShowProduct;
                default:
                    System.Console.WriteLine("What did you enter");
                    return MenuType.CurrentProduct;
            }
        }
    }
}