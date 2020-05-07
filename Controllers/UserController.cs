using System;
using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
         private readonly IUserService _userService;

         public UserController(IUserService userService)
         {
             this._userService=userService;
             
         }
       

        [HttpPost]
        public   IActionResult Register(User user){
          
            var dene=_userService.AddUserAsync(user);


            return Ok(user);

        }
        [HttpGet("{id}")]

        public   IActionResult GetUser(int id){
          
            var user=_userService.GetUser(id);


            return Ok(user);

        }
         [HttpGet]

        public   IActionResult AllUser(){
          
            var user=_userService.GetUsers();


            return Ok(user);

        }


        
    }
}