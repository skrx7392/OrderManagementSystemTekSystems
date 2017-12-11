using OrderManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class CreditCheckOrderService : Order
    {
        public override void AddService(IService service)
        {
            this.Services.Add(service);
        }

        public override string CancelOrder(int orderId)
        {
            return "Cancelled order " + orderId + " from credit check class";
        }

        public override string SendToBilling(int orderId)
        {
            return "Order id " + orderId + " sent to billing from credit check class";
        }
    }
}
