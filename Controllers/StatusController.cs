using Microsoft.AspNetCore.Mvc;
using prof_sofware.Services;
using prof_sofware.Models;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private IStatusService _IStatusService;
        public StatusController(IStatusService IStatusService)
        {
            this._IStatusService = IStatusService;

        }

        [HttpPost]
        public IActionResult AddStatus(Status status)
        {
             if(status==null){
                return BadRequest();
            }
            var re = _IStatusService.AddStatus(status);
            return Ok(re);
        }
        [HttpGet]
        public IActionResult GetStatuses()
        {
            var statuses=_IStatusService.GetStatuses();
             if(statuses==null){
                return NotFound();
            }
            return Ok(statuses);

        }
        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            var statuses=_IStatusService.GetStatus(id);
             if(statuses==null){
                return NotFound();
            }
            return Ok(statuses);

        }

    }
}