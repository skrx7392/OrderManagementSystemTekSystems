using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystemTekSystems.DAL
{
    public class ServiceRepository : IServiceRepository, IDisposable
    {
        private OrderContext Context;
        public ServiceRepository(OrderContext context)
        {
            this.Context = context;
        }

        public IEnumerable<Service> GetServices()
        {
            return Context.Services.ToList();
        }
        public Service GetServiceByID(int serviceId)
        {
            return Context.Services.Find(serviceId);
        }
        public void UpdateService(Service service)
        {
            Context.Entry(service).State = System.Data.Entity.EntityState.Modified;
        }
        public void InsertService(Service service)
        {
            Context.Services.Add(service);
        }
        public void DeleteService(int serviceId)
        {
            Service service = Context.Services.Find(serviceId);
            Context.Services.Remove(service);
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