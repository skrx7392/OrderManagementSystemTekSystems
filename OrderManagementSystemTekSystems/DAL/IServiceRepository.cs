using OrderManagementSystemTekSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystemTekSystems.DAL
{
    public interface IServiceRepository : IDisposable
    {
        IEnumerable<Service> GetServices();
        Service GetServiceByID(int serviceId);
        void InsertService(Service service);
        void DeleteService(int serviceId);
        void UpdateService(Service service);
        void Save();
    }
}
