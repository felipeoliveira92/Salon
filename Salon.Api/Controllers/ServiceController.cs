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
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteService(int id)
        {
            try
            {
                if (id > 0)
                    _serviceRepository.DeleteService(id);

                return Ok("Serviço deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel deletar o serviço - {ex.Message}");
            }
        }

        [HttpGet("{id:int}")]
        public Services GetServiceById(int id)
        {
            if (id > 0)
                return _serviceRepository.GetServiceById(id);
            else
                return null;
        }

        [HttpGet("{name}")]
        public Services GetServiceByName(string name)
        {
            if (name is not null)
                return _serviceRepository.GetServiceByName(name);
            else
                return null;
        }

        [HttpGet]
        public List<Services> GetServices()
        {
            return _serviceRepository.GetServices();
        }

        [HttpPost]
        public IActionResult SaveService(ServiceDTO model)
        {
            try
            {
                var service = new Services
                {
                    
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price
                };
                _serviceRepository.SaveService(service);
                return Ok("Serviço salvo com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel salvar o serviço - {ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult UpdateService(Services model)
        {
            try
            {
                _serviceRepository.UpdateService(model);
                return Ok("serviço alterado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel alterar o serviço - {ex.Message}");
            }
        }
    }
}
