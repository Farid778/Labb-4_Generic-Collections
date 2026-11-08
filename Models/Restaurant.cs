using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_4_Generic_Collections.Models
{
    internal class Restaurant
    {
        private List<MenuItem> _menu = new List<MenuItem>();

        private Queue<Order> _orders = new Queue<Order>();
            

        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Rätten {menuItem.Name} lades till i menyn.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            foreach(MenuItem item in _menu)
            {
                Console.WriteLine(item);
            }
        }

        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine("Order lades till.");
            order.PrintOrder();
        }

        public void ShowOrders()
        {
            Console.WriteLine("Beställningar:");
            foreach(Order order in _orders)
            {
                order.PrintOrder();

            }
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"Antal beställningar i kön: {_orders.Count}"); 
        }

        public void ShowNextOrder()
        {
            Order nextOrder = _orders.Peek();
            Console.WriteLine("Nästa order:");
            nextOrder.PrintOrder();
        }

        public void HandleOrder()
        {
            Order handledorder = _orders.Dequeue();
            Console.WriteLine("Beställningen hanterades.");
            handledorder.PrintOrder();
        }

    }
}
