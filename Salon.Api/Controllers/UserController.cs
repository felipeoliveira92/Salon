using Microsoft.AspNetCore.Mvc;
using Salon.Api.ViewModels;
using Salon.Service.DTOs;
using Salon.Service.Interfaces;

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

        [HttpPost("/Register")]
        public IActionResult Register(RegisterDTO model)
        {
            if (ModelState.IsValid)
                if (_userRepository.Register(model))
                    return Ok();

            return BadRequest();
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
                if (_userRepository.Login(model.LoginUser, model.PasswordUser))
                    return Ok("Login efetuado com sucesso!");

            return BadRequest("Usuario ou senha incorretos!");
        }
    }
}
