using System;
using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserTypeController : ControllerBase
    {
        private readonly IUserTypeService _userTypeService;

        public UserTypeController(IUserTypeService userTypeService)
        {
            this._userTypeService = userTypeService;

        }

        [HttpPost]
        public IActionResult AddUserType(UserType userType)
        {

            if (userType == null)
            {
                return BadRequest();
            }
            var inserted = _userTypeService.AddUserType(userType);



            return Ok(inserted);

        }
        [HttpGet("{id}")]
        public IActionResult GetUserType(int id)
        {

            var userType = _userTypeService.GetUserType(id);

            if (userType == null)
            {
                return NotFound();
            }

            return Ok(userType);

        }

        [HttpGet]
        public IActionResult GetUserTypes()
        {

            var userTypes = _userTypeService.GetUserTypes();
            if (userTypes == null)
            {
                return NotFound();
            }


            return Ok(userTypes);

        }

    }
}