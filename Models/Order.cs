using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labb_4_Generic_Collections.Models
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order {_orderId}, bord nummer {_tableNumber}");

            foreach(MenuItem item in _orderItems)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
