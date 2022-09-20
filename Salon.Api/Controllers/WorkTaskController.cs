using Microsoft.AspNetCore.Mvc;
using Salon.Model.Models;
using Salon.Service.DTOs;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Salon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkTaskController : Controller
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        public WorkTaskController(IWorkTaskRepository workTaskRepository)
        {
            _workTaskRepository = workTaskRepository;
        }

        [HttpGet]
        public List<WorkTask> GetAll()
        {
            var work =  _workTaskRepository.GetWorkTasks();
            return work;
        }

        [HttpGet("int:id")]
        public WorkTask GetWorkTaskById(int id)
        {
            return _workTaskRepository.GetWorkTaskById(id);
        }

        [HttpGet("date")]
        public List<WorkTask> GetAllByDate(DateTime date)
        {
            return _workTaskRepository.GetAllByDate(date);
        }

        [HttpGet("dateInit, dateEnd")]
        public List<WorkTask> GetWorkTaskByFilter(DateTime dateInitial, DateTime dateEnd)
        {
            return _workTaskRepository.GetWorkTaskByFilter(dateInitial, dateEnd);
        }

        [HttpPost]
        public IActionResult PostWorkTask(WorkTaskDTO model)
        {
            try
            {
                var work = new WorkTask
                {
                    DateInitial = model.DateInitial,
                    DateEnd = model.DateEnd,
                    IdClient = model.IdClient,
                    IdService = model.IdService,
                    IdUser = model.IdUser,
                    Price = model.Price,
                    Observation = model.Observation
                };
                _workTaskRepository.Insert(work);
                return Ok("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocorreu uma exceção sem tratamento - {ex}");
            }
        }

        [HttpPut]
        public IActionResult UpdateWorkTask(WorkTask model)
        {
            try
            {
                _workTaskRepository.Update(model);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public IActionResult DeleteWorkTask(int id)
        {
            try
            {
                _workTaskRepository.Delete(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
