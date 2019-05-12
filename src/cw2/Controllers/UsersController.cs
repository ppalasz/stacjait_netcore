using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        //[HttpGet]
        //[Route("")]
        //public IActionResult Index()
        //{
        //    var user = new User()
        //    {
        //        //Id = Guid.NewGuid(),
        //        //Role = "User",
        //        //Email = "test@test.pl",
        //        //CreatedAt = DateTime.UtcNow,
        //        //UpdatedAt = DateTime.UtcNow,
        //        //PasswordHash = "none"
        //    };
        //    return Json(user);

        //}

        [HttpPost]
        [Route("create")]
        public IActionResult Create(User user)
        {
            string test = user.Role + " " + user.Email;
            return Accepted();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Json(new User(Guid.NewGuid(), "test@test.pl", "user"));
        }
    }
}