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
    public class ItemsController : ControllerBase
    {
        public ItemsController()
        {
            this.ItemDomain = new ItemDomain();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var items = this.ItemDomain.Get(id);
            return Ok(items);
        }

        private ItemDomain ItemDomain { get; set; }
    }
}
