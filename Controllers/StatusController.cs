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
            var re = _IStatusService.AddStatus(status);
            return Ok(re);
        }
        [HttpGet]
        public IActionResult GetStatuses()
        {
            var statuses=_IStatusService.GetStatuses();
            return Ok(statuses);

        }
        [HttpGet("{id}")]
        public IActionResult GetStatus(int id)
        {
            var statuses=_IStatusService.GetStatus(id);
            return Ok(statuses);

        }

    }
}