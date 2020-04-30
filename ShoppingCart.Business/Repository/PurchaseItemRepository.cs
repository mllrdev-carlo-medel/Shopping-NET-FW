using System;
using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Repository.Interfaces;

namespace ShoppingCart.Business.Repository
{
    public class PurchaseItemRepository : BaseRepository<PurchaseItem>, IPurchaseItemRepository
    {
        public override string Table => "PurchaseItem";
    }
}
