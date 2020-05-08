using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
     public class UserForLoginDto
    {
        public string UserName { get; set; }
        public string Password{get;set;}
        
    }

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;

        }


        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
              string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: user.Password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
            user.Password=hashed;
            user.Salt=salt;
            var dene = _userService.AddUserAsync(user);


            return Ok(user);

        }

         [HttpPost("login")]
        public IActionResult login(UserForLoginDto user)
        {
           
            var dene = _userService.Login(user.UserName,user.Password);


            return Ok(user);

        }
        
        [HttpGet("{id}")]

        public IActionResult GetUser(int id)
        {

            var user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }


            return Ok(user);

        }

        [HttpGet]
        public IActionResult AllUser()
        {

            var user = _userService.GetUsers();
            if (user == null)
            {
                return NotFound();
            }


            return Ok(user);

        }



    }
}