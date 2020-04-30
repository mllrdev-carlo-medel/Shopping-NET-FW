using System;
using System.Collections.Generic;
using System.Collections.Generic;
using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Model;

namespace ShoppingCart.Business.Model
{
    public class PurchaseHistory
    {
        public Purchase Purchase { get; }
        public List<PurchaseDetails> PurchaseDetails { get; }

        public PurchaseHistory(Purchase purchase)
        {
            Purchase = purchase;
            PurchaseDetails = new List<PurchaseDetails>();
        }
    }
}
