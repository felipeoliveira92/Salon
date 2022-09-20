using Salon.Infra.Context;
using Salon.Model.Models;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Service.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly SalonContext _context;

        public ClientRepository()
        {
            _context = new SalonContext();
        }

        public void DeleteClient(int id)
        {
            try
            {
                if (id != 0)
                {
                    var client = _context.Clients.Find(id);

                    _context.Clients.Remove(client);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Client GetClientById(int id)
        {
            try
            {
                var client = _context.Clients.FirstOrDefault(c => c.Id == id);
                return client;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Client GetClientByName(string name)
        {
            try
            {
                var client = _context.Clients.FirstOrDefault(c => c.Name == name);

                if(client is not null)
                    return client;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Client> GetClients()
        {
            try
            {
                return _context.Clients.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveClient(Client model)
        {
            try
            {
                if (model != null)
                {
                    _context.Clients.Add(model);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateClient(Client model)
        {
            try
            {
                if (model != null)
                {
                    _context.Clients.Update(model);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
