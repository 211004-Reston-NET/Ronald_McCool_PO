namespace UI
{
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        CustomerMenu,
        OrderMenu,
        ProductMenu,
        LineItemMenu,
        ShowProduct,
        AddProduct,
        CurrentProduct,
        AddCustomer,
        ShowCustomer,
        CurrentCustomer,
        AddStore,
        ShowStore,
        CurrentStore,
        AddLineItem,
        ShowLineItem,
        AddOrder,
        ShowOrder,
        Exit

    }
   public interface IMenu
    {
        void Menu();
        MenuType YourCoice();
    }
}