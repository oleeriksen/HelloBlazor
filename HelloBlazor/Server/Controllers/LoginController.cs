using System;
using HelloBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using HelloBlazor.Server.Repositories;


namespace HelloBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        ILoginRepository mRepo;
        public LoginController(ILoginRepository repo)
        {
            mRepo = repo;
        }

        [HttpGet]
        [Route("verify")]
        public bool VerifyLogin([FromQuery] string email, [FromQuery] string password)
        {
            var isValid = mRepo.Verify(email, password);
            
            return isValid;
           
        }
    }
}

