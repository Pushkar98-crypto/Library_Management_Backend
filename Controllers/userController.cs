using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_mangement_backend.Repositories;
using Library_mangement_backend.Models;


namespace Library_mangement_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IUser _IUser;

        public userController(IUser user)
        {
            _IUser = user;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Getusers()
        {
            return await _IUser.Get();
        }


        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var newUser = await _IUser.Create(user);
            return CreatedAtAction(nameof(Getusers), new { userId = newUser.userId }, newUser);

        }

        [HttpPost]
        [Route("login")]

        public async Task<ActionResult<User>>GetUser([FromBody] User user) 
        {
            User response= await _IUser.GetAuth(user);

            if(response!=null)
            {
                return response;
            }

            return NoContent();
            
                        

        }



    }
}
