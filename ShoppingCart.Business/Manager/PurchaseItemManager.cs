using ShoppingCart.Business.Repository.Interfaces;
using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Manager.Interfaces;
using ShoppingCart.Business.Repository;

namespace ShoppingCart.Business.Manager
{
    public class PurchaseItemManager : BaseManager<PurchaseItem>, IPurchaseItemManager
    {
        public override IRepository<PurchaseItem> Repository => new PurchaseItemRepository();
    }
}
