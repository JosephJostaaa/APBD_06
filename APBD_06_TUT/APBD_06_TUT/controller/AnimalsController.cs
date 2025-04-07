using APBD_06.model;
using APBD_06.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_06_TUT.controller
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalsService animalsService = new AnimalsService();
        
        
        [HttpGet("{id:int}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok(id);
        }

        public IActionResult GetAnimals()
        {
            return Ok();
        }
    }
}
