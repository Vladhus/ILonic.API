using ILonic.API.DTO;
using ILonic.API.Entities;
using ILonic.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILonic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<ActionResult<bool>> Register([FromBody] UserRegisterDTO registerDTO)
        {
            var result = await _userRepository.Register(registerDTO);
            return Ok(result);
        }


        [HttpPost("login")]
        public async Task<ActionResult<bool>> Login([FromBody] UserLoginDTO loginDTO)
        {
            var result = await _userRepository.Login(loginDTO);
            return Ok(result);
        }
    }
}
