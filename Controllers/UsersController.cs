using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.domain;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
            this.UserDomain = new UserDomain();
        }
        [HttpPost]
        public IActionResult Post(User user)
        {
            var isLoggedIn = this.UserDomain.IsLogIn(user);
            return Ok(isLoggedIn);
        }
        //[HttpPatch("{id}")]
        //public IActionResult Patch(int id,[FromBody]User user)
        //{
        //    using()
        //    var users = this.UserDomain();
        //    Patch.ApplyTo(users);
        //    return Ok(users);
        //}

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
        {
             this.UserDomain.IsDelete(id);
            return Ok("User is delete");

        }
       

        private UserDomain UserDomain { get; set; }
    }
}
