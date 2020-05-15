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
    public class PlaceOrdersController : ControllerBase
    {
           public PlaceOrdersController()
           {
                this.PlaceOrderDomain = new PlaceOrderDomain();
           }
          [HttpPost]
            public IActionResult Post(PlaceOrder placeOrder)
            {
            this.PlaceOrderDomain.Add(placeOrder);
              return Ok();
            }
       
         private PlaceOrderDomain PlaceOrderDomain { get; set; }
      
    }
    

}
