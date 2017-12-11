using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int OrderType { get; set; }
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}