using Labb_4_Generic_Collections.Models;

namespace Labb_4_Generic_Collections.Models
{
    internal class Program
    {
        public static void Main()
        {
            Restaurant restaurant = new Restaurant();
            MenuItem pizza = new MenuItem(1, "Pizza", 199m);
            MenuItem fisk = new MenuItem(2, "Fisk", 150m);
            MenuItem köttbullar = new MenuItem(3, "Köttbullar", 110m);
            MenuItem pannkakor = new MenuItem(4, "Pannkakor", 80m);

            restaurant.AddtoMenu(pizza);
            restaurant.AddtoMenu(fisk);
            restaurant.AddtoMenu(köttbullar);
            restaurant.AddtoMenu(pannkakor);

            restaurant.ShowMenu();

            List<MenuItem> order1Items = new List<MenuItem> {pizza, pannkakor };
            Order order1 = new Order(order1Items, 12);

            restaurant.CreateOrder(order1);

            List<MenuItem> order2Items = new List<MenuItem> { fisk, köttbullar };
            Order order2 = new Order(order2Items, 5);

            restaurant.CreateOrder(order2);

            List<MenuItem> order3Items = new List<MenuItem> { pannkakor, fisk };
            Order order3 = new Order(order3Items, 8);

            restaurant.CreateOrder(order3);

            restaurant.ShowOrders();

            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();

            restaurant.HandleOrder();

            restaurant.ShowOrderCount();

            List<MenuItem> order4Items = new List<MenuItem> { köttbullar, pizza };
            Order order4 = new Order(order4Items, 7);

            restaurant.CreateOrder(order4);

            restaurant.ShowOrderCount();

            restaurant.HandleOrder();

            restaurant.HandleOrder();

            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();

            restaurant.HandleOrder();

            restaurant.ShowOrderCount();
        }
    }
}