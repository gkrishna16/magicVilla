using System;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Controllers

{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController()
        {

        }

        public IEnumerable<Users> GetUsers()
        {
            return new List<Users> {
                new Users{Id = 1, Name = "Gopal"},
                 new Users{Id = 2, Name = "Sarabjit"}
            };
        }


        //public IEnumerable<List<Users>> GetUsers()
        //{
            //List<Users> villaList = new List<Users>
            //{
            //    Id = 1, Name = "Gopal", Phone = 84459
            //}
            //return villaList;
    //}
	}
}


