namespace UI
{
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        CustomerMenu,
        OrderMenu,
        ProductMenu,
        ShowProduct,
        AddProduct,
        AddCustomer,
        ShowCustomer,
        Exit

    }
   public interface IMenu
    {
        void Menu();
        MenuType YourCoice();
    }
}