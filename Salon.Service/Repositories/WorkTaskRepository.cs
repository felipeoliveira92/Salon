using Salon.Infra.Context;
using Salon.Model.Models;
using Salon.Service.Interfaces;
using System;
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
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(WorkTask model)
        {
            if(model != null)
            {
                _context.Tasks.Add(model);
                _context.SaveChanges();
            }            
        }

        public void Update(WorkTask model)
        {
            if(model != null)
            {
                _context.Tasks.Update(model);
                _context.SaveChanges();
            }
        }

        public List<WorkTask> GetAllByDate(DateTime date)
        {
            return _context.Tasks.Where(t => t.DateInitial.Date == date.Date).ToList();
        }

        public List<WorkTask> GetWorkTaskByFilter(DateTime dateInitial, DateTime dateEnd)
        {
            return _context.Tasks.Where(t => t.DateInitial.Date >= dateInitial.Date && t.DateInitial.Date <= dateEnd.Date).ToList();
        }
    }
}
