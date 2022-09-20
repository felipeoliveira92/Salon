using Salon.Model.Models;
using System.Collections.Generic;

namespace Salon.Service.Interfaces
{
    public interface IServiceRepository
    {
        void SaveService(Services model);
        void DeleteService(int id);
        void UpdateService(Services model);
        List<Services> GetServices();
        Services GetServiceById(int id);
        Services GetServiceByName(string name);
    }
}
