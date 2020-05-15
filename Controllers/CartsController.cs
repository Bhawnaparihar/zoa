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
    [Route("[Controller]")]
    public class CartsController : ControllerBase
    {
           public CartsController()
           {
                this.CartDomain = new CartDomain();
           }
          [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var carts = this.CartDomain.Get(id);
              return Ok(carts);
            }
        [HttpPost]
        public IActionResult Post(Cart cart)
        {
            this.CartDomain.Add(cart);
                return Ok();
        }

         private CartDomain CartDomain { get; set; }
      
    }
    

}
