using Salon.Infra.Context;
using Salon.Model.Models;
using Salon.Service.DTOs;
using Salon.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Service.Repositories
{
    public class WorkTaskRepository : IWorkTaskRepository
    {
        private readonly SalonContext _context;

        public WorkTaskRepository()
        {
            _context = new SalonContext();
        }

        public void Delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    var task = _context.Tasks.Find(id);

                    _context.Tasks.Remove(task);
                    _context.SaveChanges();
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public WorkTask GetWorkTaskById(int id)
        {
            try
            {
                var task = _context.Tasks.Find(id);
                return task;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public List<WorkTask> GetWorkTasks()
        {
            try
            {
                return _context.Tasks.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Insert(InsertWorkTaskDTO model)
        {
            var task = new WorkTask
            {
                DateInitial = model.DateInitial,
                DateEnd = model.DateEnd,
                IdService = model.IdService,
                IdUser = model.IdUser,
                Price = model.Price,
                Observation = model.Observation
            };

            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Update(WorkTask model)
        {
            var task = new WorkTask
            {
                DateInitial = model.DateInitial,
                DateEnd = model.DateEnd,
                IdService = model.IdService,
                IdUser = model.IdUser,
                Price = model.Price,
                Observation = model.Observation
            };

            _context.Tasks.Update(task);
            _context.SaveChanges();
        }
    }
}
