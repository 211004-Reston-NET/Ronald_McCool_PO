using System;
using System.Collections.Generic;
using Models;
using RRBL;

namespace UI
{
    public class ShowProduct:IMenu
    {
        private IModelBL _restBL;
        //we are defining the dependecies this class needs to operate
        //we do this it this way because we can easily switch out which implementation details we will be using
        //But later we will be able to switch our RRDL proj to point to an actual database in the cloud 
        // without touching anything else to have that implementation
        public static string _findProdName;
        public ShowProduct(IModelBL p_restBl){
            _restBL=p_restBl;
        }
        
        public void Menu()
        {
            //ListTheProducts();
            System.Console.WriteLine("[0] Main Menu");
            System.Console.WriteLine("[1] List Products");
            System.Console.WriteLine("[2] Product Menu");
           
        }
        
        public MenuType YourCoice()
        {
             string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;      
                case "1":
                    ListTheProducts();
                    return MenuType.ShowProduct;
                case "2":
                    return MenuType.ProductMenu;
                default:
                    Console.WriteLine("You have to enter a choice");
                    return MenuType.MainMenu;
            }
        }
         public void ListTheProducts(){
             System.Console.WriteLine("List of Products");
            List<Product> listOfProduct=_restBL.GetAllProduct(); 
            foreach(Product prod in listOfProduct){
                System.Console.WriteLine("==============================================================");
                System.Console.WriteLine(prod);
                System.Console.WriteLine("==============================================================");
            }
        }
         

        
    }
}