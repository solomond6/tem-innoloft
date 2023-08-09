using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Innoloft.Data;
using Innoloft.Models;
using Innoloft.Services;

namespace Innoloft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService uService;
        public UserController(IUserService _uService)
        {
            uService = _uService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await Task.FromResult(uService.GetUserList());
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await Task.FromResult(uService.GetUserById(id));
        }

        // POST: api/User
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User _user)
        {
            return await Task.FromResult(uService.AddUser(_user));
        }

    }
}
