using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class02.AspNet.Homework.Controllers.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        [HttpGet("get-movies/{date:DateTime}")]
        public IActionResult GetMovieByDate(DateTime date)
        {
            var movie = new
            {
                Name = "Avatar",
                IsAviable = true,
                Date = date
            };
            return Json(movie);
        }

        [HttpGet("get-movies/{isAvaiable:bool}")]
        public IActionResult GetMovieByAviability(bool isAvaiable)
        {
            var movie = new
            {
                Name = "Harry Potter",
                isAvaiable = isAvaiable
            };

            return Json(movie);
        }

    }
}
