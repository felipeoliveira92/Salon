using Microsoft.AspNetCore.Mvc;
using Salon.Api.ViewModels;
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

        [HttpGet]
        public IActionResult Login(LoginViewModel model)
        {
            if(!string.IsNullOrEmpty(model.LoginUser))
            {
                if(_userRepository.Login(model.LoginUser, model.PasswordUser))
                {
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
