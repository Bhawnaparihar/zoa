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
    public class RestaurantsController : ControllerBase
    {
        public RestaurantsController()
        {
            this.RestaurantDomain = new RestaurantDomain();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var restaurants = this.RestaurantDomain.Get();
            return Ok(restaurants);
        }

        private RestaurantDomain RestaurantDomain { get; set; }
    }
}
