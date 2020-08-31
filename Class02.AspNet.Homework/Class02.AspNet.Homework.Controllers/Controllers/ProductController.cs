using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class02.AspNet.Homework.Controllers.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet("get-product/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var product = new
            {
                Name = "Shirt",
                Id = id
            };
            return Json(product);
        }

        [HttpGet("get-product/{id:alpha}")]
        public IActionResult GetProductByName(string id)
        {
            var product = new
            {
                Name = "Shoes",
                Id = id
            };

            return Json(product);
        }

    }
}
