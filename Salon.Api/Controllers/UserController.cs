using Microsoft.AspNetCore.Mvc;
using Salon.Model.Models;
using Salon.Service.DTOs;
using Salon.Service.Interfaces;
using System.Collections.Generic;

namespace Salon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            return _userRepository.GetUsers();
        }

        [HttpGet("id")]
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        [HttpGet("username")]
        public User GetUserByLogin(string username)
        {
            return _userRepository.GetUserByLogin(username);
        }

        [HttpPost]
        public IActionResult PostUser(User model)
        {
            try
            {
                _userRepository.SaveUser(model);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult UpdateUser(User model)
        {
            try
            {
                _userRepository.UpdateUser(model);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userRepository.DeleteUser(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("/login")]
        public IActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
                if (_userRepository.Login(username, password))
                    return Ok("Login efetuado com sucesso!");

            return BadRequest("Usuario ou senha incorretos!");
        }

        [HttpPost("/Register")]
        public IActionResult Register(RegisterDTO model)
        {
            if (ModelState.IsValid)
                if (_userRepository.Register(model))
                    return Ok();

            return BadRequest();
        }
    }
}
