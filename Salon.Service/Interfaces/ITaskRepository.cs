using Salon.Model.Models;
using Salon.Service.DTOs;
using System.Collections.Generic;

namespace Salon.Service.Interfaces
{
    public interface ITaskRepository
    {
        void Insert(InsertWorkTaskDTO model);
        void Update(WorkTask model);
        void Delete(int id);
        WorkTask GetWorkTaskById(int id);
        List<WorkTask> GetWorkTasks();
    }
}
