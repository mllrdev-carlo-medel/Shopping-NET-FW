using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Manager.Interfaces;
using ShoppingCart.Business.Repository;
using ShoppingCart.Business.Repository.Interfaces;

namespace ShoppingCart.Business.Manager
{
    public class ItemManager : BaseManager<Item>, IItemManager
    {
        public override IRepository<Item> Repository => new ItemRepository();
    }
}
