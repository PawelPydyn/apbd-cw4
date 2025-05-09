using Microsoft.AspNetCore.Mvc;
using Zad4.Models;
namespace Zad4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase

    {
        [HttpGet("allVisits")]
        public IActionResult GetAllVisit()
        {
            var allVisits = Database.Visits.ToList();
            return Ok(allVisits);
        }

        [HttpGet("visitById")]
        public IActionResult GetVisit(int id)
        {
            var VisitById = Database.Visits.Where(e => e.AnimalId == id).ToList();
            return Ok(VisitById);
        }
        [HttpPost("addVisit")]
        public IActionResult AddVisit(int animalId,Visit visit)
        {
            if (!Database.Animals.Any(e => e.Id == animalId))
                return NotFound("Animal doesn't exist");

            visit.AnimalId = animalId;
            Database.Visits.Add(visit);
            return CreatedAtAction("AddVisit", new { animalId = visit.AnimalId }, visit);
        }
    }
}
