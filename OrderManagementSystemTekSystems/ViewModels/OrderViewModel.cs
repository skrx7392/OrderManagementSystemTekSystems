using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.ViewModels
{
    public abstract class OrderViewModel
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public int? AccountNumber { get; set; }
        public List<Service> Services { get; set; }

        public virtual void AddService(Service service)
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