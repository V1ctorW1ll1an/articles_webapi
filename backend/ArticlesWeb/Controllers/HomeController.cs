using System.Collections.Generic;
using ArticlesServices.ModelsDTO;
using ArticlesServices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArticlesWeb.Controllers
{
    [ApiController]
    [Route("/Home")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("")]
        public List<UserDto> Get()
        {
            var users = _userRepository.GetAllUsers();
            return users;
        }
    }
}