using System;
using ShoppingCart.Business.Manager;
using ShoppingCart_Console.View.Interfaces;
using ShoppingCart.Business.Entity;
using ShoppingCart.Business.Manager.Interfaces;
using System.Collections.Generic;

namespace ShoppingCart_Console.View
{
    public class GroceriesView : IGroceriesView
    {
        public IManager<Item> Manager { get; }

        public GroceriesView()
        {
            Manager = new ItemManager();
        }

        public void Show()
        {
            List<Item> items = Manager.GetAll();

            int count = 1;
            foreach (Item item in items)
            {
                Console.WriteLine($"{count++}. Name: {item.Name}, Barcode: {item.Id}," +
                                  $" Price: {item.Price}");
            }
        }
    }
}
