using OrderManagementSystem.Services.Interfaces;
using System;

namespace OrderManagementSystem.Services
{
    public class ParamedOrderService : Order
    {
        public override void AddService(IService service)
        {
            this.Services.Add(service);
        }

        public override string CancelOrder(int orderId)
        {
            return "Cancelled order " + orderId + " from paramed class";
        }

        public override string SendToBilling(int orderId)
        {
            return "Order id " + orderId + " sent to billing from paramed class";
        }
    }
}
