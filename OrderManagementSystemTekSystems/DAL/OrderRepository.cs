using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.DAL
{
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private OrderContext Context;
        public OrderRepository(OrderContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Order> GetOrders()
        {
            return Context.Orders.ToList();
        }
        public Order GetOrderByID(int orderId)
        {
            return Context.Orders.Find(orderId);
        }
        public void UpdateOrder(Order order)
        {
            Context.Entry(order).State = System.Data.Entity.EntityState.Modified;
        }
        public void InsertOrder(Order order)
        {
            Context.Orders.Add(order);
        }
        public void DeleteOrder(int orderId)
        {
            Order order = Context.Orders.Find(orderId);
            Context.Orders.Remove(order);
        }
        public void Save()
        {
            Context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}