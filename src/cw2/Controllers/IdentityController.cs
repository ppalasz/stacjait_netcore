using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw2.Auth;
using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : Controller
    {
        private IAuthService _authService;

        public IdentityController(IAuthService authService)
        {
            _authService = authService;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        [Route("signUp")]
        public IActionResult SignUp(UserSignUpResource resource)
        {
            var userId = Guid.NewGuid();
            _authService.SignUpAsync(userId, resource.Email, resource.Password, resource.Role);
            return Ok();
        }

        [HttpPost]
        [Route("signIn")]
        public IActionResult SignIn(UserSignInResource resource)
        {
            var temp =  _authService.SignInAsync(resource.Email, resource.Password).Result;
            return Ok(temp);
        }
    }
}