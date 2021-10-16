namespace UI
{
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        CustomerMenu,
        OrderMenu,
        Inventory,
        ShowProduct,
        AddProduct,
        Exit

    }
   public interface IMenu
    {
        void Menu();
        MenuType YourCoice();
    }
}