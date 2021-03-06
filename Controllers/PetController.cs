using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
       private readonly IPetService _IPetService;
        public PetController(IPetService IPetService)
        {
            this._IPetService = IPetService;

        }
        [HttpPost]
        public IActionResult AddHospital(Pet pet)
        {
             if(pet==null){
                return BadRequest();
            }
            var re = _IPetService.AddPet(pet);
            return Ok(re);
        }

          [HttpGet]
        public IActionResult GetPets()
        {
            var re=_IPetService.GetPets();
             if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
          [HttpGet("{id}")]
        public IActionResult GetPet(int id)
        {
            var re=_IPetService.GetPet(id);
             if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
    }
}