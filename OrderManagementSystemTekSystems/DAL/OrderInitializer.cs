using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.DAL
{
    public class OrderInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OrderContext>
    {
        protected override void Seed(OrderContext context)
        {
            var orders = new List<Order>
            {
                new Order{ID = 1, AccountNumber = 123, CustomerName = "Krishna", OrderType=1},
                new Order{ID = 2, AccountNumber = 234, CustomerName = "SK", OrderType=2},
                new Order{ID = 3, AccountNumber = 345, CustomerName = "Pod", OrderType=3},
                new Order{ID = 4, AccountNumber = 456, CustomerName = "KP", OrderType=1},
                new Order{ID = 5, AccountNumber = 567, CustomerName = "SKR", OrderType=2},
                new Order{ID = 6, AccountNumber = 678, CustomerName = "kris", OrderType=3},
                new Order{ID = 7, AccountNumber = 789, CustomerName = "elia", OrderType=1},
                new Order{ID = 8, AccountNumber = 890, CustomerName = "sri", OrderType=2},
                new Order{ID = 9, AccountNumber = 901, CustomerName = "siva", OrderType=3},
                new Order{ID = 10, AccountNumber = 902, CustomerName = "ram", OrderType=1},
            };
            orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();
            var services = new List<Service>
            {
                new Service{ID = 1, Name="sv1", OrderID=1},
                new Service{ID = 2, Name="sv2", OrderID=1},
                new Service{ID = 3, Name="sv3", OrderID=2},
                new Service{ID = 4, Name="sv4", OrderID=2},
                new Service{ID = 5, Name="sv5", OrderID=3},
                new Service{ID = 6, Name="sv6", OrderID=3},
                new Service{ID = 7, Name="sv7", OrderID=4},
                new Service{ID = 8, Name="sv8", OrderID=4},
                new Service{ID = 9, Name="sv9", OrderID=5},
                new Service{ID = 10, Name="sv10", OrderID=5},
                new Service{ID = 11, Name="sv11", OrderID=6},
                new Service{ID = 12, Name="sv12", OrderID=6},
                new Service{ID = 13, Name="sv13", OrderID=7},
                new Service{ID = 14, Name="sv14", OrderID=7},
                new Service{ID = 15, Name="sv15", OrderID=8},
                new Service{ID = 16, Name="sv16", OrderID=8},
                new Service{ID = 17, Name="sv17", OrderID=9},
                new Service{ID = 18, Name="sv18", OrderID=9},
                new Service{ID = 19, Name="sv19", OrderID=10},
                new Service{ID = 20, Name="sv20", OrderID=10},
            };
            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();
        }
    }
}