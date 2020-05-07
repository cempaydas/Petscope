using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenusController : ControllerBase
    {
        private readonly IGenusService _IGenusService;
        public GenusController(IGenusService IGenusService)
        {
            this._IGenusService = IGenusService;

        }

         [HttpPost]
        public IActionResult AddGenus(Genus genus)
        {
            var re = _IGenusService.AddGenus(genus);
            return Ok(re);
        }
        [HttpGet]
        public IActionResult GetGenus()
        {
            var re=_IGenusService.GetGenus();
            return Ok(re);

        }
        [HttpGet("{id}")]
        public IActionResult GetGenus(int id)
        {
            var re=_IGenusService.GetGenus(id);
            return Ok(re);

        }
    }
}