using System;
using RRBL;
namespace UI{
    public interface IFactory
    {
        /// <summary>
        /// Will give a derived/child class from IMenu interface based on enum menu typr
        /// </summary>
        /// <param name="p_menu">This will determine what menu to create</param>
        /// <returns>returns a derived/child class from IMenu</returns>
        IMenu GetMenu(MenuType p_menu);

    }
}