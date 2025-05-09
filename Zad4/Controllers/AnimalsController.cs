using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Zad4.Models;

namespace Zad4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet("all")]
        public IActionResult Get()
        {
            var allAnimals = Database.Animals.ToList();
            return Ok(allAnimals);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var animalById = Database.Animals.FirstOrDefault(a => a.Id == id);
            return Ok(animalById);
        }

        [HttpPost("add")]
        public IActionResult AddAnimal(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();

        }

        [HttpPut("edit")]
        public IActionResult EditAnimal(Animal animal)
        {
            var AnimalToEdit = Database.Animals.FirstOrDefault(e => e.Id == animal.Id);
            if (AnimalToEdit == null)
            {
                return BadRequest("Animal doesn't exist");
            }
            else
            {
                AnimalToEdit.Id = animal.Id;
                AnimalToEdit.Name = animal.Name;
                AnimalToEdit.Weight = animal.Weight;
                AnimalToEdit.Category = animal.Category;
                AnimalToEdit.HairColor = animal.HairColor;
            }
            return Ok(AnimalToEdit);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteAnimal(int id)
        {
            var AnimalToDelete = Database.Animals.FirstOrDefault(x => x.Id == id);

            if (AnimalToDelete == null)
            {
                return BadRequest("Animal doesn't exist");
            }
            else
            {
                Database.Animals.Remove(AnimalToDelete);
            }
            return Created();
        }
        [HttpGet("byName")]
        public IActionResult GetAnimalByName(string name)
        {
            var AnimalsByName = Database.Animals.FindAll(x => x.Name == name);
            return Ok(AnimalsByName);
        }


    }
}
