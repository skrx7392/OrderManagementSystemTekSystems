using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.DAL
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderContext")
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}