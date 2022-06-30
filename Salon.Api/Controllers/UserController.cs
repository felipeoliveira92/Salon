using Microsoft.AspNetCore.Mvc;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult GetUser(string login)
        {
            if(!string.IsNullOrEmpty(login))
            {
                if(_userRepository.GetUserByLogin(login) != null)
                {
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
