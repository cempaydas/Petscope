
using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _IHospitalService;
        public HospitalController(IHospitalService IHospitalService)
        {
            this._IHospitalService = IHospitalService;

        }
        [HttpPost]
        public IActionResult AddHospital(Hospital hospital)
        {
            if (hospital == null)
            {
                return BadRequest();
            }
            var re = _IHospitalService.AddHospital(hospital);

            return Ok(re);
        }

        [HttpGet]
        public IActionResult GetHospitals()
        {
            var re = _IHospitalService.GetHospitals();
            if (re == null)
            {
                return NotFound();
            }
            return Ok(re);

        }
        [HttpGet("{id}")]
        public IActionResult GetHospital(int id)
        {
            var re = _IHospitalService.GetHospital(id);
            if (re == null)
            {
                return NotFound();
            }
            return Ok(re);

        }

    }
}