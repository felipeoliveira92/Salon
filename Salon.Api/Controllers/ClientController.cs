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
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpDelete("id")]
        public IActionResult DeleteClient(int id)
        {            
            try
            {
                if (id > 0)
                    _clientRepository.DeleteClient(id);

                return Ok("Cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel deletar o cliente - {ex.Message}");
            }
        }

        [HttpGet("id")]
        public Client GetClientById(int id)
        {
            if (id > 0)
                return _clientRepository.GetClientById(id);
            else
                return null;
        }

        [HttpGet("name")]
        public Client GetClientByName(string name)
        {
            if (name is not null)
                return _clientRepository.GetClientByName(name);
            else
                return null;
        }

        [HttpGet]
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

        [HttpPost]
        public IActionResult SaveClient(ClientDTO model)
        {
            try
            {
                var client = new Client
                {
                    Name = model.Name,
                    Cellphone = model.Cellphone
                };
                _clientRepository.SaveClient(client);
                return Ok("Cliente salvo com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel salvar o cliente - {ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult UpdateClient(Client model)
        {            
            try
            {
                _clientRepository.UpdateClient(model);
                return Ok("Cliente alterado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel alterar o cliente - {ex.Message}");
            }
        }
    }
}
