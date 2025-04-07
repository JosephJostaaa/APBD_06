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
        private AnimalsService _animalsService = new AnimalsService();
        
        
        [HttpGet("{id:int}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok(id);
        }

        [HttpGet]
        public IActionResult GetAnimals()
        {
            List<Animal> animals = _animalsService.GetAllAnimals();
            return Ok(animals);
        }

        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            _animalsService.AddAnimal(animal);
            return Created(animal.Id.ToString(), animal);
        }
    }
}
