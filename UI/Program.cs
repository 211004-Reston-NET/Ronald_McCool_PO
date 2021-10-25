using System;
using RRDL;
using RRBL;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
          

           //this is a bool that either has a true or false value
           //used to control the while loop
            bool repeat = true;

            //moved the creation logic into another class called MenuFactory instead
            //follows the singleton principle
            IFactory factory=new MenuFactory();

            //this is an example of polymorphism, abstration, and inheritance all at the same time
            //ex: of covvariance
            //IMenu page = new MainMenu();
            IMenu page = factory.GetMenu(MenuType.MainMenu);

            //while loop will repeat until the repeat var is switched to false
            while (repeat)
            {
              

                page.Menu();
                MenuType currentPage = page.YourCoice();
                if(currentPage==MenuType.Exit)
                {
                     Console.WriteLine("BYE");
                        repeat = false;
                }
                else
                {
                    page=factory.GetMenu(currentPage);
                }
                
          
            }
        
           
        }
    }
   
}
