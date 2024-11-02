using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Configer.contract.Interfac;
using MovieApp.Application.DTO;

namespace MovieApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ImoveServies _imoveServies;

        public MovieController(ImoveServies imoveServies)
        {
            _imoveServies = imoveServies;
        }
        //=------------------
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult GetByid()
        {
            return Ok();
        }
        //=====================

        [HttpPost]

        public IActionResult CreateMovie(MovieDTO movieDTO)
        {
            //no automaper 
            var reuslt = _imoveServies.CreateMovie(movieDTO);

            return Ok(reuslt);
        }

        [HttpPut]

        public IActionResult UpdateMovie()
        {
            return Ok();
        }

        [HttpDelete]

        public IActionResult DeleteMovie()
        {
            return Ok();
        }

        //==========================
    }
}
