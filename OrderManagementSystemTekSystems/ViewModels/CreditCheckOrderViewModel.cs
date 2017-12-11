using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.ViewModels
{
    public class CreditCheckOrderViewModel : OrderViewModel
    {
        public override void AddService(Service service)
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