using OrderManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public int? AccountNumber { get; set; }
        public List<IService> Services { get; set; }

        public virtual void AddService(IService service)
        {
            this.Services.Add(service);
        }

        public virtual string CancelOrder(int orderId)
        {
            return "Cancelled order " + orderId + " from base clasee";
        }

        public virtual string SendToBilling(int orderId)
        {
            return "Order id " + orderId + " sent to billing from base class";
        }
    }
}
