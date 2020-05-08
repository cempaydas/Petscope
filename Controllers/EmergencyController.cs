using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmergencyController:ControllerBase
    {
        private readonly IEmergencyService _IEmergencyService;
        public EmergencyController(IEmergencyService IEmergencyService)
        {
            this._IEmergencyService = IEmergencyService;

        }
        [HttpPost]
        public IActionResult AddHospital(Emergency emergency)
        {
            if(emergency==null){
                return BadRequest();
            }
            var re = _IEmergencyService.AddEmergency(emergency);
            return Ok(re);
        }

          [HttpGet]
        public IActionResult GetEmergencies()
        {
            var re=_IEmergencyService.GetEmergencies();
            if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
          [HttpGet("{id}")]
        public IActionResult GetEmergency(int id)
        {
            var re=_IEmergencyService.GetEmergency(id);
             if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
        
    }
}