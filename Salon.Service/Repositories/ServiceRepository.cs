using Salon.Infra.Context;
using Salon.Model.Models;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Service.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SalonContext _context;

        public ServiceRepository()
        {
            _context = new SalonContext();
        }

        public void DeleteService(int id)
        {
            try
            {
                if (id != 0)
                {
                    var service = _context.Services.Find(id);

                    _context.Services.Remove(service);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Services GetServiceById(int id)
        {
            try
            {
                var service = _context.Services.FirstOrDefault(s => s.Id == id);
                return service;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Services GetServiceByName(string name)
        {
            try
            {
                var service = _context.Services.FirstOrDefault(s => s.Name == name);

                if (service is not null)
                    return service;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Services> GetServices()
        {
            try
            {
                return _context.Services.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SaveService(Services model)
        {
            try
            {
                if (model != null)
                {
                    _context.Services.Add(model);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void UpdateService(Services model)
        {
            try
            {
                if (model != null)
                {
                    _context.Services.Update(model);
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
