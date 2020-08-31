using Class02.AspNet.Homework.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class02.AspNet.Homework.Controllers.Controllers
{
    [Route("pizza/order")]
    public class OrderController : Controller
    {
        [HttpGet("create-order")]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderModel request)
        {
            return Json(request);
        }
    }
}
