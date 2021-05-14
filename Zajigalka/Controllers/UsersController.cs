using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zajigalka.Models;
using Zajigalka.Services;

namespace Zajigalka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userServicec;
        private readonly ContextDB contextDB;
        public UsersController(ContextDB contextDB, IUserService userService)
        {
            this.contextDB = contextDB;
            userServicec = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return await contextDB.Users.ToListAsync();
        }

        [HttpGet]
        [Route("getrollingret")]
        public ActionResult<IEnumerable<TimeSpan>> GetRollingRet()
        {
            return userServicec.GetLiveSpan();
        }
        [HttpGet]
        [Route("getrollingrett")]
        public ActionResult<string> GetRollning2()
        {
            return userServicec.RollingUser7();
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            contextDB.Users.Add(user);
            contextDB.SaveChanges();
            return Ok(user);
        }




    }
}
