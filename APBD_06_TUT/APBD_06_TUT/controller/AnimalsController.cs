using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_06_TUT.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok(id);
        }
    }
}
