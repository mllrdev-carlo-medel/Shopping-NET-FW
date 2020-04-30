using ShoppingCart.Business.Entity;

namespace ShoppingCart_Console.View.Interfaces
{
    public interface ICartView : IView
    {
        void AddItem(Item item);
        void ChangeQuantity(Item item, int quantity);
        float ComputeTotalPrice();
    }
}
