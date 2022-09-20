using Salon.Model.Models;
using System;
using System.Collections.Generic;

namespace Salon.Service.Interfaces
{
    public interface IWorkTaskRepository
    {
        void Insert(WorkTask model);
        void Update(WorkTask model);
        void Delete(int id);
        WorkTask GetWorkTaskById(int id);
        List<WorkTask> GetWorkTasks();
        List<WorkTask> GetAllByDate(DateTime date);
        List<WorkTask> GetWorkTaskByFilter(DateTime dateInitial, DateTime dateEnd);
    }
}
