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
    public class FoodCategoriesController : ControllerBase
    {
        public FoodCategoriesController()
        {
            this.FoodCategoryDomain = new FoodCategoryDomain();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var foodCategories = this.FoodCategoryDomain.Get(id);
            return Ok(foodCategories);
        }

        private FoodCategoryDomain FoodCategoryDomain { get; set; }
    }
}
