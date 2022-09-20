using Salon.Model.Models;
using System.Collections.Generic;

namespace Salon.Service.Interfaces
{
    public interface IClientRepository
    {
        void SaveClient(Client model);
        void DeleteClient(int id);
        void UpdateClient(Client model);
        List<Client> GetClients();
        Client GetClientById(int id);
        Client GetClientByName(string name);
    }
}
