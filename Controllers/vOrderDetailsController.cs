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
    public class vOrderDetailsController : ControllerBase
    {
           public vOrderDetailsController()
           {
                this.vOrderDetailDomain = new vOrderDetailDomain();
           }
          [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var orderDetails = this.vOrderDetailDomain.Get(id);
              return Ok(orderDetails);
            }
        [HttpPost]
        public IActionResult Post(vOrderDetail orderDetail)
        {
            this.vOrderDetailDomain.Add(orderDetail);
                return Ok();
        }

         private vOrderDetailDomain vOrderDetailDomain { get; set; }
      
    }
    

}
