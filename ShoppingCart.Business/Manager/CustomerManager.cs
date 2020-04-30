using System;
using ShoppingCart.Business.Repository.Interfaces;
using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Manager.Interfaces;
using ShoppingCart.Business.Repository;

namespace ShoppingCart.Business.Manager
{
    public class CustomerManager : BaseManager<Customer>, ICustomerManager
    {
        public override IRepository<Customer> Repository => new CustomerRepository();
    }
}
