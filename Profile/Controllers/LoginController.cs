using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profile.Models;
using Profile.Repository;

namespace Profile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        protected readonly IUserDataRepository<UserInfo> _userDataRepository;

        public LoginController(IUserDataRepository<UserInfo> userDataRepository)
        {
            _userDataRepository = userDataRepository;
        }

        /// <summary>Get all Users</summary>
        /// <param name="userId"></param>
        /// <returns></returns>

        [HttpGet("")]
        public IActionResult GetAllUsers()
        {
            IEnumerable<UserInfo> users = _userDataRepository.GetAll();
            return Ok(users);
        }
    }
}
